

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapType: typeof(NpgsqlLineline0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, 754020948, new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d), new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, 1551362529, new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d), null);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, 64866487, new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d), new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, 824117470, new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d), null);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, 412026365, new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d), null);
                Assert.That(id, Is.EqualTo(412026365));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, 315654936, new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d), null);
                Assert.That(id, Is.EqualTo(315654936));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, 1466217598, new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d), null);
                Assert.That(id, Is.EqualTo(1466217598));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, 112657814, new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d), new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d));
                Assert.That(id, Is.EqualTo(112657814));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, 809976934, new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d), new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d));
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 294883927, new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d), new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 699297093, new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d), new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 1608904622, new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d), new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 1688554763, new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 1114445123, new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, 395635542, new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d), new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, 1148847067, new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, 1782963965, new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d), null, 754020948);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, 535870860, new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d), new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, 1496110451, new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d), null, 1551362529);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;

                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, 1253933978, new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d), new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d), null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, 384285552, new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d), null, 64866487);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;

                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, 1457859542, new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d), null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, 1193583177, new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d), new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d), 824117470);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlLineline0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                List<NpgsqlLineline0M> models = null;
                NpgsqlLineline0M model = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, 1488056443, new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, 213963135, new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d), null, 412026365).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, 1263594686, new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, 489715584, new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d), new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d), 315654936).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;
                NpgsqlLineline0M model = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, 1021851829, new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d), new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, 1863647587, new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d), null, 1466217598).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, 1482665160, new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, 1301108616, new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d), null, 112657814).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, 451653627, new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d), new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, 928024795, new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d), new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d), 809976934);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 897273655, new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 2094332478, new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d), new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d), 294883927);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 470704918, new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d), new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 1369323587, new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d), null, 699297093);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 502597394, new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 1607545850, new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d), new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d), 1608904622);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 175351441, new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 1312769390, new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d), new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d), 1688554763);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 1614425747, new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d), new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 1799540740, new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d), new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d), 1114445123);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 81690582, new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, 271227660, new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d), null, 395635542);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlLineline0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
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
                var models =  ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlLineline0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
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
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 1488056443);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(7));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 1482665160);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(8));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
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
                 foreach(var batchResult in ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelBatch(connection, 451653627, 1263594686))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

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
                await foreach(var batchResult in ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelBatchAsync(connection, 213963135, 1799540740))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
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
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81690582)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175351441)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213963135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((412026365)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((271227660)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((395635542)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((384285552)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64866487)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((451653627)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((470704918)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((489715584)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((315654936)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502597394)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((535870860)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((897273655)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((928024795)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((809976934)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1021851829)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148847067)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1193583177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((824117470)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253933978)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1263594686)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1301108616)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((112657814)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312769390)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1688554763)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1369323587)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((699297093)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1457859542)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1482665160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1488056443)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1496110451)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1551362529)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1607545850)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1608904622)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1614425747)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1782963965)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((754020948)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1799540740)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114445123)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1863647587)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1466217598)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2094332478)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((294883927)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81690582)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175351441)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213963135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((412026365)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((271227660)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((395635542)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((384285552)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64866487)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((451653627)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((470704918)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((489715584)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((315654936)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502597394)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((535870860)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((897273655)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((928024795)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((809976934)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1021851829)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1148847067)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1193583177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((824117470)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1253933978)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1263594686)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1301108616)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((112657814)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312769390)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1688554763)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1369323587)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((699297093)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1457859542)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1482665160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1488056443)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1496110451)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1551362529)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1607545850)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1608904622)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1614425747)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1782963965)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((754020948)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1799540740)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114445123)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1863647587)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1466217598)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2094332478)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((294883927)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d))));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
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

                var importCollection = new List<NpgsqlLineline0MI>(7);

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 64866487,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 112657814,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 294883927,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 315654936,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 395635542,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 412026365,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 699297093,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64866487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(112657814));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294883927));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(315654936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(395635542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(412026365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699297093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 754020948,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 809976934,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 824117470,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 1114445123,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 1466217598,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 1551362529,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 1608904622,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)
                });

                importCollection.Add(
                new NpgsqlLineline0MI
                {
                    Id = 1688554763,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d),
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(64866487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(112657814));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294883927));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(315654936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(395635542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(412026365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(699297093));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(754020948));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809976934));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824117470));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1114445123));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1466217598));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551362529));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1608904622));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1688554763));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
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

                var importCollection = new List<NpgsqlLineline0M>(15);

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 81690582,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 175351441,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 213963135,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 412026365
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 271227660,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 395635542
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 384285552,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 64866487
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 451653627,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 470704918,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 489715584,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 315654936
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 502597394,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 535870860,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 897273655,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 928024795,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 809976934
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1021851829,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1148847067,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1193583177,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 824117470
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1253933978,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1263594686,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1301108616,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 112657814
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1312769390,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 1688554763
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1369323587,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 699297093
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1457859542,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1482665160,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1488056443,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1496110451,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 1551362529
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1607545850,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 1608904622
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1614425747,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1782963965,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 754020948
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1799540740,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 1114445123
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 1863647587,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d),
                    NullableValue = null,

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 1466217598
                    }

                });

                importCollection.Add(
                new NpgsqlLineline0M
                {
                    Id = 2094332478,
                    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d),
                    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d),

                    ModelInner = new NpgsqlLineline0MI 
                    {
                        Id = 294883927
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(81690582));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(175351441));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(213963135));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(412026365));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271227660));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395635542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384285552));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64866487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(451653627));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(470704918));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(489715584));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315654936));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502597394));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535870860));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(897273655));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928024795));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(809976934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1021851829));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1148847067));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1193583177));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(824117470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1253933978));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263594686));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301108616));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(112657814));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312769390));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1688554763));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1369323587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(699297093));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1457859542));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1482665160));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488056443));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1496110451));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1551362529));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607545850));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608904622));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)));


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614425747));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782963965));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(754020948));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1799540740));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114445123));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1863647587));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1466217598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094332478));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(294883927));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)));


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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

                var expected = new Dictionary<System.Int32,NpgsqlLineline0M>(30);

                expected.Add(
                    81690582,
                    new NpgsqlLineline0M
                    {
                        Id = 81690582,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    175351441,
                    new NpgsqlLineline0M
                    {
                        Id = 175351441,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    213963135,
                    new NpgsqlLineline0M
                    {
                        Id = 213963135,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 412026365,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    271227660,
                    new NpgsqlLineline0M
                    {
                        Id = 271227660,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 395635542,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)
                        }

                    }
                );

                expected.Add(
                    384285552,
                    new NpgsqlLineline0M
                    {
                        Id = 384285552,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 64866487,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)
                        }

                    }
                );

                expected.Add(
                    451653627,
                    new NpgsqlLineline0M
                    {
                        Id = 451653627,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    470704918,
                    new NpgsqlLineline0M
                    {
                        Id = 470704918,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    489715584,
                    new NpgsqlLineline0M
                    {
                        Id = 489715584,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 315654936,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    502597394,
                    new NpgsqlLineline0M
                    {
                        Id = 502597394,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    535870860,
                    new NpgsqlLineline0M
                    {
                        Id = 535870860,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    897273655,
                    new NpgsqlLineline0M
                    {
                        Id = 897273655,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    928024795,
                    new NpgsqlLineline0M
                    {
                        Id = 928024795,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 809976934,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)
                        }

                    }
                );

                expected.Add(
                    1021851829,
                    new NpgsqlLineline0M
                    {
                        Id = 1021851829,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1148847067,
                    new NpgsqlLineline0M
                    {
                        Id = 1148847067,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1193583177,
                    new NpgsqlLineline0M
                    {
                        Id = 1193583177,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 824117470,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1253933978,
                    new NpgsqlLineline0M
                    {
                        Id = 1253933978,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1263594686,
                    new NpgsqlLineline0M
                    {
                        Id = 1263594686,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1301108616,
                    new NpgsqlLineline0M
                    {
                        Id = 1301108616,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 112657814,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)
                        }

                    }
                );

                expected.Add(
                    1312769390,
                    new NpgsqlLineline0M
                    {
                        Id = 1312769390,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1688554763,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1369323587,
                    new NpgsqlLineline0M
                    {
                        Id = 1369323587,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 699297093,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)
                        }

                    }
                );

                expected.Add(
                    1457859542,
                    new NpgsqlLineline0M
                    {
                        Id = 1457859542,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1482665160,
                    new NpgsqlLineline0M
                    {
                        Id = 1482665160,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1488056443,
                    new NpgsqlLineline0M
                    {
                        Id = 1488056443,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1496110451,
                    new NpgsqlLineline0M
                    {
                        Id = 1496110451,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1551362529,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1607545850,
                    new NpgsqlLineline0M
                    {
                        Id = 1607545850,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1608904622,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)
                        }

                    }
                );

                expected.Add(
                    1614425747,
                    new NpgsqlLineline0M
                    {
                        Id = 1614425747,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1782963965,
                    new NpgsqlLineline0M
                    {
                        Id = 1782963965,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 754020948,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)
                        }

                    }
                );

                expected.Add(
                    1799540740,
                    new NpgsqlLineline0M
                    {
                        Id = 1799540740,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1114445123,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1863647587,
                    new NpgsqlLineline0M
                    {
                        Id = 1863647587,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1466217598,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2094332478,
                    new NpgsqlLineline0M
                    {
                        Id = 2094332478,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 294883927,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
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

                var expected = new Dictionary<System.Int32,NpgsqlLineline0M>(30);

                expected.Add(
                    81690582,
                    new NpgsqlLineline0M
                    {
                        Id = 81690582,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5890999833324821d, b: 0.10173718815013777d, c: 0.8334332452692926d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    175351441,
                    new NpgsqlLineline0M
                    {
                        Id = 175351441,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21659200991046967d, b: 0.7722147599114921d, c: 0.6681949526249905d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    213963135,
                    new NpgsqlLineline0M
                    {
                        Id = 213963135,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21082825064625643d, b: 0.2897168158150263d, c: 0.09562354157092956d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 412026365,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    271227660,
                    new NpgsqlLineline0M
                    {
                        Id = 271227660,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.05512141114834479d, b: 0.9483131179609761d, c: 0.33800705955413646d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 395635542,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)
                        }

                    }
                );

                expected.Add(
                    384285552,
                    new NpgsqlLineline0M
                    {
                        Id = 384285552,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.29826198217766275d, b: 0.3215613407149087d, c: 0.15630162777618595d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 64866487,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)
                        }

                    }
                );

                expected.Add(
                    451653627,
                    new NpgsqlLineline0M
                    {
                        Id = 451653627,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5188483861496043d, b: 0.0638322122088053d, c: 0.8354785615587429d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2508202970151211d, b: 0.2900897909334572d, c: 0.899827098573356d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    470704918,
                    new NpgsqlLineline0M
                    {
                        Id = 470704918,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.3414837899983155d, b: 0.9464002332063484d, c: 0.20947822041238717d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4630904682183339d, b: 0.06842627801345458d, c: 0.6448466325787122d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    489715584,
                    new NpgsqlLineline0M
                    {
                        Id = 489715584,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6895147803773699d, b: 0.7940453975521798d, c: 0.43231716190110125d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.22376785794820186d, b: 0.7307707961207579d, c: 0.6079881566639059d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 315654936,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    502597394,
                    new NpgsqlLineline0M
                    {
                        Id = 502597394,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.06707324309838258d, b: 0.7805695845278389d, c: 0.34241080906954147d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    535870860,
                    new NpgsqlLineline0M
                    {
                        Id = 535870860,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.34714422618343466d, b: 0.7484818480631177d, c: 0.9676012647323324d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4886472667345889d, b: 0.8538053512927141d, c: 0.11453231957469356d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    897273655,
                    new NpgsqlLineline0M
                    {
                        Id = 897273655,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.22449972051331823d, b: 0.47336308990542475d, c: 0.8827347079778569d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    928024795,
                    new NpgsqlLineline0M
                    {
                        Id = 928024795,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7525564249977351d, b: 0.7977953176384026d, c: 0.9309645679339814d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9349596054756222d, b: 0.703871813175577d, c: 0.3025130445781795d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 809976934,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)
                        }

                    }
                );

                expected.Add(
                    1021851829,
                    new NpgsqlLineline0M
                    {
                        Id = 1021851829,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.08757574742569296d, b: 0.011923942658712328d, c: 0.5035283428889131d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.48742821476333587d, b: 0.988263369433854d, c: 0.6304113408512899d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1148847067,
                    new NpgsqlLineline0M
                    {
                        Id = 1148847067,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.21766941813638252d, b: 0.895384101022902d, c: 0.308571022517533d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1193583177,
                    new NpgsqlLineline0M
                    {
                        Id = 1193583177,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.09599382037658877d, b: 0.5207693377394428d, c: 0.34397918836345587d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5246893203439785d, b: 0.3975244990691652d, c: 0.6859034727986418d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 824117470,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1253933978,
                    new NpgsqlLineline0M
                    {
                        Id = 1253933978,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9801690525199965d, b: 0.21769524797797335d, c: 0.682776285243195d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12057563615466704d, b: 0.991495241272292d, c: 0.42932658128072965d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1263594686,
                    new NpgsqlLineline0M
                    {
                        Id = 1263594686,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.15299511969699298d, b: 0.3862384323889805d, c: 0.5204736697146318d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1301108616,
                    new NpgsqlLineline0M
                    {
                        Id = 1301108616,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.28247972261881626d, b: 0.1825871349900371d, c: 0.15021175440388934d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 112657814,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)
                        }

                    }
                );

                expected.Add(
                    1312769390,
                    new NpgsqlLineline0M
                    {
                        Id = 1312769390,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5575358230449357d, b: 0.3245519743804042d, c: 0.802905493700332d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.574988439208476d, b: 0.4579256367773682d, c: 0.07836953470625163d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1688554763,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1369323587,
                    new NpgsqlLineline0M
                    {
                        Id = 1369323587,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6654727775405505d, b: 0.7595752280536738d, c: 0.621726423637986d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 699297093,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)
                        }

                    }
                );

                expected.Add(
                    1457859542,
                    new NpgsqlLineline0M
                    {
                        Id = 1457859542,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8353276899616063d, b: 0.3757896375226071d, c: 0.21613351890726917d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1482665160,
                    new NpgsqlLineline0M
                    {
                        Id = 1482665160,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.5169105343684858d, b: 0.7404718697974156d, c: 0.3395099597402982d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1488056443,
                    new NpgsqlLineline0M
                    {
                        Id = 1488056443,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.07762407391403048d, b: 0.8721191348589985d, c: 0.854015262634613d),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1496110451,
                    new NpgsqlLineline0M
                    {
                        Id = 1496110451,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6154253318548563d, b: 0.7244162450766153d, c: 0.3049683057987762d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1551362529,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1607545850,
                    new NpgsqlLineline0M
                    {
                        Id = 1607545850,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7318309343259127d, b: 0.637986628409847d, c: 0.40714476422656687d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5076467020740961d, b: 0.9602154153066457d, c: 0.09936738921774124d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1608904622,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)
                        }

                    }
                );

                expected.Add(
                    1614425747,
                    new NpgsqlLineline0M
                    {
                        Id = 1614425747,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.006829574158989771d, b: 0.1712463245862893d, c: 0.2975018503171717d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09005782590248967d, b: 0.4790442456656747d, c: 0.14017855693798031d),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1782963965,
                    new NpgsqlLineline0M
                    {
                        Id = 1782963965,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.148764414515128d, b: 0.7162483162831603d, c: 0.5502791358722252d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 754020948,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)
                        }

                    }
                );

                expected.Add(
                    1799540740,
                    new NpgsqlLineline0M
                    {
                        Id = 1799540740,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673739304647893d, b: 0.35935810210257757d, c: 0.7918903148183349d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3612126722620209d, b: 0.4569153100615775d, c: 0.24808104425017508d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1114445123,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1863647587,
                    new NpgsqlLineline0M
                    {
                        Id = 1863647587,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.6673082462998032d, b: 0.5469127102662162d, c: 0.04133963441681987d),
                        NullableValue = null,

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 1466217598,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2094332478,
                    new NpgsqlLineline0M
                    {
                        Id = 2094332478,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8185634538177486d, b: 0.5420640408387511d, c: 0.32524125341503174d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09962478201526903d, b: 0.8417202288340078d, c: 0.304757210857158d),

                        ModelInner = new NpgsqlLineline0MI
                        {
                            Id = 294883927,
                            Value = new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d),
                            NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlLine)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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

                var expected = new Dictionary<System.Int32,NpgsqlLineline0MI>(15);

                expected.Add(
                    64866487,
                    new NpgsqlLineline0MI
                    {
                        Id = 64866487,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)
                    }
                );

                expected.Add(
                    112657814,
                    new NpgsqlLineline0MI
                    {
                        Id = 112657814,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)
                    }
                );

                expected.Add(
                    294883927,
                    new NpgsqlLineline0MI
                    {
                        Id = 294883927,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)
                    }
                );

                expected.Add(
                    315654936,
                    new NpgsqlLineline0MI
                    {
                        Id = 315654936,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    395635542,
                    new NpgsqlLineline0MI
                    {
                        Id = 395635542,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)
                    }
                );

                expected.Add(
                    412026365,
                    new NpgsqlLineline0MI
                    {
                        Id = 412026365,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    699297093,
                    new NpgsqlLineline0MI
                    {
                        Id = 699297093,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)
                    }
                );

                expected.Add(
                    754020948,
                    new NpgsqlLineline0MI
                    {
                        Id = 754020948,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)
                    }
                );

                expected.Add(
                    809976934,
                    new NpgsqlLineline0MI
                    {
                        Id = 809976934,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)
                    }
                );

                expected.Add(
                    824117470,
                    new NpgsqlLineline0MI
                    {
                        Id = 824117470,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1114445123,
                    new NpgsqlLineline0MI
                    {
                        Id = 1114445123,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1466217598,
                    new NpgsqlLineline0MI
                    {
                        Id = 1466217598,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1551362529,
                    new NpgsqlLineline0MI
                    {
                        Id = 1551362529,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1608904622,
                    new NpgsqlLineline0MI
                    {
                        Id = 1608904622,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)
                    }
                );

                expected.Add(
                    1688554763,
                    new NpgsqlLineline0MI
                    {
                        Id = 1688554763,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d),
                        NullableValue = null
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

                var expected = new Dictionary<System.Int32,NpgsqlLineline0MI>(15);

                expected.Add(
                    64866487,
                    new NpgsqlLineline0MI
                    {
                        Id = 64866487,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 7.312703477269089E-05d, b: 0.45734042413998466d, c: 0.19036530180738132d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1942514798295334d, b: 0.48451818079124165d, c: 0.480771046404575d)
                    }
                );

                expected.Add(
                    112657814,
                    new NpgsqlLineline0MI
                    {
                        Id = 112657814,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8986918662476933d, b: 0.9087899791521864d, c: 0.32925442847381736d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8189244799639475d, b: 0.16620960514769234d, c: 0.5171260498144361d)
                    }
                );

                expected.Add(
                    294883927,
                    new NpgsqlLineline0MI
                    {
                        Id = 294883927,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.28108533651676215d, b: 0.023290687068965088d, c: 0.8382069772316745d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18129626771334384d, b: 0.6194072626547082d, c: 0.48163265240280717d)
                    }
                );

                expected.Add(
                    315654936,
                    new NpgsqlLineline0MI
                    {
                        Id = 315654936,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.33014410906924296d, b: 0.35612546578522253d, c: 0.322901047978864d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    395635542,
                    new NpgsqlLineline0MI
                    {
                        Id = 395635542,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.4552275088160592d, b: 0.6123294467169015d, c: 0.4969028818245398d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5704796536140982d, b: 0.49978175844136097d, c: 0.36500865039949393d)
                    }
                );

                expected.Add(
                    412026365,
                    new NpgsqlLineline0MI
                    {
                        Id = 412026365,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.38635991004087133d, b: 0.3707568270954099d, c: 0.3345285294761202d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    699297093,
                    new NpgsqlLineline0MI
                    {
                        Id = 699297093,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.3891923655090155d, b: 0.25537737616785794d, c: 0.9819847674473894d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7840153064297536d, b: 0.6469377982239772d, c: 0.7596942996664198d)
                    }
                );

                expected.Add(
                    754020948,
                    new NpgsqlLineline0MI
                    {
                        Id = 754020948,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.24197130051724258d, b: 0.7908094647853432d, c: 0.9610344940969565d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20003057496197896d, b: 0.08557519603924135d, c: 0.8304546743982446d)
                    }
                );

                expected.Add(
                    809976934,
                    new NpgsqlLineline0MI
                    {
                        Id = 809976934,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9182048348229805d, b: 0.32929148963623245d, c: 0.2257168493840398d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.23102935095935362d, b: 0.1385093451975693d, c: 0.4964693233672345d)
                    }
                );

                expected.Add(
                    824117470,
                    new NpgsqlLineline0MI
                    {
                        Id = 824117470,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.33667229345547856d, b: 0.7312185922140685d, c: 0.37540490571212715d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1114445123,
                    new NpgsqlLineline0MI
                    {
                        Id = 1114445123,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.20691849388645178d, b: 0.1654155028677684d, c: 0.8421929724014293d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1466217598,
                    new NpgsqlLineline0MI
                    {
                        Id = 1466217598,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9784536551479048d, b: 0.026240203196344347d, c: 0.5714443667381381d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1551362529,
                    new NpgsqlLineline0MI
                    {
                        Id = 1551362529,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.9584453147825421d, b: 0.30853751622186154d, c: 0.6237898382046388d),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1608904622,
                    new NpgsqlLineline0MI
                    {
                        Id = 1608904622,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.7539842256245562d, b: 0.8787708411254436d, c: 0.8763610829137224d),
                        NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8302787731561811d, b: 0.8950341966846347d, c: 0.19231541316906553d)
                    }
                );

                expected.Add(
                    1688554763,
                    new NpgsqlLineline0MI
                    {
                        Id = 1688554763,
                        Value = new NpgsqlTypes.NpgsqlLine(a: 0.8387517166914016d, b: 0.11072116558412559d, c: 0.3591801826401744d),
                        NullableValue = null
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

