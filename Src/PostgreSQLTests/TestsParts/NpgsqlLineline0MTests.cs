

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


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14705150914353926d, b: 0.563423300515782d, c: 0.6776465599216515d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8287643626291225d, b: 0.2629688022933977d, c: 0.8489766872742179d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2897221089307648d, b: 0.5303587056649152d, c: 0.9059597457884209d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7630075130906814d, b: 0.13845164899650164d, c: 0.6243704301004811d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.06140922852474362d, b: 0.5225068016299749d, c: 0.9683482105957051d),
},
            new NpgsqlLineline0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07061689325062726d, b: 0.0531511359331891d, c: 0.3859777902337812d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6586946859851821d, b: 0.733600995444604d, c: 0.5069799091598172d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6223804840907012d, b: 0.5100204253837285d, c: 0.6760241502535075d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4505721698439543d, b: 0.11554109956929026d, c: 0.33550485940000063d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8272438971926565d, b: 0.9961106340216312d, c: 0.774647894333692d),
},
            new NpgsqlLineline0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47652240492431963d, b: 0.48752843751221653d, c: 0.03339289885977903d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2184539643802722d, b: 0.10971234563694021d, c: 0.4541291561974742d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05856359896698038d, b: 0.40097797398745705d, c: 0.28415943604168825d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8249669637751833d, b: 0.02211394930495625d, c: 0.8699411421823542d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8306470158250717d, b: 0.32259116388811204d, c: 0.8829440061812044d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04287224866329298d, b: 0.5215527105910597d, c: 0.9173102210795326d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4332132830141959d, b: 0.9612199418494503d, c: 0.13698665837906077d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1370567556611152d, b: 0.3947504022477062d, c: 0.08000524433757383d),
},
            new NpgsqlLineline0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3896856120379052d, b: 0.9567842025171722d, c: 0.43634176128121516d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6293471902889866d, b: 0.43034648338972525d, c: 0.12308028271120819d),
},
            new NpgsqlLineline0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8560609808966568d, b: 0.9096087589014251d, c: 0.2712414819389519d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7213305381854845d, b: 0.9042714429854551d, c: 0.28069264986223774d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6118149228517163d, b: 0.4846010139315642d, c: 0.5038055370288649d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45828053230360044d, b: 0.09740395546760783d, c: 0.14471761268491767d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6307156594977602d, b: 0.0017487873154081734d, c: 0.10241533775120559d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9543686346312786d, b: 0.9655592693045211d, c: 0.5516378458222095d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27307224314012446d, b: 0.6974610634139043d, c: 0.7658269567680615d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8617166503713188d, b: 0.07939455907874093d, c: 0.3987669551622556d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.33591783339823456d, b: 0.6179666960422167d, c: 0.18679904524356428d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.584127888274325d, b: 0.2439105998322677d, c: 0.6359945445326924d),
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43556927751332386d, b: 0.30331915475401006d, c: 0.3134586851221913d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9756808893496841d, b: 0.8460071948091389d, c: 0.7987411511535705d),
},
            new NpgsqlLineline0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5662234239245837d, b: 0.9198850447832742d, c: 0.6250609230281866d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10383115005652543d, b: 0.5462613670497071d, c: 0.5439017193195665d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9159792590838306d, b: 0.017167440279248436d, c: 0.7329746753358829d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.59560104474551d, b: 0.8318076571268133d, c: 0.6914683456906342d),
},
            new NpgsqlLineline0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5243453972646938d, b: 0.14934631418536937d, c: 0.6148000476577726d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7648377993825629d, b: 0.9205459447158469d, c: 0.9601376943353598d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19499153985852324d, b: 0.286571350774925d, c: 0.473191634383443d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1291922165122832d, b: 0.3258951211391313d, c: 0.08208033264012693d),
},
            new NpgsqlLineline0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.22100133650533038d, b: 0.7006171865975772d, c: 0.4728963607984601d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6180377053392098d, b: 0.3646886621938278d, c: 0.24749241492684082d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5464711826175279d, b: 0.27399760426001696d, c: 0.6919446507601086d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2353162392381214d, b: 0.6950911288787446d, c: 0.2556142152943077d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4425747970686351d, b: 0.17125514569502198d, c: 0.5493628630526769d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.702652952267465d, b: 0.5234025981146129d, c: 0.552442412320746d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6386726655028331d, b: 0.3186451048276243d, c: 0.098283069468732d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40378217410026285d, b: 0.92711768256522d, c: 0.6764254788781987d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8361557935920193d, b: 0.01783945528609021d, c: 0.1433559580249032d),
},
            new NpgsqlLineline0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5245099762745074d, b: 0.09602557431748371d, c: 0.9398640486507424d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9871859508731744d, b: 0.4277674625995238d, c: 0.5079254526443227d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.00814067787798356d, b: 0.46300202918459543d, c: 0.8673519852616087d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6121112047300052d, b: 0.41591375681550646d, c: 0.6254507049018222d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.13545674589027412d, b: 0.09767993392167895d, c: 0.831288453924353d),
},
            new NpgsqlLineline0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6088942999346241d, b: 0.0029626775957724005d, c: 0.7113254711069569d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9045972254866878d, b: 0.9316415988661036d, c: 0.09998974601429433d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4371110719440039d, b: 0.3111607644790828d, c: 0.802063026364394d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6348479886032965d, b: 0.3360665587341992d, c: 0.03214964286404953d),
},
            new NpgsqlLineline0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07351447551627543d, b: 0.5649750393731662d, c: 0.5181797095890261d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8233986156926447d, b: 0.39603211851320574d, c: 0.3478642570071506d),
},
            new NpgsqlLineline0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8225467828343178d, b: 0.8503285469141675d, c: 0.1764105731869291d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03888739421960463d, b: 0.4736051505285941d, c: 0.5910656657725876d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3258185243122431d, b: 0.6770703392981693d, c: 0.43567468951696187d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2505092510887662d, b: 0.5513934254062252d, c: 0.997682214220575d),
},
            new NpgsqlLineline0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47752613573464464d, b: 0.9672504546360335d, c: 0.22698267531055671d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.26851111278425477d, b: 0.07091088269108359d, c: 0.048632412488115784d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5884568435168914d, b: 0.8033354638926412d, c: 0.33050517668351664d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8045613551551053d, b: 0.7853425032348009d, c: 0.5576267858700829d),
},
        };

