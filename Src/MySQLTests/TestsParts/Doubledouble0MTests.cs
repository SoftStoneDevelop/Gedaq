

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
    internal partial interface IDoubleSingleTypedouble
    {
    }
    
    internal partial class DoubleSingleTypedouble : IDoubleSingleTypedouble
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(5)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(5)
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, 875115535, 0.46374003479680503d, 0.12415173764807541d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, 1720607988, 0.7407298954460602d, null);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, 802802415, 0.22176422924096817d, 0.8446053434841867d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, 1505779201, 0.7898132891845059d, 0.8636196704801606d);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModel(connection, 1404770691, 0.6498321263207415d, 0.9325063585873464d);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 336021829, 0.20145948616671006d, 0.05903142605268341d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 1289204788, 0.4435564014278265d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 1968331481, 0.1162204702688181d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 108219923, 0.3684865038698446d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 655364919, 0.3135657215682135d, 0.19952741120915363d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 1059011131, 0.13773672355443667d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 2043499748, 0.8209479880357768d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 1630089674, 0.9838473979206824d, 0.6715380646005925d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 950197361, 0.4634175823546207d, 0.7246645315157461d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, 570192508, 0.8038422630883658d, 0.5115669104551862d);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(5)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(5),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, 661621524, 0.3748263241795934d, 0.05808252842820083d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, 649334183, 0.36435716954265873d, null, 875115535);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, 575719214, 0.5942702240115573d, 0.9415929547650043d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, 1134150859, 0.29020336811869774d, null, 1720607988);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, 183752147, 0.9771588087793465d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, 1571656859, 0.5010015798730909d, null, 802802415);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 971293152, 0.8433978803108917d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 216646974, 0.5360468652262764d, 0.8272010883020706d, 1505779201);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1664766129, 0.3580949670878283d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1788725592, 0.4157620097486623d, 0.5734283053286735d, 1404770691);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 324459071, 0.30625973759375036d, 0.4144228242585659d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 415005109, 0.008162497918298928d, 0.35391320047379804d, 336021829);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 730254982, 0.9083045786662239d, 0.23755362664327084d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 57307211, 0.4778544083934356d, null, 1289204788);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 135612994, 0.7034990163023861d, 0.3503010506351585d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1137148455, 0.7103807251446497d, 0.912324742232248d, 1968331481);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 868714145, 0.7676888107430296d, 0.4952797159028264d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1392515166, 0.2012780310687018d, 0.4946860875754363d, 108219923);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1665620303, 0.7269298841875813d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 2115924053, 0.919708771550856d, 0.947407173738365d, 655364919);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 268275921, 0.5276988241595651d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 416609607, 0.20842347910019332d, null, 1059011131);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1855761773, 0.9149941384972002d, 0.7355778837901124d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 2000175198, 0.035253343312442564d, 0.8599958937642391d, 2043499748);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 578081433, 0.7702372627925367d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1349073585, 0.21947985533358083d, 0.34681853370505633d, 1630089674);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 475348491, 0.9774702857366088d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 1159237477, 0.7023432198623896d, 0.6769528331679657d, 950197361);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 51524867, 0.5321864563252747d, 0.682225844775015d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, 2078835352, 0.6531386734428934d, null, 570192508);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(Doubledouble0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
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
                var models =  ((IDoubleSingleTypedouble)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(51524867));
                Assert.That(model.Value, Is.EqualTo(0.5321864563252747d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.682225844775015d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57307211));
                Assert.That(model.Value, Is.EqualTo(0.4778544083934356d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1289204788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4435564014278265d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135612994));
                Assert.That(model.Value, Is.EqualTo(0.7034990163023861d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3503010506351585d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(183752147));
                Assert.That(model.Value, Is.EqualTo(0.9771588087793465d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216646974));
                Assert.That(model.Value, Is.EqualTo(0.5360468652262764d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8272010883020706d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505779201));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7898132891845059d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8636196704801606d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268275921));
                Assert.That(model.Value, Is.EqualTo(0.5276988241595651d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(51524867));
                Assert.That(model.Value, Is.EqualTo(0.5321864563252747d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.682225844775015d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57307211));
                Assert.That(model.Value, Is.EqualTo(0.4778544083934356d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1289204788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4435564014278265d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135612994));
                Assert.That(model.Value, Is.EqualTo(0.7034990163023861d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3503010506351585d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(183752147));
                Assert.That(model.Value, Is.EqualTo(0.9771588087793465d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216646974));
                Assert.That(model.Value, Is.EqualTo(0.5360468652262764d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8272010883020706d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505779201));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7898132891845059d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8636196704801606d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268275921));
                Assert.That(model.Value, Is.EqualTo(0.5276988241595651d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Doubledouble0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
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
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(51524867));
                Assert.That(model.Value, Is.EqualTo(0.5321864563252747d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.682225844775015d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57307211));
                Assert.That(model.Value, Is.EqualTo(0.4778544083934356d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1289204788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4435564014278265d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135612994));
                Assert.That(model.Value, Is.EqualTo(0.7034990163023861d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3503010506351585d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(183752147));
                Assert.That(model.Value, Is.EqualTo(0.9771588087793465d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216646974));
                Assert.That(model.Value, Is.EqualTo(0.5360468652262764d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8272010883020706d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505779201));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7898132891845059d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8636196704801606d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268275921));
                Assert.That(model.Value, Is.EqualTo(0.5276988241595651d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(51524867));
                Assert.That(model.Value, Is.EqualTo(0.5321864563252747d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.682225844775015d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57307211));
                Assert.That(model.Value, Is.EqualTo(0.4778544083934356d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1289204788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4435564014278265d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135612994));
                Assert.That(model.Value, Is.EqualTo(0.7034990163023861d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3503010506351585d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(183752147));
                Assert.That(model.Value, Is.EqualTo(0.9771588087793465d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216646974));
                Assert.That(model.Value, Is.EqualTo(0.5360468652262764d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8272010883020706d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505779201));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7898132891845059d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8636196704801606d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268275921));
                Assert.That(model.Value, Is.EqualTo(0.5276988241595651d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 1788725592);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 1134150859);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(12));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
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
                 foreach(var batchResult in ((IDoubleSingleTypedouble)this).DbConnectionSelectModelBatch(connection, 268275921, 51524867))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(29));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57307211));
                Assert.That(model.Value, Is.EqualTo(0.4778544083934356d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1289204788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4435564014278265d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135612994));
                Assert.That(model.Value, Is.EqualTo(0.7034990163023861d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3503010506351585d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(183752147));
                Assert.That(model.Value, Is.EqualTo(0.9771588087793465d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216646974));
                Assert.That(model.Value, Is.EqualTo(0.5360468652262764d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8272010883020706d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1505779201));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7898132891845059d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8636196704801606d));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(268275921));
                Assert.That(model.Value, Is.EqualTo(0.5276988241595651d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(324459071));
                Assert.That(model.Value, Is.EqualTo(0.30625973759375036d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4144228242585659d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(415005109));
                Assert.That(model.Value, Is.EqualTo(0.008162497918298928d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.35391320047379804d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(336021829));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20145948616671006d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.05903142605268341d));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(416609607));
                Assert.That(model.Value, Is.EqualTo(0.20842347910019332d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1059011131));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.13773672355443667d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475348491));
                Assert.That(model.Value, Is.EqualTo(0.9774702857366088d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575719214));
                Assert.That(model.Value, Is.EqualTo(0.5942702240115573d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9415929547650043d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(578081433));
                Assert.That(model.Value, Is.EqualTo(0.7702372627925367d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(649334183));
                Assert.That(model.Value, Is.EqualTo(0.36435716954265873d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(875115535));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.46374003479680503d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12415173764807541d));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(661621524));
                Assert.That(model.Value, Is.EqualTo(0.3748263241795934d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05808252842820083d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(730254982));
                Assert.That(model.Value, Is.EqualTo(0.9083045786662239d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23755362664327084d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868714145));
                Assert.That(model.Value, Is.EqualTo(0.7676888107430296d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4952797159028264d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971293152));
                Assert.That(model.Value, Is.EqualTo(0.8433978803108917d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134150859));
                Assert.That(model.Value, Is.EqualTo(0.29020336811869774d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720607988));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.7407298954460602d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137148455));
                Assert.That(model.Value, Is.EqualTo(0.7103807251446497d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.912324742232248d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1968331481));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1162204702688181d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1159237477));
                Assert.That(model.Value, Is.EqualTo(0.7023432198623896d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6769528331679657d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(950197361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4634175823546207d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.7246645315157461d));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1349073585));
                Assert.That(model.Value, Is.EqualTo(0.21947985533358083d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.34681853370505633d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1630089674));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9838473979206824d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6715380646005925d));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1392515166));
                Assert.That(model.Value, Is.EqualTo(0.2012780310687018d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.4946860875754363d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(108219923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3684865038698446d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                        model = models[28];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

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
                await foreach(var batchResult in ((IDoubleSingleTypedouble)this).DbConnectionSelectModelBatchAsync(connection, 1392515166, 1571656859))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1571656859));
                Assert.That(model.Value, Is.EqualTo(0.5010015798730909d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802802415));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22176422924096817d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8446053434841867d));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664766129));
                Assert.That(model.Value, Is.EqualTo(0.3580949670878283d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1665620303));
                Assert.That(model.Value, Is.EqualTo(0.7269298841875813d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788725592));
                Assert.That(model.Value, Is.EqualTo(0.4157620097486623d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5734283053286735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1404770691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6498321263207415d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9325063585873464d));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855761773));
                Assert.That(model.Value, Is.EqualTo(0.9149941384972002d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7355778837901124d));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000175198));
                Assert.That(model.Value, Is.EqualTo(0.035253343312442564d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8599958937642391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043499748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8209479880357768d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2078835352));
                Assert.That(model.Value, Is.EqualTo(0.6531386734428934d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(570192508));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8038422630883658d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5115669104551862d));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115924053));
                Assert.That(model.Value, Is.EqualTo(0.919708771550856d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.947407173738365d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(655364919));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.3135657215682135d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.19952741120915363d));

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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble)
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
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51524867)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5321864563252747d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.682225844775015d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57307211)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4778544083934356d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1289204788)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4435564014278265d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135612994)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7034990163023861d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3503010506351585d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183752147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9771588087793465d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((216646974)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5360468652262764d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1505779201)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7898132891845059d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8636196704801606d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8272010883020706d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((268275921)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5276988241595651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((324459071)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30625973759375036d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4144228242585659d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((415005109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008162497918298928d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((336021829)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20145948616671006d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.05903142605268341d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35391320047379804d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((416609607)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20842347910019332d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1059011131)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13773672355443667d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((475348491)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9774702857366088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((575719214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5942702240115573d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9415929547650043d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((578081433)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7702372627925367d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((649334183)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36435716954265873d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((875115535)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46374003479680503d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.12415173764807541d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661621524)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3748263241795934d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.05808252842820083d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((730254982)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9083045786662239d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23755362664327084d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868714145)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7676888107430296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4952797159028264d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((971293152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8433978803108917d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1134150859)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29020336811869774d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1720607988)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7407298954460602d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1137148455)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7103807251446497d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1968331481)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1162204702688181d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.912324742232248d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1159237477)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7023432198623896d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((950197361)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4634175823546207d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7246645315157461d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6769528331679657d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1349073585)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21947985533358083d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1630089674)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9838473979206824d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6715380646005925d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34681853370505633d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1392515166)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2012780310687018d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108219923)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3684865038698446d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4946860875754363d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1571656859)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5010015798730909d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802802415)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.22176422924096817d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8446053434841867d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1664766129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3580949670878283d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1665620303)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7269298841875813d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788725592)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4157620097486623d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1404770691)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6498321263207415d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9325063585873464d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5734283053286735d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1855761773)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9149941384972002d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7355778837901124d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000175198)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.035253343312442564d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2043499748)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8209479880357768d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8599958937642391d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2078835352)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6531386734428934d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((570192508)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8038422630883658d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5115669104551862d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2115924053)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.919708771550856d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((655364919)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3135657215682135d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.19952741120915363d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.947407173738365d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51524867)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5321864563252747d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.682225844775015d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57307211)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4778544083934356d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1289204788)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4435564014278265d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135612994)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7034990163023861d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3503010506351585d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183752147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9771588087793465d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((216646974)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5360468652262764d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1505779201)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7898132891845059d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8636196704801606d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8272010883020706d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((268275921)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5276988241595651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((324459071)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30625973759375036d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4144228242585659d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((415005109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008162497918298928d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((336021829)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20145948616671006d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.05903142605268341d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35391320047379804d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((416609607)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20842347910019332d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1059011131)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13773672355443667d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((475348491)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9774702857366088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((575719214)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5942702240115573d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9415929547650043d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((578081433)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7702372627925367d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((649334183)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36435716954265873d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((875115535)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46374003479680503d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.12415173764807541d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((661621524)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3748263241795934d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.05808252842820083d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((730254982)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9083045786662239d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23755362664327084d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868714145)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7676888107430296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4952797159028264d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((971293152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8433978803108917d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1134150859)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29020336811869774d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1720607988)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7407298954460602d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1137148455)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7103807251446497d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1968331481)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1162204702688181d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.912324742232248d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1159237477)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7023432198623896d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((950197361)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4634175823546207d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7246645315157461d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6769528331679657d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1349073585)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21947985533358083d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1630089674)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9838473979206824d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6715380646005925d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34681853370505633d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1392515166)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2012780310687018d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108219923)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3684865038698446d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4946860875754363d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1571656859)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5010015798730909d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802802415)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.22176422924096817d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8446053434841867d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1664766129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3580949670878283d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1665620303)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7269298841875813d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788725592)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4157620097486623d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1404770691)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6498321263207415d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9325063585873464d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5734283053286735d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1855761773)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9149941384972002d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7355778837901124d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000175198)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.035253343312442564d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2043499748)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8209479880357768d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8599958937642391d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2078835352)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6531386734428934d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((570192508)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8038422630883658d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5115669104551862d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2115924053)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.919708771550856d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((655364919)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3135657215682135d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.19952741120915363d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.947407173738365d)));

            }
        }

        #endregion

    }
}

