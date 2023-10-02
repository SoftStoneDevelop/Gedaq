

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
    internal partial interface IInt32SingleTypeint
    {
    }
    
    internal partial class Int32SingleTypeint : IInt32SingleTypeint
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(8)
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, 528365421, 1001952778, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, 1923887643, 895870149, 606582499);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, 1093793205, 1615852770, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, 2120974734, 1412052697, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0mi(
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
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11, 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertInnerModel(connection, 1056934129, 1820203031, 1210254851);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1095993437, 850799989, 397690334);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 128128677, 1746365889, 1684463581);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 2145603567, 2046474719, 111336570);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 344387024, 162948954, 472313959);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1843059319, 303329416, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1522582338, 1886033828, 938161459);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 39148368, 406299239, 1794518847);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 899709763, 437302882, 474062113);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1084710106, 1348222900, 1210586594);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 491544648, 476255640, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0m(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(8),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, 1784791024, 685970645, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, 461541553, 210477631, 516949507, 528365421);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, 1702871229, 1690877193, 79510395, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, 1301540960, 759343702, null, 1923887643);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, 1672290702, 118750220, 876824954, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, 1143359459, 1575020269, null, 1093793205);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1619858597, 1514928504, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1734026525, 2019469384, 1678745433, 2120974734);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1393713747, 1864523988, 1269010504, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 532891168, 889915817, 691134173, 1056934129);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1582270449, 1788711, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1654573957, 751317837, 580959644, 1095993437);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 628216069, 1643531985, 1138288263, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1277476483, 1401252450, 2043426409, 128128677);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 181154214, 455700035, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 10020676, 1056474805, 949321440, 2145603567);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 836769263, 412059939, 20778541, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1783181163, 650581688, null, 344387024);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 876508919, 1393732429, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 53870867, 1623543398, null, 1843059319);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 2134278100, 2018773688, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 377909100, 1594366789, 784285077, 1522582338);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1539577710, 92023632, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1752778109, 1101088935, null, 39148368);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 879201689, 1192680882, 60077674, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1196731340, 222322194, 1075494376, 899709763);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 545149062, 1437312441, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 263701950, 1949468923, 1259131403, 1084710106);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1615419694, 1318223175, 267523720, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 738504585, 1757302529, 1501163065, 491544648);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int32int0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
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
                var models =  ((IInt32SingleTypeint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10020676));
                Assert.That(model.Value, Is.EqualTo(1056474805));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(949321440));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2145603567));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2046474719));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(111336570));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53870867));
                Assert.That(model.Value, Is.EqualTo(1623543398));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843059319));

                Assert.That(model.ModelInner.Value, Is.EqualTo(303329416));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(181154214));
                Assert.That(model.Value, Is.EqualTo(455700035));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263701950));
                Assert.That(model.Value, Is.EqualTo(1949468923));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1259131403));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084710106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1348222900));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210586594));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(377909100));
                Assert.That(model.Value, Is.EqualTo(1594366789));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(784285077));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522582338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1886033828));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(938161459));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(461541553));
                Assert.That(model.Value, Is.EqualTo(210477631));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(516949507));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(528365421));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1001952778));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(532891168));
                Assert.That(model.Value, Is.EqualTo(889915817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(691134173));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056934129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1820203031));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210254851));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(545149062));
                Assert.That(model.Value, Is.EqualTo(1437312441));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(628216069));
                Assert.That(model.Value, Is.EqualTo(1643531985));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1138288263));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738504585));
                Assert.That(model.Value, Is.EqualTo(1757302529));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1501163065));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491544648));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476255640));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836769263));
                Assert.That(model.Value, Is.EqualTo(412059939));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(20778541));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876508919));
                Assert.That(model.Value, Is.EqualTo(1393732429));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879201689));
                Assert.That(model.Value, Is.EqualTo(1192680882));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(60077674));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143359459));
                Assert.That(model.Value, Is.EqualTo(1575020269));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1093793205));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1615852770));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196731340));
                Assert.That(model.Value, Is.EqualTo(222322194));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1075494376));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(899709763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(437302882));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(474062113));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277476483));
                Assert.That(model.Value, Is.EqualTo(1401252450));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2043426409));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(128128677));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1746365889));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1684463581));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301540960));
                Assert.That(model.Value, Is.EqualTo(759343702));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923887643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(895870149));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(606582499));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1393713747));
                Assert.That(model.Value, Is.EqualTo(1864523988));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1269010504));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1539577710));
                Assert.That(model.Value, Is.EqualTo(92023632));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1582270449));
                Assert.That(model.Value, Is.EqualTo(1788711));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(10020676));
                Assert.That(model.Value, Is.EqualTo(1056474805));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(949321440));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2145603567));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2046474719));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(111336570));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53870867));
                Assert.That(model.Value, Is.EqualTo(1623543398));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843059319));

                Assert.That(model.ModelInner.Value, Is.EqualTo(303329416));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(181154214));
                Assert.That(model.Value, Is.EqualTo(455700035));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263701950));
                Assert.That(model.Value, Is.EqualTo(1949468923));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1259131403));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084710106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1348222900));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210586594));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(377909100));
                Assert.That(model.Value, Is.EqualTo(1594366789));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(784285077));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522582338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1886033828));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(938161459));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(461541553));
                Assert.That(model.Value, Is.EqualTo(210477631));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(516949507));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(528365421));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1001952778));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(532891168));
                Assert.That(model.Value, Is.EqualTo(889915817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(691134173));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056934129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1820203031));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210254851));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(545149062));
                Assert.That(model.Value, Is.EqualTo(1437312441));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(628216069));
                Assert.That(model.Value, Is.EqualTo(1643531985));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1138288263));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738504585));
                Assert.That(model.Value, Is.EqualTo(1757302529));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1501163065));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491544648));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476255640));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836769263));
                Assert.That(model.Value, Is.EqualTo(412059939));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(20778541));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876508919));
                Assert.That(model.Value, Is.EqualTo(1393732429));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879201689));
                Assert.That(model.Value, Is.EqualTo(1192680882));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(60077674));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143359459));
                Assert.That(model.Value, Is.EqualTo(1575020269));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1093793205));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1615852770));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196731340));
                Assert.That(model.Value, Is.EqualTo(222322194));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1075494376));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(899709763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(437302882));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(474062113));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277476483));
                Assert.That(model.Value, Is.EqualTo(1401252450));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2043426409));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(128128677));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1746365889));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1684463581));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301540960));
                Assert.That(model.Value, Is.EqualTo(759343702));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923887643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(895870149));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(606582499));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1393713747));
                Assert.That(model.Value, Is.EqualTo(1864523988));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1269010504));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1539577710));
                Assert.That(model.Value, Is.EqualTo(92023632));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1582270449));
                Assert.That(model.Value, Is.EqualTo(1788711));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10020676));
                Assert.That(model.Value, Is.EqualTo(1056474805));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(949321440));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2145603567));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2046474719));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(111336570));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53870867));
                Assert.That(model.Value, Is.EqualTo(1623543398));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843059319));

                Assert.That(model.ModelInner.Value, Is.EqualTo(303329416));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(181154214));
                Assert.That(model.Value, Is.EqualTo(455700035));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263701950));
                Assert.That(model.Value, Is.EqualTo(1949468923));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1259131403));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084710106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1348222900));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210586594));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(377909100));
                Assert.That(model.Value, Is.EqualTo(1594366789));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(784285077));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522582338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1886033828));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(938161459));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(461541553));
                Assert.That(model.Value, Is.EqualTo(210477631));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(516949507));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(528365421));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1001952778));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(532891168));
                Assert.That(model.Value, Is.EqualTo(889915817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(691134173));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056934129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1820203031));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210254851));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(545149062));
                Assert.That(model.Value, Is.EqualTo(1437312441));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(628216069));
                Assert.That(model.Value, Is.EqualTo(1643531985));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1138288263));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738504585));
                Assert.That(model.Value, Is.EqualTo(1757302529));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1501163065));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491544648));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476255640));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836769263));
                Assert.That(model.Value, Is.EqualTo(412059939));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(20778541));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876508919));
                Assert.That(model.Value, Is.EqualTo(1393732429));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879201689));
                Assert.That(model.Value, Is.EqualTo(1192680882));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(60077674));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143359459));
                Assert.That(model.Value, Is.EqualTo(1575020269));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1093793205));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1615852770));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196731340));
                Assert.That(model.Value, Is.EqualTo(222322194));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1075494376));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(899709763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(437302882));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(474062113));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277476483));
                Assert.That(model.Value, Is.EqualTo(1401252450));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2043426409));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(128128677));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1746365889));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1684463581));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301540960));
                Assert.That(model.Value, Is.EqualTo(759343702));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923887643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(895870149));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(606582499));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1393713747));
                Assert.That(model.Value, Is.EqualTo(1864523988));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1269010504));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1539577710));
                Assert.That(model.Value, Is.EqualTo(92023632));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1582270449));
                Assert.That(model.Value, Is.EqualTo(1788711));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(10020676));
                Assert.That(model.Value, Is.EqualTo(1056474805));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(949321440));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2145603567));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2046474719));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(111336570));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53870867));
                Assert.That(model.Value, Is.EqualTo(1623543398));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843059319));

                Assert.That(model.ModelInner.Value, Is.EqualTo(303329416));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(181154214));
                Assert.That(model.Value, Is.EqualTo(455700035));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263701950));
                Assert.That(model.Value, Is.EqualTo(1949468923));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1259131403));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1084710106));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1348222900));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210586594));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(377909100));
                Assert.That(model.Value, Is.EqualTo(1594366789));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(784285077));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1522582338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1886033828));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(938161459));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(461541553));
                Assert.That(model.Value, Is.EqualTo(210477631));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(516949507));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(528365421));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1001952778));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(532891168));
                Assert.That(model.Value, Is.EqualTo(889915817));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(691134173));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056934129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1820203031));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1210254851));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(545149062));
                Assert.That(model.Value, Is.EqualTo(1437312441));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(628216069));
                Assert.That(model.Value, Is.EqualTo(1643531985));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1138288263));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738504585));
                Assert.That(model.Value, Is.EqualTo(1757302529));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1501163065));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(491544648));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476255640));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836769263));
                Assert.That(model.Value, Is.EqualTo(412059939));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(20778541));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(876508919));
                Assert.That(model.Value, Is.EqualTo(1393732429));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(879201689));
                Assert.That(model.Value, Is.EqualTo(1192680882));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(60077674));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143359459));
                Assert.That(model.Value, Is.EqualTo(1575020269));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1093793205));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1615852770));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196731340));
                Assert.That(model.Value, Is.EqualTo(222322194));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1075494376));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(899709763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(437302882));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(474062113));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277476483));
                Assert.That(model.Value, Is.EqualTo(1401252450));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2043426409));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(128128677));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1746365889));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1684463581));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301540960));
                Assert.That(model.Value, Is.EqualTo(759343702));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923887643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(895870149));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(606582499));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1393713747));
                Assert.That(model.Value, Is.EqualTo(1864523988));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1269010504));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1539577710));
                Assert.That(model.Value, Is.EqualTo(92023632));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1582270449));
                Assert.That(model.Value, Is.EqualTo(1788711));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 1582270449);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 1143359459);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196731340));
                Assert.That(model.Value, Is.EqualTo(222322194));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1075494376));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(899709763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(437302882));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(474062113));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1277476483));
                Assert.That(model.Value, Is.EqualTo(1401252450));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2043426409));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(128128677));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1746365889));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1684463581));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301540960));
                Assert.That(model.Value, Is.EqualTo(759343702));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923887643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(895870149));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(606582499));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1393713747));
                Assert.That(model.Value, Is.EqualTo(1864523988));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1269010504));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1539577710));
                Assert.That(model.Value, Is.EqualTo(92023632));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1582270449));
                Assert.That(model.Value, Is.EqualTo(1788711));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615419694));
                Assert.That(model.Value, Is.EqualTo(1318223175));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(267523720));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1619858597));
                Assert.That(model.Value, Is.EqualTo(1514928504));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1654573957));
                Assert.That(model.Value, Is.EqualTo(751317837));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(580959644));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1095993437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(850799989));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(397690334));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1672290702));
                Assert.That(model.Value, Is.EqualTo(118750220));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(876824954));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1702871229));
                Assert.That(model.Value, Is.EqualTo(1690877193));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(79510395));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1734026525));
                Assert.That(model.Value, Is.EqualTo(2019469384));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1678745433));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2120974734));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1412052697));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752778109));
                Assert.That(model.Value, Is.EqualTo(1101088935));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(39148368));

                Assert.That(model.ModelInner.Value, Is.EqualTo(406299239));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1794518847));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783181163));
                Assert.That(model.Value, Is.EqualTo(650581688));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(344387024));

                Assert.That(model.ModelInner.Value, Is.EqualTo(162948954));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(472313959));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784791024));
                Assert.That(model.Value, Is.EqualTo(685970645));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2134278100));
                Assert.That(model.Value, Is.EqualTo(2018773688));

                Assert.That(model.NullableValue, Is.Null);

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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((10020676)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1056474805)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2145603567)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2046474719)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((111336570)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((949321440)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53870867)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1623543398)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1843059319)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((303329416)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181154214)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((455700035)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((263701950)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1949468923)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1084710106)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1348222900)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1210586594)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1259131403)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((377909100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1594366789)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1522582338)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1886033828)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((938161459)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((784285077)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((461541553)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((210477631)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((528365421)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1001952778)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((516949507)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((532891168)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((889915817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1056934129)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1820203031)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1210254851)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((691134173)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((545149062)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1437312441)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((628216069)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1643531985)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1138288263)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((738504585)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1757302529)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((491544648)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((476255640)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1501163065)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((836769263)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((412059939)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((20778541)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((876508919)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1393732429)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((879201689)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1192680882)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((60077674)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1143359459)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1575020269)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1093793205)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1615852770)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1196731340)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((222322194)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((899709763)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((437302882)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((474062113)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1075494376)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1277476483)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1401252450)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((128128677)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1746365889)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1684463581)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2043426409)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1301540960)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((759343702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1923887643)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((895870149)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((606582499)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1393713747)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1864523988)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1269010504)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1539577710)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((92023632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1582270449)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1788711)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1615419694)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1318223175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((267523720)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1619858597)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1514928504)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1654573957)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((751317837)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1095993437)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((850799989)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((397690334)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((580959644)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1672290702)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118750220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((876824954)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1702871229)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1690877193)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((79510395)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1734026525)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019469384)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2120974734)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1412052697)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1678745433)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1752778109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1101088935)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39148368)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((406299239)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1794518847)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1783181163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((650581688)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((344387024)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((162948954)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((472313959)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1784791024)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((685970645)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2134278100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2018773688)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((10020676)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1056474805)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2145603567)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2046474719)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((111336570)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((949321440)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53870867)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1623543398)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1843059319)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((303329416)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181154214)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((455700035)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((263701950)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1949468923)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1084710106)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1348222900)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1210586594)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1259131403)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((377909100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1594366789)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1522582338)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1886033828)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((938161459)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((784285077)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((461541553)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((210477631)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((528365421)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1001952778)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((516949507)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((532891168)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((889915817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1056934129)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1820203031)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1210254851)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((691134173)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((545149062)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1437312441)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((628216069)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1643531985)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1138288263)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((738504585)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1757302529)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((491544648)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((476255640)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1501163065)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((836769263)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((412059939)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((20778541)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((876508919)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1393732429)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((879201689)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1192680882)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((60077674)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1143359459)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1575020269)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1093793205)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1615852770)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1196731340)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((222322194)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((899709763)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((437302882)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((474062113)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1075494376)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1277476483)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1401252450)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((128128677)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1746365889)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1684463581)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2043426409)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1301540960)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((759343702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1923887643)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((895870149)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((606582499)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1393713747)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1864523988)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1269010504)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1539577710)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((92023632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1582270449)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1788711)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1615419694)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1318223175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((267523720)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1619858597)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1514928504)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1654573957)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((751317837)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1095993437)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((850799989)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((397690334)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((580959644)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1672290702)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118750220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((876824954)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1702871229)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1690877193)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((79510395)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1734026525)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019469384)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2120974734)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1412052697)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1678745433)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1752778109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1101088935)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39148368)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((406299239)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1794518847)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1783181163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((650581688)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((344387024)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((162948954)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((472313959)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1784791024)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((685970645)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2134278100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2018773688)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

