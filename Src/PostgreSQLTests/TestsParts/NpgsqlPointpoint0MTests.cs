

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
    internal partial interface INpgsqlPointSingleTypepoint
    {
    }
    
    internal partial class NpgsqlPointSingleTypepoint : INpgsqlPointSingleTypepoint
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            queryMapType: typeof(NpgsqlPointpoint0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, 1199012279, new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, 509264608, new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d), new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d));
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, 1129967425, new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, 1615150284, new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d));
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

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, 326615807, new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d), null);
                Assert.That(id, Is.EqualTo(326615807));

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, 1818919411, new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d));
                Assert.That(id, Is.EqualTo(1818919411));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, 699159337, new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d));
                Assert.That(id, Is.EqualTo(699159337));

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, 60429369, new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d));
                Assert.That(id, Is.EqualTo(60429369));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModel(connection, 455919438, new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d), null);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 2031565557, new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 736196272, new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 517706901, new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 2080452184, new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d), new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 1947204016, new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d), new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, 1483557177, new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, 1903775839, new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d), new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, 63053938, new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d), 1199012279);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, 1158501230, new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, 1515540638, new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d), 509264608);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;

                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, 39860315, new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d), null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, 575578159, new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d), null, 1129967425);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;

                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, 273844957, new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d), new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, 981122757, new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d), null, 1615150284);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlPointpoint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                List<NpgsqlPointpoint0M> models = null;
                NpgsqlPointpoint0M model = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, 1633446054, new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, 1009551781, new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d), null, 326615807).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, 573009500, new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, 329065055, new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d), new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d), 1818919411).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;
                NpgsqlPointpoint0M model = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, 1304022583, new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, 457951162, new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d), null, 699159337).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, 424144460, new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, 1810606011, new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d), new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d), 60429369).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpoint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPoint), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpointpoint0mi_id", 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, 455478353, new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d), new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, 108622181, new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d), null, 455919438);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 252567078, new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 2000701093, new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d), null, 2031565557);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 1579161242, new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 66938139, new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d), null, 736196272);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 1719337947, new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d), new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 382776886, new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d), new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d), 517706901);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 1364886797, new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 1788435806, new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d), 2080452184);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 660531311, new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d), new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 603247795, new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d), null, 1947204016);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 455746032, new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, 350372260, new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d), null, 1483557177);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 660531311);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 660531311);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
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
                 foreach(var batchResult in ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelBatch(connection, 66938139, 1009551781))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
                await foreach(var batchResult in ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelBatchAsync(connection, 457951162, 575578159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(17));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39860315)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63053938)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1199012279)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66938139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((736196272)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108622181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((455919438)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((252567078)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((273844957)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329065055)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1818919411)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((350372260)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1483557177)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382776886)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((517706901)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((424144460)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455478353)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455746032)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((457951162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((699159337)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((573009500)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((575578159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1129967425)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((603247795)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1947204016)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((660531311)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((981122757)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1615150284)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1009551781)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((326615807)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1158501230)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1304022583)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1364886797)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1515540638)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((509264608)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1579161242)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1633446054)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1719337947)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788435806)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2080452184)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1810606011)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60429369)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1903775839)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000701093)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2031565557)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39860315)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63053938)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1199012279)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66938139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((736196272)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108622181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((455919438)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((252567078)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((273844957)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329065055)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1818919411)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((350372260)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1483557177)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382776886)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((517706901)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((424144460)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455478353)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455746032)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((457951162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((699159337)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((573009500)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((575578159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1129967425)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((603247795)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1947204016)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((660531311)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((981122757)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1615150284)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1009551781)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((326615807)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1158501230)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1304022583)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1364886797)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1515540638)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((509264608)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1579161242)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1633446054)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1719337947)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788435806)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2080452184)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1810606011)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60429369)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1903775839)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000701093)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2031565557)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
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

                var importCollection = new List<NpgsqlPointpoint0MI>(7);

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 60429369,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 326615807,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 455919438,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 509264608,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 517706901,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 699159337,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 736196272,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(60429369));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(326615807));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455919438));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509264608));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517706901));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699159337));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(736196272));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1129967425,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1199012279,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1483557177,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1615150284,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1818919411,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 1947204016,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 2031565557,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpoint0MI
                {
                    Id = 2080452184,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(60429369));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(326615807));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455919438));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509264608));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517706901));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699159337));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(736196272));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1129967425));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1199012279));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1483557177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1615150284));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1818919411));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1947204016));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2031565557));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080452184));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
