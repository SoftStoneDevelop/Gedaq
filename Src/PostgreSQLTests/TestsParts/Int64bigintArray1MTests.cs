

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 4,
    Value = 
new System.Int64[3]
{
443163830825564453L,
8058786040730978976L,
8333457954617588087L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3378423965859774952L,
6871516786564321881L,
5968365276137095265L,
268565496932423984L,
},
},
            new Int64bigintArray1M
{
    Id = 6,
    Value = 
new System.Int64[3]
{
2429786939104936787L,
8583109627868180862L,
2664767198696231620L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 4,
    Value = 
new System.Int64[3]
{
1119222738798996302L,
140788193545355608L,
6843957045271506882L,
},
    NullableValue = 
new System.Int64[4]
{
704594241579078245L,
4683665625539931101L,
6886001354806243384L,
1753330913995291584L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
3764840877095264720L,
5790067672068039896L,
103486025791339163L,
6450975702530641557L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 11,
    Value = 
new System.Int64[4]
{
3824932116805761468L,
6696984499285220601L,
113639207864570562L,
4897127419675867711L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 12,
    Value = 
new System.Int64[4]
{
2428902077872514149L,
3856712977779457534L,
1970315225848071129L,
7482045719791356242L,
},
    NullableValue = 
new System.Int64[3]
{
6248075843739847436L,
4225588377582220888L,
1803057046517200551L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 18,
    Value = 
new System.Int64[3]
{
6449996486950920731L,
5603929912891216674L,
3677195960407299164L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 24,
    Value = 
new System.Int64[3]
{
3166499664386757652L,
7692774429000459492L,
9128330794900915429L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 19,
    Value = 
new System.Int64[3]
{
1934684577481912980L,
1012267439370754313L,
2169127308134448277L,
},
    NullableValue = 
new System.Int64[3]
{
8221088425607617032L,
8037517631618839451L,
4585206746064134831L,
},
},
    NullableValue = 
new System.Int64[3]
{
5712062165179204654L,
3487286594564946675L,
1992254630875708502L,
},
},
            new Int64bigintArray1M
{
    Id = 27,
    Value = 
new System.Int64[4]
{
8598431504315980244L,
3975556894062601194L,
681220972121063583L,
7229404800410000507L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 31,
    Value = 
new System.Int64[3]
{
556676745507805105L,
2960085352419522272L,
3085714212816022915L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 21,
    Value = 
new System.Int64[4]
{
3291392842367173723L,
4162064222871577726L,
4501280546920725766L,
7247042999403193637L,
},
    NullableValue = 
new System.Int64[3]
{
6502173739901812986L,
5171446859864176718L,
4585197666756057332L,
},
},
    NullableValue = 
new System.Int64[4]
{
5118096789059701097L,
1907584742970591220L,
8623246426792987420L,
2276149440707637033L,
},
},
            new Int64bigintArray1M
{
    Id = 34,
    Value = 
new System.Int64[4]
{
5582299336694908558L,
222339189852207345L,
1134900498966910726L,
5375093483294167791L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1682026623936164307L,
590257598061276487L,
8531367443588033698L,
1704906875246662833L,
},
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[4]
{
4094703915238624159L,
4891642912731472609L,
7014233258817140986L,
7182771322980031857L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 25,
    Value = 
new System.Int64[4]
{
882232739535003119L,
1242590311609409365L,
8220737222169160233L,
5648313965915090885L,
},
    NullableValue = 
new System.Int64[4]
{
6328489293557326454L,
2865678823641352695L,
8921086534416827477L,
3737073296876776575L,
},
},
    NullableValue = 
new System.Int64[3]
{
6844697393310754107L,
1866544557328618378L,
6115668200655243773L,
},
},
            new Int64bigintArray1M
{
    Id = 45,
    Value = 
new System.Int64[4]
{
5670815543472695746L,
5183260977039328829L,
8770337536950561270L,
4389837660870728347L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 49,
    Value = 
new System.Int64[3]
{
4263459377102517201L,
2586443672979044191L,
8408784229628662838L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
1350848422697435953L,
8864229293604469427L,
6789227429645862756L,
1303317286059059541L,
},
    NullableValue = 
new System.Int64[3]
{
9055360818991844057L,
7987449898796506764L,
4578948730144397635L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 53,
    Value = 
new System.Int64[4]
{
7465824522587995705L,
5220984077964246235L,
7543383445722317140L,
5318225103968767495L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 60,
    Value = 
new System.Int64[3]
{
5474034607157733816L,
517985260041049579L,
7787308507363862692L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 40,
    Value = 
new System.Int64[3]
{
2189129015107793904L,
6302291793513950022L,
6123234328591834319L,
},
    NullableValue = 
new System.Int64[3]
{
4958171899638110157L,
1186034195427953319L,
4267468993615562398L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 62,
    Value = 
new System.Int64[4]
{
2396562163272378611L,
5375037982333346467L,
4380572496452586551L,
6011848296918613916L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8587814815364933076L,
6195901803880163545L,
1931826923699054412L,
194886609878715388L,
},
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[4]
{
1758392020970137821L,
7785778546500336609L,
4558384817922075099L,
1133101115831682535L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 45,
    Value = 
new System.Int64[3]
{
5825224487626222377L,
152948178963134095L,
5260898475324348047L,
},
    NullableValue = 
new System.Int64[3]
{
4792495929882852304L,
4275225193459458219L,
3794491709605387690L,
},
},
    NullableValue = 
new System.Int64[3]
{
6826365643575694921L,
6561333443169395190L,
5375030000003243588L,
},
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[4]
{
5890070751730091128L,
1660855453510183656L,
7887951455213483650L,
6563877110276024554L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 80,
    Value = 
new System.Int64[4]
{
9182787866949854268L,
5150674131295367761L,
8807676483216198143L,
8548309767140821012L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 47,
    Value = 
new System.Int64[4]
{
1722448121070131550L,
2213812806045230833L,
6969302864835398305L,
1540208048755556676L,
},
    NullableValue = 
new System.Int64[3]
{
5721256397224054393L,
2566570651190322821L,
3492316240852306758L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
7698264105463862130L,
2533465618620736808L,
2593413526759949789L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
9156000035723646337L,
8366581740246401289L,
5220398894021744975L,
},
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[4]
{
3941751782770385918L,
849321807075679449L,
7727862073491292186L,
2319057029540404745L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[3]
{
887749672228624037L,
7243653799372167435L,
4904741726723564331L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
4955788683561544259L,
4715753509518686266L,
7522651099757088510L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 104,
    Value = 
new System.Int64[3]
{
7469001709183280093L,
8207728506655219339L,
8125900385197413157L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
899093754941122637L,
2390383057019878442L,
4345916426796856664L,
485778643780290406L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 107,
    Value = 
new System.Int64[4]
{
9219372477653053561L,
3836355163445129846L,
4549160915500869570L,
8809213089414544195L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 110,
    Value = 
new System.Int64[3]
{
627967966877009336L,
4746082287544234172L,
5502538080279725L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 66,
    Value = 
new System.Int64[3]
{
7594863160626929601L,
3950486798087697970L,
8027864377843563040L,
},
    NullableValue = 
new System.Int64[3]
{
1068402808286644187L,
2378143671867633640L,
7392250436510461438L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 115,
    Value = 
new System.Int64[3]
{
964545696231488180L,
4249228859393778115L,
2426454312729812181L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7752123191845745259L,
3270647374239314187L,
840851236849630328L,
},
},
            new Int64bigintArray1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
5198722288511819981L,
6464703909380481440L,
711639502492526082L,
9016952020307526503L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 69,
    Value = 
new System.Int64[4]
{
1300305390267475374L,
7207495439634376602L,
89056839775890813L,
77844240680883537L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4749908756294307960L,
277619422897091009L,
4426535730738462778L,
8612685980172393854L,
},
},
            new Int64bigintArray1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
8443192991830027490L,
2881930586014171695L,
2323147823909293524L,
5633390944945432360L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8475110759416081795L,
5146428499526405656L,
8606914052411725894L,
},
},
            new Int64bigintArray1M
{
    Id = 125,
    Value = 
new System.Int64[3]
{
4475227094716639343L,
1767782488589755439L,
5267048908935312011L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 75,
    Value = 
new System.Int64[4]
{
4809672422403523883L,
3144351540093537438L,
7382400097085069626L,
8722639315229167877L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3236046805937878819L,
4061989380692033594L,
3188205342734563427L,
3632136765327206092L,
},
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[4]
{
710706383622278219L,
5668531227477109530L,
3819849413053712060L,
1444189703178005035L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6585933610986963610L,
6405318973545711371L,
7261337217899971514L,
},
},
            new Int64bigintArray1M
{
    Id = 136,
    Value = 
new System.Int64[4]
{
5595690208806324000L,
397725273769280109L,
6272976347390450787L,
7577494308706151911L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 84,
    Value = 
new System.Int64[3]
{
6523577441277400115L,
9094119169696926696L,
8709363191294961790L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5282538993552456186L,
421585323356845319L,
391121635710962294L,
},
},
            new Int64bigintArray1M
{
    Id = 140,
    Value = 
new System.Int64[3]
{
4249222524667781926L,
878557066412044467L,
1021934472543857540L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 145,
    Value = 
new System.Int64[4]
{
5804478903913114773L,
5675435752779780059L,
800670093793021504L,
9191096860386184335L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 89,
    Value = 
new System.Int64[3]
{
2600739126122072803L,
9155377154025999391L,
2314176625326707227L,
},
    NullableValue = 
new System.Int64[3]
{
6013283226744824755L,
4261157402880508082L,
7188576249360711907L,
},
},
    NullableValue = 
new System.Int64[3]
{
6769069787278418024L,
7625787749957426318L,
643562685402130743L,
},
},
            new Int64bigintArray1M
{
    Id = 147,
    Value = 
new System.Int64[3]
{
3189684645513304984L,
8267941838179020637L,
462793571098067353L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3542987324205198986L,
459668667324317297L,
696412941732883607L,
},
},
            new Int64bigintArray1M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
2131469310052518526L,
4962326599941708391L,
1767410111931374819L,
2525016831650363327L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 90,
    Value = 
new System.Int64[3]
{
5016843341599690877L,
2637110075870041746L,
4938404616236995222L,
},
    NullableValue = 
new System.Int64[3]
{
7694996516375728239L,
5316636821798388921L,
4677619128105581407L,
},
},
    NullableValue = 
new System.Int64[3]
{
6661301547102992360L,
8468683466634666486L,
1190357478145207957L,
},
},
            new Int64bigintArray1M
{
    Id = 158,
    Value = 
new System.Int64[3]
{
3557913718962852466L,
6415718945428299375L,
7912935045681080286L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5712062165179204654L,
3487286594564946675L,
1992254630875708502L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
5118096789059701097L,
1907584742970591220L,
8623246426792987420L,
2276149440707637033L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
1682026623936164307L,
590257598061276487L,
8531367443588033698L,
1704906875246662833L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6844697393310754107L,
1866544557328618378L,
6115668200655243773L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 69, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 42, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintArray1M.AssertModel(models[0],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 122, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int64bigintArray1M.AssertModel(models[0],_testData[10], false);Int64bigintArray1M.AssertModel(models[1],_testData[11], false);Int64bigintArray1M.AssertModel(models[2],_testData[12], false);Int64bigintArray1M.AssertModel(models[3],_testData[13], false);Int64bigintArray1M.AssertModel(models[4],_testData[14], false);Int64bigintArray1M.AssertModel(models[5],_testData[15], false);Int64bigintArray1M.AssertModel(models[6],_testData[16], false);Int64bigintArray1M.AssertModel(models[7],_testData[17], false);Int64bigintArray1M.AssertModel(models[8],_testData[18], false);Int64bigintArray1M.AssertModel(models[9],_testData[19], false);Int64bigintArray1M.AssertModel(models[10],_testData[20], false);Int64bigintArray1M.AssertModel(models[11],_testData[21], false);Int64bigintArray1M.AssertModel(models[12],_testData[22], false);Int64bigintArray1M.AssertModel(models[13],_testData[23], false);Int64bigintArray1M.AssertModel(models[14],_testData[24], false);Int64bigintArray1M.AssertModel(models[15],_testData[25], false);Int64bigintArray1M.AssertModel(models[16],_testData[26], false);Int64bigintArray1M.AssertModel(models[17],_testData[27], false);Int64bigintArray1M.AssertModel(models[18],_testData[28], false);Int64bigintArray1M.AssertModel(models[19],_testData[29], false);Int64bigintArray1M.AssertModel(models[20],_testData[30], false);Int64bigintArray1M.AssertModel(models[21],_testData[31], false);Int64bigintArray1M.AssertModel(models[22],_testData[32], false);Int64bigintArray1M.AssertModel(models[23],_testData[33], false);Int64bigintArray1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int64bigintArray1M.AssertModel(models[0],_testData[26], false);Int64bigintArray1M.AssertModel(models[1],_testData[27], false);Int64bigintArray1M.AssertModel(models[2],_testData[28], false);Int64bigintArray1M.AssertModel(models[3],_testData[29], false);Int64bigintArray1M.AssertModel(models[4],_testData[30], false);Int64bigintArray1M.AssertModel(models[5],_testData[31], false);Int64bigintArray1M.AssertModel(models[6],_testData[32], false);Int64bigintArray1M.AssertModel(models[7],_testData[33], false);Int64bigintArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

