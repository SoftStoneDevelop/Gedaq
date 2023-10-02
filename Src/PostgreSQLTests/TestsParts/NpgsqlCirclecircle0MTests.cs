

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                )
            ]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, 2139139506, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, 314633946, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d));
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, 2112719374, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, 346158728, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, 115206922, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d));
                Assert.That(id, Is.EqualTo(115206922));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, 821333355, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d), null);
                Assert.That(id, Is.EqualTo(821333355));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, 830308361, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d), null);
                Assert.That(id, Is.EqualTo(830308361));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, 1576175752, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d), null);
                Assert.That(id, Is.EqualTo(1576175752));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, 981659275, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d));
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 1933617278, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 238167427, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 186139499, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 278033435, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 1727377006, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, 579148996, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, 1780063442, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, 674372110, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d), null, 2139139506);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, 1436399809, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, 417217067, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d), null, 314633946);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;

                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, 5818289, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, 497631145, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d), 2112719374);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;

                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, 201994761, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, 1148749115, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d), null, 346158728);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;
                NpgsqlCirclecircle0M model = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, 1520909606, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, 1079256990, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d), 115206922).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, 1730168108, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, 1979461866, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d), 821333355).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;
                NpgsqlCirclecircle0M model = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, 596270113, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, 1859377359, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d), 830308361).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, 1562047005, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, 1599567655, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d), null, 1576175752).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, 1768320035, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, 659842744, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d), 981659275);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1948516315, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 558775498, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d), 1933617278);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 2101078573, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1751785866, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d), 238167427);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1719316354, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1047749956, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d), null, 186139499);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 382950350, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 553197799, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d), 278033435);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 502513670, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1859629259, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d), 1727377006);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 1542622281, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, 683741294, new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d), 579148996);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

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
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 1948516315);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 1859629259);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(3));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
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
                 foreach(var batchResult in ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelBatch(connection, 1599567655, 1148749115))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

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
                await foreach(var batchResult in ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelBatchAsync(connection, 502513670, 1859377359))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5818289)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((201994761)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382950350)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((417217067)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((314633946)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((497631145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2112719374)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502513670)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((553197799)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((278033435)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558775498)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1933617278)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((596270113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659842744)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((981659275)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((674372110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2139139506)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((683741294)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((579148996)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1047749956)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((186139499)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1079256990)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((115206922)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148749115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((346158728)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436399809)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1520909606)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1542622281)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1562047005)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1599567655)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1576175752)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1719316354)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1730168108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751785866)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((238167427)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1768320035)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1780063442)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859377359)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((830308361)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859629259)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1727377006)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948516315)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1979461866)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821333355)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2101078573)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d))));//Value

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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5818289)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((201994761)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382950350)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((417217067)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((314633946)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((497631145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2112719374)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502513670)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((553197799)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((278033435)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558775498)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1933617278)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((596270113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659842744)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((981659275)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((674372110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2139139506)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((683741294)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((579148996)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1047749956)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((186139499)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1079256990)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((115206922)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148749115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((346158728)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436399809)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1520909606)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1542622281)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1562047005)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1599567655)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1576175752)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1719316354)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1730168108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751785866)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((238167427)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1768320035)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1780063442)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859377359)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((830308361)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1859629259)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1727377006)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948516315)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1979461866)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821333355)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2101078573)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0MI>(7);

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 115206922,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 186139499,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 238167427,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 278033435,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 314633946,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 346158728,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 579148996,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(115206922));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(186139499));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(238167427));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(278033435));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314633946));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(346158728));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579148996));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 821333355,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 830308361,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 981659275,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 1576175752,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 1727377006,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 1933617278,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 2112719374,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)
                });

                importCollection.Add(
                new NpgsqlCirclecircle0MI
                {
                    Id = 2139139506,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(115206922));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(186139499));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(238167427));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(278033435));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314633946));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(346158728));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(579148996));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821333355));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(830308361));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981659275));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1576175752));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1727377006));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1933617278));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112719374));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139139506));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ImportModelConfig()
        {
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0M>(15);

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 5818289,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 201994761,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 382950350,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 417217067,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d),
                    NullableValue = null,

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 314633946
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 497631145,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 2112719374
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 502513670,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 553197799,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 278033435
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 558775498,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 1933617278
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 596270113,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 659842744,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 981659275
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 674372110,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d),
                    NullableValue = null,

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 2139139506
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 683741294,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 579148996
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1047749956,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d),
                    NullableValue = null,

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 186139499
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1079256990,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 115206922
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1148749115,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d),
                    NullableValue = null,

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 346158728
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1436399809,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1520909606,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1542622281,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1562047005,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1599567655,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d),
                    NullableValue = null,

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 1576175752
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1719316354,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1730168108,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1751785866,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 238167427
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1768320035,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1780063442,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1859377359,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 830308361
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1859629259,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 1727377006
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1948516315,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 1979461866,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d),
                    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d),

                    ModelInner = new NpgsqlCirclecircle0MI 
                    {
                        Id = 821333355
                    }

                });

                importCollection.Add(
                new NpgsqlCirclecircle0M
                {
                    Id = 2101078573,
                    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d),
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5818289));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(201994761));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382950350));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417217067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(314633946));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(497631145));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2112719374));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502513670));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553197799));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(278033435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558775498));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1933617278));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(596270113));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659842744));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(981659275));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(674372110));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139139506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(683741294));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(579148996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1047749956));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(186139499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079256990));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(115206922));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148749115));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(346158728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436399809));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1520909606));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1542622281));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562047005));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1599567655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1576175752));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719316354));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730168108));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751785866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(238167427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768320035));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780063442));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859377359));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(830308361));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1859629259));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1727377006));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948516315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1979461866));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821333355));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101078573));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlCirclecircle0M>(30);

                expected.Add(
                    5818289,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 5818289,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    201994761,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 201994761,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    382950350,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 382950350,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    417217067,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 417217067,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 314633946,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)
                        }

                    }
                );

                expected.Add(
                    497631145,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 497631145,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 2112719374,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)
                        }

                    }
                );

                expected.Add(
                    502513670,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 502513670,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    553197799,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 553197799,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 278033435,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    558775498,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 558775498,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1933617278,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)
                        }

                    }
                );

                expected.Add(
                    596270113,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 596270113,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    659842744,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 659842744,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 981659275,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)
                        }

                    }
                );

                expected.Add(
                    674372110,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 674372110,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 2139139506,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)
                        }

                    }
                );

                expected.Add(
                    683741294,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 683741294,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 579148996,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)
                        }

                    }
                );

                expected.Add(
                    1047749956,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1047749956,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 186139499,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1079256990,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1079256990,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 115206922,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)
                        }

                    }
                );

                expected.Add(
                    1148749115,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1148749115,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 346158728,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1436399809,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1436399809,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1520909606,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1520909606,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1542622281,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1542622281,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1562047005,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1562047005,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1599567655,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1599567655,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1576175752,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1719316354,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1719316354,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1730168108,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1730168108,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1751785866,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1751785866,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 238167427,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1768320035,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1768320035,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1780063442,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1780063442,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1859377359,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1859377359,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 830308361,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1859629259,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1859629259,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1727377006,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1948516315,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1948516315,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1979461866,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1979461866,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 821333355,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2101078573,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 2101078573,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlCirclecircle0M>(30);

                expected.Add(
                    5818289,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 5818289,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5121254947489007d, y: 0.6117735298461296d), radius: 0.9513465567035078d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772206807032635d, y: 0.33537476676853495d), radius: 0.9655967982768787d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    201994761,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 201994761,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07890562748648944d, y: 0.9774741442485148d), radius: 0.010775991096615312d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23346347944712087d, y: 0.8399129705450095d), radius: 0.9923792667872694d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    382950350,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 382950350,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7019802109445265d, y: 0.5845902336679629d), radius: 0.21022595731716642d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    417217067,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 417217067,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001032361529564d, y: 0.15735259668009438d), radius: 0.9156760383634581d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 314633946,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)
                        }

                    }
                );

                expected.Add(
                    497631145,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 497631145,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09823189565135038d, y: 0.10982974723942884d), radius: 0.924923688024387d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7198524070437609d, y: 0.7998858927967809d), radius: 0.2043584362415266d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 2112719374,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)
                        }

                    }
                );

                expected.Add(
                    502513670,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 502513670,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2564115115597916d, y: 0.8381068828287487d), radius: 0.7624362730204668d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    553197799,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 553197799,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5151172992250169d, y: 0.3923276104492708d), radius: 0.6564186443750553d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010626455464426754d, y: 0.9075440688309527d), radius: 0.4385583242952894d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 278033435,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    558775498,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 558775498,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923207950310506d, y: 0.25017855389411026d), radius: 0.4291619932304688d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02103860923346146d, y: 0.6284719989581533d), radius: 0.11219950012172841d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1933617278,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)
                        }

                    }
                );

                expected.Add(
                    596270113,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 596270113,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430677943874459d, y: 0.8435776180232013d), radius: 0.44538507020257856d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    659842744,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 659842744,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12222031031257652d, y: 0.7641428161607258d), radius: 0.16755572656950946d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4951215294257182d, y: 0.7794416336752594d), radius: 0.17560748912666324d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 981659275,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)
                        }

                    }
                );

                expected.Add(
                    674372110,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 674372110,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9064649546334436d, y: 0.3272634459160194d), radius: 0.7099815454445598d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 2139139506,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)
                        }

                    }
                );

                expected.Add(
                    683741294,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 683741294,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650153435531263d, y: 0.1579751673505958d), radius: 0.505935676004898d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987712757296829d, y: 0.505259324307848d), radius: 0.9667073310054649d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 579148996,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)
                        }

                    }
                );

                expected.Add(
                    1047749956,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1047749956,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03984879200815683d, y: 0.8819879978989522d), radius: 0.2468588772300948d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 186139499,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1079256990,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1079256990,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036883493278873d, y: 0.27865415377467495d), radius: 0.0009402914723091182d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40083221299213045d, y: 0.632080294252621d), radius: 0.5919189073771296d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 115206922,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d),
                            NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)
                        }

                    }
                );

                expected.Add(
                    1148749115,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1148749115,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281383564274359d, y: 0.46028498630937165d), radius: 0.1104430605493738d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 346158728,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1436399809,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1436399809,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748303830344577d, y: 0.2817825610965623d), radius: 0.9747753384375551d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715238131227807d, y: 0.42682395784146887d), radius: 0.6429918110688124d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1520909606,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1520909606,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7374495999294974d, y: 0.839763866932106d), radius: 0.6696138899714454d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1542622281,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1542622281,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615205016609675d, y: 0.982378726977711d), radius: 0.12843449248764272d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7478929971479575d, y: 0.06770870581194699d), radius: 0.11520425061794759d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1562047005,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1562047005,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06132472011174461d, y: 0.9008653781147937d), radius: 0.571455951267428d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083617557474188d, y: 0.5489584496844189d), radius: 0.15505150760164998d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1599567655,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1599567655,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15581081720568746d, y: 0.7877287511047405d), radius: 0.05158928179416533d),
                        NullableValue = null,

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1576175752,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1719316354,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1719316354,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12036109535297179d, y: 0.4754565193973328d), radius: 0.3222944119408402d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1730168108,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1730168108,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872625258648971d, y: 0.6201235408256004d), radius: 0.9035619794174216d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1751785866,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1751785866,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761940767846643d, y: 0.36154306294027116d), radius: 0.6575107540222347d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45070058736649277d, y: 0.9217259062900208d), radius: 0.001137028290886577d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 238167427,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1768320035,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1768320035,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526217860438794d, y: 0.283503860254143d), radius: 0.9773948612120915d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1780063442,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1780063442,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25193792972239737d, y: 0.957276508718208d), radius: 0.6907048280408287d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1859377359,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1859377359,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13408826749772695d, y: 0.7564249902250799d), radius: 0.8230651390608742d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09701079359858022d, y: 0.6007444344032027d), radius: 0.9047913509795975d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 830308361,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1859629259,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1859629259,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2836171748730315d, y: 0.1764518664391317d), radius: 0.2620506709785083d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7484410464754803d, y: 0.3790431847528285d), radius: 0.36354984195029383d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 1727377006,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1948516315,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1948516315,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020200508788852378d, y: 0.8866399587449372d), radius: 0.7362740143720472d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792813747157387d, y: 0.22533392587061307d), radius: 0.9442393879703163d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1979461866,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 1979461866,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410411716763456d, y: 0.8626338688612467d), radius: 0.15105682220835648d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05954740182321028d, y: 0.9147674402972712d), radius: 0.0689461934909038d),

                        ModelInner = new NpgsqlCirclecircle0MI
                        {
                            Id = 821333355,
                            Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2101078573,
                    new NpgsqlCirclecircle0M
                    {
                        Id = 2101078573,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710891863140643d, y: 0.5149385054328558d), radius: 0.024016229363700514d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlCircle)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlCirclecircle0MI>(15);

                expected.Add(
                    115206922,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 115206922,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)
                    }
                );

                expected.Add(
                    186139499,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 186139499,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    238167427,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 238167427,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    278033435,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 278033435,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    314633946,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 314633946,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)
                    }
                );

                expected.Add(
                    346158728,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 346158728,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    579148996,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 579148996,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)
                    }
                );

                expected.Add(
                    821333355,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 821333355,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    830308361,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 830308361,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    981659275,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 981659275,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)
                    }
                );

                expected.Add(
                    1576175752,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1576175752,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1727377006,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1727377006,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1933617278,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1933617278,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)
                    }
                );

                expected.Add(
                    2112719374,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 2112719374,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)
                    }
                );

                expected.Add(
                    2139139506,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 2139139506,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlCirclecircle0MI>(15);

                expected.Add(
                    115206922,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 115206922,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02301861750269052d, y: 0.9976335461608946d), radius: 0.7948905049700896d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787463351459539d, y: 0.7270606386201462d), radius: 0.796808406268648d)
                    }
                );

                expected.Add(
                    186139499,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 186139499,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48800001414340644d, y: 0.1332057435397096d), radius: 0.6428792389243054d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    238167427,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 238167427,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132812765513078d, y: 0.6197687167882266d), radius: 0.08756280973516306d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    278033435,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 278033435,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632346220449596d, y: 0.08620268692773447d), radius: 0.3269966972969349d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    314633946,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 314633946,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17457302418628406d, y: 0.46999056407665374d), radius: 0.4048504216007427d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007761384736494348d, y: 0.955694257008269d), radius: 0.044886492488782403d)
                    }
                );

                expected.Add(
                    346158728,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 346158728,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9546037071753621d, y: 0.8336398664131803d), radius: 0.0309025872536145d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    579148996,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 579148996,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686577562762128d, y: 0.7523743532393883d), radius: 0.7636425441120661d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917940535700447d, y: 0.8709223113961867d), radius: 0.2847379222154319d)
                    }
                );

                expected.Add(
                    821333355,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 821333355,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878839690197346d, y: 0.3411710996445516d), radius: 0.641251996124371d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    830308361,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 830308361,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6404921116048213d, y: 0.6248313619118396d), radius: 0.9543943257850419d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    981659275,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 981659275,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6904384518383329d, y: 0.3281223736027351d), radius: 0.7112694841728439d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6561717147116836d, y: 0.780604573799028d), radius: 0.5083985369284217d)
                    }
                );

                expected.Add(
                    1576175752,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1576175752,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425843461641191d, y: 0.20758030544425599d), radius: 0.48119862116245515d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1727377006,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1727377006,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12491411346469239d, y: 0.9438098067061426d), radius: 0.7770475019857462d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1933617278,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 1933617278,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32788627882287213d, y: 0.48325268128024157d), radius: 0.40417793218274534d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023411158487693928d, y: 0.5548369703106623d), radius: 0.5915923217394167d)
                    }
                );

                expected.Add(
                    2112719374,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 2112719374,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746250710302061d, y: 0.3822023625508656d), radius: 0.8261891764499052d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962555174198297d, y: 0.3915917780929037d), radius: 0.2205228609067036d)
                    }
                );

                expected.Add(
                    2139139506,
                    new NpgsqlCirclecircle0MI
                    {
                        Id = 2139139506,
                        Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.940883854587957d, y: 0.7285633726593193d), radius: 0.7984999488545909d),
                        NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763633945068695d, y: 0.03958643709122822d), radius: 0.2194540321925993d)
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