FROM public.binary_npgsqlpointpoint0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
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

                var importCollection = new List<NpgsqlPointpoint0M>(15);

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 39860315,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 63053938,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1199012279
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 66938139,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 736196272
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 108622181,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 455919438
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 252567078,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 273844957,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 329065055,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1818919411
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 350372260,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1483557177
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 382776886,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 517706901
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 424144460,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 455478353,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 455746032,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 457951162,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 699159337
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 573009500,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 575578159,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1129967425
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 603247795,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1947204016
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 660531311,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 981122757,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 1615150284
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1009551781,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 326615807
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1158501230,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1304022583,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1364886797,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1515540638,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 509264608
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1579161242,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1633446054,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1719337947,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1788435806,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 2080452184
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1810606011,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d),

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 60429369
                    }

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 1903775839,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d),
                    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpoint0M
                {
                    Id = 2000701093,
                    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d),
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpoint0MI 
                    {
                        Id = 2031565557
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39860315));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(63053938));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1199012279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66938139));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(736196272));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108622181));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(455919438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252567078));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273844957));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329065055));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818919411));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(350372260));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1483557177));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382776886));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(517706901));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424144460));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455478353));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455746032));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457951162));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699159337));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573009500));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(575578159));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1129967425));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603247795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1947204016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(660531311));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981122757));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1615150284));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1009551781));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(326615807));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158501230));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1304022583));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364886797));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1515540638));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(509264608));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1579161242));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1633446054));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719337947));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788435806));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2080452184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1810606011));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(60429369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1903775839));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000701093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2031565557));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpoint0M>(30);

                expected.Add(
                    39860315,
                    new NpgsqlPointpoint0M
                    {
                        Id = 39860315,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    63053938,
                    new NpgsqlPointpoint0M
                    {
                        Id = 63053938,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1199012279,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)
                        }

                    }
                );

                expected.Add(
                    66938139,
                    new NpgsqlPointpoint0M
                    {
                        Id = 66938139,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 736196272,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)
                        }

                    }
                );

                expected.Add(
                    108622181,
                    new NpgsqlPointpoint0M
                    {
                        Id = 108622181,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 455919438,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    252567078,
                    new NpgsqlPointpoint0M
                    {
                        Id = 252567078,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    273844957,
                    new NpgsqlPointpoint0M
                    {
                        Id = 273844957,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    329065055,
                    new NpgsqlPointpoint0M
                    {
                        Id = 329065055,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1818919411,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)
                        }

                    }
                );

                expected.Add(
                    350372260,
                    new NpgsqlPointpoint0M
                    {
                        Id = 350372260,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1483557177,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    382776886,
                    new NpgsqlPointpoint0M
                    {
                        Id = 382776886,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 517706901,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)
                        }

                    }
                );

                expected.Add(
                    424144460,
                    new NpgsqlPointpoint0M
                    {
                        Id = 424144460,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    455478353,
                    new NpgsqlPointpoint0M
                    {
                        Id = 455478353,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    455746032,
                    new NpgsqlPointpoint0M
                    {
                        Id = 455746032,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    457951162,
                    new NpgsqlPointpoint0M
                    {
                        Id = 457951162,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 699159337,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)
                        }

                    }
                );

                expected.Add(
                    573009500,
                    new NpgsqlPointpoint0M
                    {
                        Id = 573009500,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    575578159,
                    new NpgsqlPointpoint0M
                    {
                        Id = 575578159,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1129967425,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    603247795,
                    new NpgsqlPointpoint0M
                    {
                        Id = 603247795,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1947204016,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)
                        }

                    }
                );

                expected.Add(
                    660531311,
                    new NpgsqlPointpoint0M
                    {
                        Id = 660531311,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    981122757,
                    new NpgsqlPointpoint0M
                    {
                        Id = 981122757,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1615150284,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)
                        }

                    }
                );

                expected.Add(
                    1009551781,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1009551781,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 326615807,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1158501230,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1158501230,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1304022583,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1304022583,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1364886797,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1364886797,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1515540638,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1515540638,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 509264608,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)
                        }

                    }
                );

                expected.Add(
                    1579161242,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1579161242,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1633446054,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1633446054,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1719337947,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1719337947,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1788435806,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1788435806,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 2080452184,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)
                        }

                    }
                );

                expected.Add(
                    1810606011,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1810606011,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 60429369,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)
                        }

                    }
                );

                expected.Add(
                    1903775839,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1903775839,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2000701093,
                    new NpgsqlPointpoint0M
                    {
                        Id = 2000701093,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 2031565557,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d),
                            NullableValue = null
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpoint0M>(30);

                expected.Add(
                    39860315,
                    new NpgsqlPointpoint0M
                    {
                        Id = 39860315,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3774961091444512d, y: 0.8165630471143601d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    63053938,
                    new NpgsqlPointpoint0M
                    {
                        Id = 63053938,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.89438413186227d, y: 0.2987046529850753d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9811587227812055d, y: 0.05372785063660479d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1199012279,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)
                        }

                    }
                );

                expected.Add(
                    66938139,
                    new NpgsqlPointpoint0M
                    {
                        Id = 66938139,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8612271669036501d, y: 0.28726342153661555d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 736196272,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)
                        }

                    }
                );

                expected.Add(
                    108622181,
                    new NpgsqlPointpoint0M
                    {
                        Id = 108622181,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24538265573319773d, y: 0.3499427639919145d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 455919438,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    252567078,
                    new NpgsqlPointpoint0M
                    {
                        Id = 252567078,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3305480185063221d, y: 0.1015234222621395d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    273844957,
                    new NpgsqlPointpoint0M
                    {
                        Id = 273844957,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2829747943624291d, y: 0.8321283228346236d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.14707859289200054d, y: 0.9660336166490556d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    329065055,
                    new NpgsqlPointpoint0M
                    {
                        Id = 329065055,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5659250491058953d, y: 0.5462060654044025d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.49442698119428763d, y: 0.41087150267505845d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1818919411,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)
                        }

                    }
                );

                expected.Add(
                    350372260,
                    new NpgsqlPointpoint0M
                    {
                        Id = 350372260,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9377158512756043d, y: 0.32660909811536143d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1483557177,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    382776886,
                    new NpgsqlPointpoint0M
                    {
                        Id = 382776886,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1469388417351576d, y: 0.22973045818243454d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.24806827343988402d, y: 0.1754174219399932d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 517706901,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)
                        }

                    }
                );

                expected.Add(
                    424144460,
                    new NpgsqlPointpoint0M
                    {
                        Id = 424144460,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.027478437053030547d, y: 0.8275072699725488d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6568144449560147d, y: 0.467461935270436d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    455478353,
                    new NpgsqlPointpoint0M
                    {
                        Id = 455478353,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9297331724057271d, y: 0.43759432339104876d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.919473665234915d, y: 0.8739822887442723d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    455746032,
                    new NpgsqlPointpoint0M
                    {
                        Id = 455746032,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.20586436259264862d, y: 0.6107846671177785d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    457951162,
                    new NpgsqlPointpoint0M
                    {
                        Id = 457951162,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24598521756273783d, y: 0.36981187911895486d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 699159337,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)
                        }

                    }
                );

                expected.Add(
                    573009500,
                    new NpgsqlPointpoint0M
                    {
                        Id = 573009500,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7450401940264403d, y: 0.8286515811525185d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8149676095650826d, y: 0.8156458012722441d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    575578159,
                    new NpgsqlPointpoint0M
                    {
                        Id = 575578159,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3831884334687282d, y: 0.604754072860792d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1129967425,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    603247795,
                    new NpgsqlPointpoint0M
                    {
                        Id = 603247795,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9299430866744903d, y: 0.43178226051426405d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1947204016,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)
                        }

                    }
                );

                expected.Add(
                    660531311,
                    new NpgsqlPointpoint0M
                    {
                        Id = 660531311,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23332918419628035d, y: 0.3462877571894828d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.635589226617947d, y: 0.584782995527915d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    981122757,
                    new NpgsqlPointpoint0M
                    {
                        Id = 981122757,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4410220700813493d, y: 0.5537797000175326d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 1615150284,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)
                        }

                    }
                );

                expected.Add(
                    1009551781,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1009551781,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8277898714326314d, y: 0.7223255334327499d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 326615807,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1158501230,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1158501230,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06923570727612893d, y: 0.840314196452447d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1304022583,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1304022583,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3016057912832928d, y: 0.5419152911066132d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1364886797,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1364886797,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3993259853114721d, y: 0.45003415206033326d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6594636424906588d, y: 0.32371718469338195d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1515540638,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1515540638,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.22802233609400613d, y: 0.508402747419628d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6480571766858974d, y: 0.2045760644196729d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 509264608,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)
                        }

                    }
                );

                expected.Add(
                    1579161242,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1579161242,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.44438380624394014d, y: 0.7898227148103547d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9983925146323498d, y: 0.8667499826639234d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1633446054,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1633446054,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5641599403251412d, y: 0.1920070701781511d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1719337947,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1719337947,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17416933244732258d, y: 0.1655316297998769d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17027768183533243d, y: 0.30245714340332275d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1788435806,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1788435806,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6377875326064149d, y: 0.7093614587916771d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6619530866572984d, y: 0.20058422437019907d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 2080452184,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)
                        }

                    }
                );

                expected.Add(
                    1810606011,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1810606011,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.586053411224485d, y: 0.18548281479610618d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.0984396981544775d, y: 0.731146605119495d),

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 60429369,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d),
                            NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)
                        }

                    }
                );

                expected.Add(
                    1903775839,
                    new NpgsqlPointpoint0M
                    {
                        Id = 1903775839,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8496160242641063d, y: 0.2983839485645541d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.45950193553946483d, y: 0.98176213083837d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2000701093,
                    new NpgsqlPointpoint0M
                    {
                        Id = 2000701093,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5434578616336798d, y: 0.6783853257730725d),
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpoint0MI
                        {
                            Id = 2031565557,
                            Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d),
                            NullableValue = null
                        }

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpoint0MI>(15);

                expected.Add(
                    60429369,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 60429369,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)
                    }
                );

                expected.Add(
                    326615807,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 326615807,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    455919438,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 455919438,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    509264608,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 509264608,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)
                    }
                );

                expected.Add(
                    517706901,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 517706901,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)
                    }
                );

                expected.Add(
                    699159337,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 699159337,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)
                    }
                );

                expected.Add(
                    736196272,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 736196272,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)
                    }
                );

                expected.Add(
                    1129967425,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1129967425,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1199012279,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1199012279,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)
                    }
                );

                expected.Add(
                    1483557177,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1483557177,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1615150284,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1615150284,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)
                    }
                );

                expected.Add(
                    1818919411,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1818919411,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)
                    }
                );

                expected.Add(
                    1947204016,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1947204016,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)
                    }
                );

                expected.Add(
                    2031565557,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 2031565557,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2080452184,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 2080452184,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpoint0MI>(15);

                expected.Add(
                    60429369,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 60429369,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8907921445364175d, y: 0.7276892952450089d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2862549709019402d, y: 0.4004917495972049d)
                    }
                );

                expected.Add(
                    326615807,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 326615807,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9617155939586752d, y: 0.43842891325131494d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    455919438,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 455919438,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8210261346904794d, y: 0.5854205204890528d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    509264608,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 509264608,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.041854034979555754d, y: 0.5122347079443664d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36802322020459366d, y: 0.48572167831511237d)
                    }
                );

                expected.Add(
                    517706901,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 517706901,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46188043202537754d, y: 0.4005285551910992d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3768865332266673d, y: 0.621256149027211d)
                    }
                );

                expected.Add(
                    699159337,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 699159337,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37757308202632656d, y: 0.020598881012767745d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6856679671265079d, y: 0.936967675828002d)
                    }
                );

                expected.Add(
                    736196272,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 736196272,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3605031436883759d, y: 0.10206852704393998d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7118775418097597d, y: 0.5857563183541445d)
                    }
                );

                expected.Add(
                    1129967425,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1129967425,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7044322550052987d, y: 0.22467973081620496d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1199012279,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1199012279,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45131046134555475d, y: 0.18045664546036655d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7254686177054185d, y: 0.4835261944435113d)
                    }
                );

                expected.Add(
                    1483557177,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1483557177,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5316550893792605d, y: 0.2646816177561795d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1615150284,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1615150284,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26060045627947004d, y: 0.45281052111802256d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7111643664578494d, y: 0.3734337215954242d)
                    }
                );

                expected.Add(
                    1818919411,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1818919411,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16179863219743407d, y: 0.8004676009066037d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7855348097088352d, y: 0.12259382286579312d)
                    }
                );

                expected.Add(
                    1947204016,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 1947204016,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.735527460359767d, y: 0.8886976033478081d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2744208603326572d, y: 0.9154805409811178d)
                    }
                );

                expected.Add(
                    2031565557,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 2031565557,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6622581132792782d, y: 0.051267058103644625d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    2080452184,
                    new NpgsqlPointpoint0MI
                    {
                        Id = 2080452184,
                        Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46009290163855243d, y: 0.7173412617631685d),
                        NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2685323576373161d, y: 0.0589300599647129d)
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

