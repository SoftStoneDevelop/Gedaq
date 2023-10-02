

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


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(5)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(5)
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, 1677599354, 0.375727933030546m, 0.578730937792728m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, 481929632, 0.936456150183642m, null);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, 1728506043, 0.487229336939722m, 0.0680454165998927m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, 882839893, 0.60014324217105m, 0.741165388794828m);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)7
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)7, 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModel(connection, 193349678, 0.033427936134519m, null);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 104167916, 0.430619108257737m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 1442508542, 0.558692258816696m, 0.564682722025172m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 544406002, 0.341662246015403m, 0.462804890611494m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 1096697500, 0.22203449969515m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 1411910212, 0.752914014950444m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 582394354, 0.05406796828668m, 0.416004517903948m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 721640356, 0.88905825231492m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 811687346, 0.455675992814354m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 1952374668, 0.21773316569093m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, 1458587442, 0.295838785111593m, 0.129717584393936m);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(5)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(5),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, 1398632854, 0.329046306580947m, 0.366620831920259m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, 1764271012, 0.67059171029939m, null, 1677599354);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, 886903091, 0.330414579939744m, 0.0798988592177203m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, 847303358, 0.126802636963592m, 0.577905845697298m, 481929632);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, 934408152, 0.893928405421374m, 0.0984042910052485m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, 1857019812, 0.0934033552617477m, null, 1728506043);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 280277000, 0.0155767002671469m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 737724835, 0.462174795004836m, null, 882839893);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 800415807, 0.736544688794119m, 0.908446685161742m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 891886263, 0.593682245686233m, null, 193349678);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 2124452977, 0.451687891648145m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 351697530, 0.304892042007705m, null, 104167916);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 950579332, 0.429995270716554m, 0.166132003731149m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 755501386, 0.419754914642617m, null, 1442508542);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 890635959, 0.255722423372818m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 588161419, 0.412829805255425m, 0.874999840431389m, 544406002);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 1475500219, 0.567817133902473m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 333585236, 0.40063720536759m, null, 1096697500);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 931630922, 0.0439332176211609m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 955924009, 0.837720970869507m, 0.920723278753016m, 1411910212);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 1352348441, 0.375606113174609m, 0.834653995300679m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 961961667, 0.786708941000693m, 0.0935068933373542m, 582394354);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 622348600, 0.424102995714845m, 0.52714963448875m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 391587438, 0.499712623693798m, 0.764674436024649m, 721640356);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 821865216, 0.219200810350644m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 1903423215, 0.884538895771972m, 0.698781859808498m, 811687346);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 929008702, 0.562337396640195m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 1973309875, 0.816891928223176m, null, 1952374668);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 1824746977, 0.550030520676854m, 0.899650510635594m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, 963118048, 0.305792930517032m, 0.456016254108981m, 1458587442);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Decimaldecimal0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)
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
                var models =  ((IDecimalSingleTypedecimal)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(280277000));
                Assert.That(model.Value, Is.EqualTo(0.0155767002671469m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333585236));
                Assert.That(model.Value, Is.EqualTo(0.40063720536759m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1096697500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22203449969515m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(351697530));
                Assert.That(model.Value, Is.EqualTo(0.304892042007705m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(104167916));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.430619108257737m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(391587438));
                Assert.That(model.Value, Is.EqualTo(0.499712623693798m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.764674436024649m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721640356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.88905825231492m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588161419));
                Assert.That(model.Value, Is.EqualTo(0.412829805255425m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.874999840431389m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(544406002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.341662246015403m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.462804890611494m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622348600));
                Assert.That(model.Value, Is.EqualTo(0.424102995714845m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.52714963448875m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(737724835));
                Assert.That(model.Value, Is.EqualTo(0.462174795004836m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(882839893));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.60014324217105m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.741165388794828m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755501386));
                Assert.That(model.Value, Is.EqualTo(0.419754914642617m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1442508542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.558692258816696m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.564682722025172m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(800415807));
                Assert.That(model.Value, Is.EqualTo(0.736544688794119m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.908446685161742m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821865216));
                Assert.That(model.Value, Is.EqualTo(0.219200810350644m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847303358));
                Assert.That(model.Value, Is.EqualTo(0.126802636963592m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.577905845697298m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(481929632));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.936456150183642m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886903091));
                Assert.That(model.Value, Is.EqualTo(0.330414579939744m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0798988592177203m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890635959));
                Assert.That(model.Value, Is.EqualTo(0.255722423372818m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(891886263));
                Assert.That(model.Value, Is.EqualTo(0.593682245686233m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193349678));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.033427936134519m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929008702));
                Assert.That(model.Value, Is.EqualTo(0.562337396640195m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931630922));
                Assert.That(model.Value, Is.EqualTo(0.0439332176211609m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(934408152));
                Assert.That(model.Value, Is.EqualTo(0.893928405421374m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0984042910052485m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950579332));
                Assert.That(model.Value, Is.EqualTo(0.429995270716554m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.166132003731149m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(955924009));
                Assert.That(model.Value, Is.EqualTo(0.837720970869507m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.920723278753016m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1411910212));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.752914014950444m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961961667));
                Assert.That(model.Value, Is.EqualTo(0.786708941000693m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0935068933373542m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(582394354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05406796828668m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.416004517903948m));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(963118048));
                Assert.That(model.Value, Is.EqualTo(0.305792930517032m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.456016254108981m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458587442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.295838785111593m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.129717584393936m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352348441));
                Assert.That(model.Value, Is.EqualTo(0.375606113174609m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.834653995300679m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1398632854));
                Assert.That(model.Value, Is.EqualTo(0.329046306580947m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.366620831920259m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475500219));
                Assert.That(model.Value, Is.EqualTo(0.567817133902473m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764271012));
                Assert.That(model.Value, Is.EqualTo(0.67059171029939m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1677599354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.375727933030546m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.578730937792728m));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1824746977));
                Assert.That(model.Value, Is.EqualTo(0.550030520676854m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.899650510635594m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1857019812));
                Assert.That(model.Value, Is.EqualTo(0.0934033552617477m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728506043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.487229336939722m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0680454165998927m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903423215));
                Assert.That(model.Value, Is.EqualTo(0.884538895771972m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.698781859808498m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811687346));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.455675992814354m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
                var models = await ((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(280277000));
                Assert.That(model.Value, Is.EqualTo(0.0155767002671469m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333585236));
                Assert.That(model.Value, Is.EqualTo(0.40063720536759m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1096697500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22203449969515m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(351697530));
                Assert.That(model.Value, Is.EqualTo(0.304892042007705m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(104167916));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.430619108257737m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(391587438));
                Assert.That(model.Value, Is.EqualTo(0.499712623693798m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.764674436024649m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721640356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.88905825231492m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588161419));
                Assert.That(model.Value, Is.EqualTo(0.412829805255425m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.874999840431389m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(544406002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.341662246015403m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.462804890611494m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622348600));
                Assert.That(model.Value, Is.EqualTo(0.424102995714845m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.52714963448875m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(737724835));
                Assert.That(model.Value, Is.EqualTo(0.462174795004836m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(882839893));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.60014324217105m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.741165388794828m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755501386));
                Assert.That(model.Value, Is.EqualTo(0.419754914642617m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1442508542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.558692258816696m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.564682722025172m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(800415807));
                Assert.That(model.Value, Is.EqualTo(0.736544688794119m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.908446685161742m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821865216));
                Assert.That(model.Value, Is.EqualTo(0.219200810350644m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847303358));
                Assert.That(model.Value, Is.EqualTo(0.126802636963592m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.577905845697298m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(481929632));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.936456150183642m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886903091));
                Assert.That(model.Value, Is.EqualTo(0.330414579939744m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0798988592177203m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890635959));
                Assert.That(model.Value, Is.EqualTo(0.255722423372818m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(891886263));
                Assert.That(model.Value, Is.EqualTo(0.593682245686233m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193349678));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.033427936134519m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929008702));
                Assert.That(model.Value, Is.EqualTo(0.562337396640195m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931630922));
                Assert.That(model.Value, Is.EqualTo(0.0439332176211609m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(934408152));
                Assert.That(model.Value, Is.EqualTo(0.893928405421374m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0984042910052485m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950579332));
                Assert.That(model.Value, Is.EqualTo(0.429995270716554m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.166132003731149m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(955924009));
                Assert.That(model.Value, Is.EqualTo(0.837720970869507m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.920723278753016m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1411910212));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.752914014950444m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961961667));
                Assert.That(model.Value, Is.EqualTo(0.786708941000693m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0935068933373542m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(582394354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05406796828668m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.416004517903948m));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(963118048));
                Assert.That(model.Value, Is.EqualTo(0.305792930517032m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.456016254108981m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458587442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.295838785111593m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.129717584393936m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352348441));
                Assert.That(model.Value, Is.EqualTo(0.375606113174609m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.834653995300679m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1398632854));
                Assert.That(model.Value, Is.EqualTo(0.329046306580947m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.366620831920259m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475500219));
                Assert.That(model.Value, Is.EqualTo(0.567817133902473m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764271012));
                Assert.That(model.Value, Is.EqualTo(0.67059171029939m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1677599354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.375727933030546m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.578730937792728m));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1824746977));
                Assert.That(model.Value, Is.EqualTo(0.550030520676854m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.899650510635594m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1857019812));
                Assert.That(model.Value, Is.EqualTo(0.0934033552617477m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728506043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.487229336939722m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0680454165998927m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903423215));
                Assert.That(model.Value, Is.EqualTo(0.884538895771972m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.698781859808498m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811687346));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.455675992814354m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Decimaldecimal0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)
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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(280277000));
                Assert.That(model.Value, Is.EqualTo(0.0155767002671469m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333585236));
                Assert.That(model.Value, Is.EqualTo(0.40063720536759m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1096697500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22203449969515m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(351697530));
                Assert.That(model.Value, Is.EqualTo(0.304892042007705m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(104167916));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.430619108257737m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(391587438));
                Assert.That(model.Value, Is.EqualTo(0.499712623693798m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.764674436024649m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721640356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.88905825231492m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588161419));
                Assert.That(model.Value, Is.EqualTo(0.412829805255425m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.874999840431389m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(544406002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.341662246015403m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.462804890611494m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622348600));
                Assert.That(model.Value, Is.EqualTo(0.424102995714845m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.52714963448875m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(737724835));
                Assert.That(model.Value, Is.EqualTo(0.462174795004836m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(882839893));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.60014324217105m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.741165388794828m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755501386));
                Assert.That(model.Value, Is.EqualTo(0.419754914642617m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1442508542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.558692258816696m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.564682722025172m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(800415807));
                Assert.That(model.Value, Is.EqualTo(0.736544688794119m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.908446685161742m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821865216));
                Assert.That(model.Value, Is.EqualTo(0.219200810350644m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847303358));
                Assert.That(model.Value, Is.EqualTo(0.126802636963592m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.577905845697298m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(481929632));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.936456150183642m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886903091));
                Assert.That(model.Value, Is.EqualTo(0.330414579939744m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0798988592177203m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890635959));
                Assert.That(model.Value, Is.EqualTo(0.255722423372818m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(891886263));
                Assert.That(model.Value, Is.EqualTo(0.593682245686233m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193349678));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.033427936134519m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929008702));
                Assert.That(model.Value, Is.EqualTo(0.562337396640195m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931630922));
                Assert.That(model.Value, Is.EqualTo(0.0439332176211609m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(934408152));
                Assert.That(model.Value, Is.EqualTo(0.893928405421374m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0984042910052485m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950579332));
                Assert.That(model.Value, Is.EqualTo(0.429995270716554m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.166132003731149m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(955924009));
                Assert.That(model.Value, Is.EqualTo(0.837720970869507m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.920723278753016m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1411910212));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.752914014950444m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961961667));
                Assert.That(model.Value, Is.EqualTo(0.786708941000693m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0935068933373542m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(582394354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05406796828668m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.416004517903948m));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(963118048));
                Assert.That(model.Value, Is.EqualTo(0.305792930517032m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.456016254108981m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458587442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.295838785111593m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.129717584393936m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352348441));
                Assert.That(model.Value, Is.EqualTo(0.375606113174609m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.834653995300679m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1398632854));
                Assert.That(model.Value, Is.EqualTo(0.329046306580947m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.366620831920259m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475500219));
                Assert.That(model.Value, Is.EqualTo(0.567817133902473m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764271012));
                Assert.That(model.Value, Is.EqualTo(0.67059171029939m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1677599354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.375727933030546m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.578730937792728m));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1824746977));
                Assert.That(model.Value, Is.EqualTo(0.550030520676854m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.899650510635594m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1857019812));
                Assert.That(model.Value, Is.EqualTo(0.0934033552617477m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728506043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.487229336939722m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0680454165998927m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903423215));
                Assert.That(model.Value, Is.EqualTo(0.884538895771972m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.698781859808498m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811687346));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.455675992814354m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(280277000));
                Assert.That(model.Value, Is.EqualTo(0.0155767002671469m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333585236));
                Assert.That(model.Value, Is.EqualTo(0.40063720536759m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1096697500));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.22203449969515m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(351697530));
                Assert.That(model.Value, Is.EqualTo(0.304892042007705m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(104167916));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.430619108257737m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(391587438));
                Assert.That(model.Value, Is.EqualTo(0.499712623693798m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.764674436024649m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721640356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.88905825231492m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(588161419));
                Assert.That(model.Value, Is.EqualTo(0.412829805255425m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.874999840431389m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(544406002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.341662246015403m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.462804890611494m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622348600));
                Assert.That(model.Value, Is.EqualTo(0.424102995714845m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.52714963448875m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(737724835));
                Assert.That(model.Value, Is.EqualTo(0.462174795004836m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(882839893));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.60014324217105m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.741165388794828m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755501386));
                Assert.That(model.Value, Is.EqualTo(0.419754914642617m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1442508542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.558692258816696m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.564682722025172m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(800415807));
                Assert.That(model.Value, Is.EqualTo(0.736544688794119m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.908446685161742m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821865216));
                Assert.That(model.Value, Is.EqualTo(0.219200810350644m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(847303358));
                Assert.That(model.Value, Is.EqualTo(0.126802636963592m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.577905845697298m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(481929632));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.936456150183642m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886903091));
                Assert.That(model.Value, Is.EqualTo(0.330414579939744m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0798988592177203m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(890635959));
                Assert.That(model.Value, Is.EqualTo(0.255722423372818m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(891886263));
                Assert.That(model.Value, Is.EqualTo(0.593682245686233m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193349678));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.033427936134519m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(929008702));
                Assert.That(model.Value, Is.EqualTo(0.562337396640195m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(931630922));
                Assert.That(model.Value, Is.EqualTo(0.0439332176211609m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(934408152));
                Assert.That(model.Value, Is.EqualTo(0.893928405421374m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0984042910052485m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950579332));
                Assert.That(model.Value, Is.EqualTo(0.429995270716554m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.166132003731149m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(955924009));
                Assert.That(model.Value, Is.EqualTo(0.837720970869507m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.920723278753016m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1411910212));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.752914014950444m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961961667));
                Assert.That(model.Value, Is.EqualTo(0.786708941000693m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0935068933373542m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(582394354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05406796828668m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.416004517903948m));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(963118048));
                Assert.That(model.Value, Is.EqualTo(0.305792930517032m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.456016254108981m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458587442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.295838785111593m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.129717584393936m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352348441));
                Assert.That(model.Value, Is.EqualTo(0.375606113174609m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.834653995300679m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1398632854));
                Assert.That(model.Value, Is.EqualTo(0.329046306580947m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.366620831920259m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475500219));
                Assert.That(model.Value, Is.EqualTo(0.567817133902473m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764271012));
                Assert.That(model.Value, Is.EqualTo(0.67059171029939m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1677599354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.375727933030546m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.578730937792728m));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1824746977));
                Assert.That(model.Value, Is.EqualTo(0.550030520676854m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.899650510635594m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1857019812));
                Assert.That(model.Value, Is.EqualTo(0.0934033552617477m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728506043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.487229336939722m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0680454165998927m));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903423215));
                Assert.That(model.Value, Is.EqualTo(0.884538895771972m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.698781859808498m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811687346));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.455675992814354m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 934408152);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950579332));
                Assert.That(model.Value, Is.EqualTo(0.429995270716554m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.166132003731149m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(955924009));
                Assert.That(model.Value, Is.EqualTo(0.837720970869507m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.920723278753016m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1411910212));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.752914014950444m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961961667));
                Assert.That(model.Value, Is.EqualTo(0.786708941000693m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0935068933373542m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(582394354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.05406796828668m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.416004517903948m));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(963118048));
                Assert.That(model.Value, Is.EqualTo(0.305792930517032m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.456016254108981m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458587442));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.295838785111593m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.129717584393936m));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1352348441));
                Assert.That(model.Value, Is.EqualTo(0.375606113174609m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.834653995300679m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1398632854));
                Assert.That(model.Value, Is.EqualTo(0.329046306580947m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.366620831920259m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1475500219));
                Assert.That(model.Value, Is.EqualTo(0.567817133902473m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764271012));
                Assert.That(model.Value, Is.EqualTo(0.67059171029939m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1677599354));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.375727933030546m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.578730937792728m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1824746977));
                Assert.That(model.Value, Is.EqualTo(0.550030520676854m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.899650510635594m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1857019812));
                Assert.That(model.Value, Is.EqualTo(0.0934033552617477m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728506043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.487229336939722m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0680454165998927m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903423215));
                Assert.That(model.Value, Is.EqualTo(0.884538895771972m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.698781859808498m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811687346));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.455675992814354m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
                await using var cmd = await ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 1903423215);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1973309875));
                Assert.That(model.Value, Is.EqualTo(0.816891928223176m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1952374668));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.21773316569093m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124452977));
                Assert.That(model.Value, Is.EqualTo(0.451687891648145m));

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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)
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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((280277000)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0155767002671469m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((333585236)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.40063720536759m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1096697500)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.22203449969515m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((351697530)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.304892042007705m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((104167916)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.430619108257737m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((391587438)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499712623693798m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((721640356)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.88905825231492m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.764674436024649m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((588161419)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.412829805255425m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((544406002)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.341662246015403m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.462804890611494m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.874999840431389m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((622348600)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.424102995714845m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.52714963448875m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((737724835)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.462174795004836m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((882839893)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.60014324217105m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.741165388794828m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((755501386)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.419754914642617m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1442508542)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.558692258816696m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.564682722025172m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((800415807)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.736544688794119m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.908446685161742m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((821865216)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.219200810350644m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((847303358)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126802636963592m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((481929632)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.936456150183642m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.577905845697298m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((886903091)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.330414579939744m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0798988592177203m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((890635959)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.255722423372818m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((891886263)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.593682245686233m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((193349678)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.033427936134519m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((929008702)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.562337396640195m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((931630922)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0439332176211609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((934408152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.893928405421374m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0984042910052485m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950579332)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.429995270716554m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.166132003731149m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((955924009)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.837720970869507m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1411910212)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.752914014950444m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.920723278753016m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((961961667)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.786708941000693m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((582394354)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.05406796828668m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.416004517903948m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0935068933373542m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((963118048)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.305792930517032m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1458587442)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.295838785111593m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.129717584393936m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.456016254108981m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1352348441)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.375606113174609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.834653995300679m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1398632854)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.329046306580947m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366620831920259m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1475500219)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.567817133902473m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1764271012)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67059171029939m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1677599354)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.375727933030546m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.578730937792728m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1824746977)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.550030520676854m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.899650510635594m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1857019812)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0934033552617477m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1728506043)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.487229336939722m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0680454165998927m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1903423215)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.884538895771972m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((811687346)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.455675992814354m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.698781859808498m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1973309875)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.816891928223176m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1952374668)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21773316569093m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2124452977)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.451687891648145m)));//Value

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
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((280277000)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0155767002671469m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((333585236)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.40063720536759m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1096697500)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.22203449969515m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((351697530)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.304892042007705m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((104167916)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.430619108257737m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((391587438)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499712623693798m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((721640356)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.88905825231492m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.764674436024649m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((588161419)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.412829805255425m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((544406002)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.341662246015403m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.462804890611494m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.874999840431389m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((622348600)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.424102995714845m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.52714963448875m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((737724835)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.462174795004836m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((882839893)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.60014324217105m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.741165388794828m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((755501386)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.419754914642617m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1442508542)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.558692258816696m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.564682722025172m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((800415807)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.736544688794119m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.908446685161742m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((821865216)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.219200810350644m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((847303358)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126802636963592m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((481929632)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.936456150183642m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.577905845697298m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((886903091)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.330414579939744m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0798988592177203m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((890635959)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.255722423372818m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((891886263)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.593682245686233m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((193349678)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.033427936134519m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((929008702)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.562337396640195m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((931630922)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0439332176211609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((934408152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.893928405421374m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0984042910052485m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950579332)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.429995270716554m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.166132003731149m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((955924009)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.837720970869507m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1411910212)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.752914014950444m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.920723278753016m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((961961667)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.786708941000693m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((582394354)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.05406796828668m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.416004517903948m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0935068933373542m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((963118048)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.305792930517032m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1458587442)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.295838785111593m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.129717584393936m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.456016254108981m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1352348441)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.375606113174609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.834653995300679m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1398632854)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.329046306580947m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366620831920259m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1475500219)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.567817133902473m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1764271012)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67059171029939m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1677599354)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.375727933030546m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.578730937792728m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1824746977)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.550030520676854m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.899650510635594m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1857019812)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0934033552617477m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1728506043)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.487229336939722m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0680454165998927m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1903423215)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.884538895771972m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((811687346)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.455675992814354m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.698781859808498m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1973309875)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.816891928223176m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1952374668)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21773316569093m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2124452977)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.451687891648145m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