#endregion

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
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
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8272438971926565d, b: 0.9961106340216312d, c: 0.774647894333692d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.1370567556611152d, b: 0.3947504022477062d, c: 0.08000524433757383d)));
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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6293471902889866d, b: 0.43034648338972525d, c: 0.12308028271120819d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
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
            queryMapTypes: null,
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
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[29], false);
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
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 77, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[29], false);
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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 47, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLineline0M.AssertModel(models[0],_testData[14], false);NpgsqlLineline0M.AssertModel(models[1],_testData[15], false);NpgsqlLineline0M.AssertModel(models[2],_testData[16], false);NpgsqlLineline0M.AssertModel(models[3],_testData[17], false);NpgsqlLineline0M.AssertModel(models[4],_testData[18], false);NpgsqlLineline0M.AssertModel(models[5],_testData[19], false);NpgsqlLineline0M.AssertModel(models[6],_testData[20], false);NpgsqlLineline0M.AssertModel(models[7],_testData[21], false);NpgsqlLineline0M.AssertModel(models[8],_testData[22], false);NpgsqlLineline0M.AssertModel(models[9],_testData[23], false);NpgsqlLineline0M.AssertModel(models[10],_testData[24], false);NpgsqlLineline0M.AssertModel(models[11],_testData[25], false);NpgsqlLineline0M.AssertModel(models[12],_testData[26], false);NpgsqlLineline0M.AssertModel(models[13],_testData[27], false);NpgsqlLineline0M.AssertModel(models[14],_testData[28], false);NpgsqlLineline0M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
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
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14705150914353926d, b: 0.563423300515782d, c: 0.6776465599216515d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8287643626291225d, b: 0.2629688022933977d, c: 0.8489766872742179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2897221089307648d, b: 0.5303587056649152d, c: 0.9059597457884209d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7630075130906814d, b: 0.13845164899650164d, c: 0.6243704301004811d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06140922852474362d, b: 0.5225068016299749d, c: 0.9683482105957051d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07061689325062726d, b: 0.0531511359331891d, c: 0.3859777902337812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6586946859851821d, b: 0.733600995444604d, c: 0.5069799091598172d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6223804840907012d, b: 0.5100204253837285d, c: 0.6760241502535075d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4505721698439543d, b: 0.11554109956929026d, c: 0.33550485940000063d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8272438971926565d, b: 0.9961106340216312d, c: 0.774647894333692d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47652240492431963d, b: 0.48752843751221653d, c: 0.03339289885977903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2184539643802722d, b: 0.10971234563694021d, c: 0.4541291561974742d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05856359896698038d, b: 0.40097797398745705d, c: 0.28415943604168825d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8249669637751833d, b: 0.02211394930495625d, c: 0.8699411421823542d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8306470158250717d, b: 0.32259116388811204d, c: 0.8829440061812044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04287224866329298d, b: 0.5215527105910597d, c: 0.9173102210795326d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4332132830141959d, b: 0.9612199418494503d, c: 0.13698665837906077d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1370567556611152d, b: 0.3947504022477062d, c: 0.08000524433757383d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3896856120379052d, b: 0.9567842025171722d, c: 0.43634176128121516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6293471902889866d, b: 0.43034648338972525d, c: 0.12308028271120819d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8560609808966568d, b: 0.9096087589014251d, c: 0.2712414819389519d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7213305381854845d, b: 0.9042714429854551d, c: 0.28069264986223774d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6118149228517163d, b: 0.4846010139315642d, c: 0.5038055370288649d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45828053230360044d, b: 0.09740395546760783d, c: 0.14471761268491767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6307156594977602d, b: 0.0017487873154081734d, c: 0.10241533775120559d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9543686346312786d, b: 0.9655592693045211d, c: 0.5516378458222095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27307224314012446d, b: 0.6974610634139043d, c: 0.7658269567680615d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8617166503713188d, b: 0.07939455907874093d, c: 0.3987669551622556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33591783339823456d, b: 0.6179666960422167d, c: 0.18679904524356428d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.584127888274325d, b: 0.2439105998322677d, c: 0.6359945445326924d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43556927751332386d, b: 0.30331915475401006d, c: 0.3134586851221913d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9756808893496841d, b: 0.8460071948091389d, c: 0.7987411511535705d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5662234239245837d, b: 0.9198850447832742d, c: 0.6250609230281866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10383115005652543d, b: 0.5462613670497071d, c: 0.5439017193195665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9159792590838306d, b: 0.017167440279248436d, c: 0.7329746753358829d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.59560104474551d, b: 0.8318076571268133d, c: 0.6914683456906342d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5243453972646938d, b: 0.14934631418536937d, c: 0.6148000476577726d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7648377993825629d, b: 0.9205459447158469d, c: 0.9601376943353598d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19499153985852324d, b: 0.286571350774925d, c: 0.473191634383443d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1291922165122832d, b: 0.3258951211391313d, c: 0.08208033264012693d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22100133650533038d, b: 0.7006171865975772d, c: 0.4728963607984601d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180377053392098d, b: 0.3646886621938278d, c: 0.24749241492684082d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5464711826175279d, b: 0.27399760426001696d, c: 0.6919446507601086d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2353162392381214d, b: 0.6950911288787446d, c: 0.2556142152943077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4425747970686351d, b: 0.17125514569502198d, c: 0.5493628630526769d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.702652952267465d, b: 0.5234025981146129d, c: 0.552442412320746d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6386726655028331d, b: 0.3186451048276243d, c: 0.098283069468732d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40378217410026285d, b: 0.92711768256522d, c: 0.6764254788781987d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8361557935920193d, b: 0.01783945528609021d, c: 0.1433559580249032d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5245099762745074d, b: 0.09602557431748371d, c: 0.9398640486507424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9871859508731744d, b: 0.4277674625995238d, c: 0.5079254526443227d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00814067787798356d, b: 0.46300202918459543d, c: 0.8673519852616087d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6121112047300052d, b: 0.41591375681550646d, c: 0.6254507049018222d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13545674589027412d, b: 0.09767993392167895d, c: 0.831288453924353d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6088942999346241d, b: 0.0029626775957724005d, c: 0.7113254711069569d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9045972254866878d, b: 0.9316415988661036d, c: 0.09998974601429433d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4371110719440039d, b: 0.3111607644790828d, c: 0.802063026364394d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6348479886032965d, b: 0.3360665587341992d, c: 0.03214964286404953d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07351447551627543d, b: 0.5649750393731662d, c: 0.5181797095890261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8233986156926447d, b: 0.39603211851320574d, c: 0.3478642570071506d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8225467828343178d, b: 0.8503285469141675d, c: 0.1764105731869291d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03888739421960463d, b: 0.4736051505285941d, c: 0.5910656657725876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3258185243122431d, b: 0.6770703392981693d, c: 0.43567468951696187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2505092510887662d, b: 0.5513934254062252d, c: 0.997682214220575d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47752613573464464d, b: 0.9672504546360335d, c: 0.22698267531055671d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26851111278425477d, b: 0.07091088269108359d, c: 0.048632412488115784d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5884568435168914d, b: 0.8033354638926412d, c: 0.33050517668351664d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8045613551551053d, b: 0.7853425032348009d, c: 0.5576267858700829d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14705150914353926d, b: 0.563423300515782d, c: 0.6776465599216515d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8287643626291225d, b: 0.2629688022933977d, c: 0.8489766872742179d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2897221089307648d, b: 0.5303587056649152d, c: 0.9059597457884209d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7630075130906814d, b: 0.13845164899650164d, c: 0.6243704301004811d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06140922852474362d, b: 0.5225068016299749d, c: 0.9683482105957051d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07061689325062726d, b: 0.0531511359331891d, c: 0.3859777902337812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6586946859851821d, b: 0.733600995444604d, c: 0.5069799091598172d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6223804840907012d, b: 0.5100204253837285d, c: 0.6760241502535075d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4505721698439543d, b: 0.11554109956929026d, c: 0.33550485940000063d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8272438971926565d, b: 0.9961106340216312d, c: 0.774647894333692d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47652240492431963d, b: 0.48752843751221653d, c: 0.03339289885977903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2184539643802722d, b: 0.10971234563694021d, c: 0.4541291561974742d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05856359896698038d, b: 0.40097797398745705d, c: 0.28415943604168825d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8249669637751833d, b: 0.02211394930495625d, c: 0.8699411421823542d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8306470158250717d, b: 0.32259116388811204d, c: 0.8829440061812044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04287224866329298d, b: 0.5215527105910597d, c: 0.9173102210795326d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4332132830141959d, b: 0.9612199418494503d, c: 0.13698665837906077d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1370567556611152d, b: 0.3947504022477062d, c: 0.08000524433757383d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3896856120379052d, b: 0.9567842025171722d, c: 0.43634176128121516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6293471902889866d, b: 0.43034648338972525d, c: 0.12308028271120819d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8560609808966568d, b: 0.9096087589014251d, c: 0.2712414819389519d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7213305381854845d, b: 0.9042714429854551d, c: 0.28069264986223774d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6118149228517163d, b: 0.4846010139315642d, c: 0.5038055370288649d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45828053230360044d, b: 0.09740395546760783d, c: 0.14471761268491767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6307156594977602d, b: 0.0017487873154081734d, c: 0.10241533775120559d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9543686346312786d, b: 0.9655592693045211d, c: 0.5516378458222095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27307224314012446d, b: 0.6974610634139043d, c: 0.7658269567680615d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8617166503713188d, b: 0.07939455907874093d, c: 0.3987669551622556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33591783339823456d, b: 0.6179666960422167d, c: 0.18679904524356428d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.584127888274325d, b: 0.2439105998322677d, c: 0.6359945445326924d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43556927751332386d, b: 0.30331915475401006d, c: 0.3134586851221913d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9756808893496841d, b: 0.8460071948091389d, c: 0.7987411511535705d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5662234239245837d, b: 0.9198850447832742d, c: 0.6250609230281866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10383115005652543d, b: 0.5462613670497071d, c: 0.5439017193195665d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9159792590838306d, b: 0.017167440279248436d, c: 0.7329746753358829d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.59560104474551d, b: 0.8318076571268133d, c: 0.6914683456906342d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5243453972646938d, b: 0.14934631418536937d, c: 0.6148000476577726d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7648377993825629d, b: 0.9205459447158469d, c: 0.9601376943353598d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19499153985852324d, b: 0.286571350774925d, c: 0.473191634383443d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1291922165122832d, b: 0.3258951211391313d, c: 0.08208033264012693d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.22100133650533038d, b: 0.7006171865975772d, c: 0.4728963607984601d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6180377053392098d, b: 0.3646886621938278d, c: 0.24749241492684082d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5464711826175279d, b: 0.27399760426001696d, c: 0.6919446507601086d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2353162392381214d, b: 0.6950911288787446d, c: 0.2556142152943077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4425747970686351d, b: 0.17125514569502198d, c: 0.5493628630526769d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.702652952267465d, b: 0.5234025981146129d, c: 0.552442412320746d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6386726655028331d, b: 0.3186451048276243d, c: 0.098283069468732d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40378217410026285d, b: 0.92711768256522d, c: 0.6764254788781987d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8361557935920193d, b: 0.01783945528609021d, c: 0.1433559580249032d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5245099762745074d, b: 0.09602557431748371d, c: 0.9398640486507424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9871859508731744d, b: 0.4277674625995238d, c: 0.5079254526443227d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00814067787798356d, b: 0.46300202918459543d, c: 0.8673519852616087d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6121112047300052d, b: 0.41591375681550646d, c: 0.6254507049018222d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13545674589027412d, b: 0.09767993392167895d, c: 0.831288453924353d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6088942999346241d, b: 0.0029626775957724005d, c: 0.7113254711069569d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9045972254866878d, b: 0.9316415988661036d, c: 0.09998974601429433d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4371110719440039d, b: 0.3111607644790828d, c: 0.802063026364394d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6348479886032965d, b: 0.3360665587341992d, c: 0.03214964286404953d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07351447551627543d, b: 0.5649750393731662d, c: 0.5181797095890261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8233986156926447d, b: 0.39603211851320574d, c: 0.3478642570071506d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8225467828343178d, b: 0.8503285469141675d, c: 0.1764105731869291d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03888739421960463d, b: 0.4736051505285941d, c: 0.5910656657725876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3258185243122431d, b: 0.6770703392981693d, c: 0.43567468951696187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2505092510887662d, b: 0.5513934254062252d, c: 0.997682214220575d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47752613573464464d, b: 0.9672504546360335d, c: 0.22698267531055671d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26851111278425477d, b: 0.07091088269108359d, c: 0.048632412488115784d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5884568435168914d, b: 0.8033354638926412d, c: 0.33050517668351664d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8045613551551053d, b: 0.7853425032348009d, c: 0.5576267858700829d))));

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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[27],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[28],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[29],_testData[29], false);
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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

