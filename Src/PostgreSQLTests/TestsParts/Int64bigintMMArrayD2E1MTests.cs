

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
    internal partial interface IInt64MArraybigintMMArrayD2
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD2 : IInt64MArraybigintMMArrayD2
    {


#region TestData

        private readonly Int64bigintMMArrayD2E1M[] _testData = new Int64bigintMMArrayD2E1M[]
        {
            new Int64bigintMMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Int64[,] { { 4878804034064138371L, 8692182178007380306L, }, { 778857258850252379L, 6242078449186871594L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6898329273651653367L, 2419500350368453167L, }, { 481267642598350251L, 874310431668822821L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Int64[,] { { 8485286253500998124L, 3417669057752101946L, }, { 6357399393090636863L, 138089159806178004L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int64[,] { { 3503803802624263934L, 2248604042598767930L, }, { 3201887281524701516L, 4907259141559829761L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5830634788775794499L, 1210920975993164418L, }, { 2879169169386120399L, 2830011816916039180L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int64[,] { { 5721393358856366378L, 2561213702498048494L, }, { 6593207620050902736L, 3459750816016359058L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int64[,] { { 3600159464711213744L, 3743450623077503214L, }, { 999968577199899682L, 2452273868632033197L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int64[,] { { 3615053664111295586L, 4936183811159749864L, }, { 2769939129397556026L, 7942172306354527801L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Int64[,] { { 8423167965500295355L, 4140872150360788756L, }, { 5599980490598826357L, 5478157847423047522L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int64[,] { { 3298160887199905121L, 1030072342873929349L, }, { 7791771175867280979L, 861799826204299363L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Int64[,] { { 6178527042273768724L, 1525150443632559950L, }, { 9016109060728076992L, 5645614365553052742L, }, },
    NullableValue = 
new System.Int64[,] { { 4343989675269435473L, 7528119513850281588L, }, { 286920231168224655L, 6479765578489850651L, }, },
},
    NullableValue = 
new System.Int64[,] { { 14520427701865983L, 1705838287931525297L, }, { 2620456197616675012L, 4605469023568051299L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int64[,] { { 2315587890533185140L, 8867319695491546367L, }, { 751532946476254837L, 5282221520948551096L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2153171229228924068L, 6117155683516921414L, }, { 6296460516783583004L, 3810812666519102939L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int64[,] { { 3491329104068648295L, 4314887161347336402L, }, { 2557739551263347718L, 2710492464541617092L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int64[,] { { 8375049933105599319L, 8242637399323673377L, }, { 3111580613359753511L, 5388833060030717190L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int64[,] { { 5638503021366622670L, 7206569636981015457L, }, { 5486219767691629271L, 5463710192996354940L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int64[,] { { 7575964977613151174L, 3960087521240573687L, }, { 8074792823067341652L, 3546886406858398979L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int64[,] { { 6653119246953634491L, 1367418838584784809L, }, { 5274172067935981574L, 6071927343413184651L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6686933445343242978L, 128862178340585270L, }, { 3798732953212840964L, 7040055914252607000L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int64[,] { { 3271319420785883074L, 8979696592318946611L, }, { 3853232111155038955L, 4792028790677385087L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Int64[,] { { 357829132798009702L, 9063994166557146153L, }, { 3769713122347273475L, 4101683838405706436L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int64[,] { { 873011687836801011L, 4670276163181894110L, }, { 8019737488509848785L, 7606551040808149119L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3921243280434125536L, 3059958233135149332L, }, { 8043118856036563882L, 742113673135703230L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Int64[,] { { 5996983013596473130L, 2786884527513784316L, }, { 3334038003813494333L, 108734942325129287L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Int64[,] { { 7813710317330918413L, 5888519040673487657L, }, { 6398524608702174446L, 4487373012925514791L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 9080798873603581080L, 3966110657567961140L, }, { 1668719994690886411L, 7177632249663850795L, }, },
    NullableValue = 
new System.Int64[,] { { 1542271502813578063L, 9010779631125435673L, }, { 3594785296908871741L, 9092538890607396347L, }, },
},
    NullableValue = 
new System.Int64[,] { { 228689402788037921L, 7293347432468237114L, }, { 1531423865394263484L, 3170938656391590290L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { { 4620451691394974900L, 4304601791776880850L, }, { 7526500939593493108L, 2962420873703623964L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int64[,] { { 9061672125078957257L, 5414216113789405660L, }, { 8486240723188465837L, 1114624116060208871L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int64[,] { { 8640340375281446777L, 8887064085716767353L, }, { 6043881775569432491L, 2026890794099283186L, }, },
    NullableValue = 
new System.Int64[,] { { 7796108048317068534L, 2791187190782500200L, }, { 7349837920864517995L, 5944791389602043229L, }, },
},
    NullableValue = 
new System.Int64[,] { { 1898195325913089384L, 6560093361236409806L, }, { 6608149109349952359L, 1994624879671095900L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int64[,] { { 6123226620731859216L, 5506673618729676444L, }, { 6104402397239767957L, 661873992944991052L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7557695719402191317L, 218817500338083434L, }, { 8217849809884141827L, 3207077753641606279L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int64[,] { { 1209714642989674978L, 7703022876208642533L, }, { 5934908880586878329L, 8788847389698161744L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int64[,] { { 7535873894624987196L, 4745303366599312741L, }, { 6921845092473007996L, 4876345593251935949L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int64[,] { { 2909428616087758132L, 9071899774516859660L, }, { 6782738266098231333L, 4485124109128985380L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Int64[,] { { 870026109565221985L, 3980301938134267758L, }, { 5191813732738927441L, 3336565451421258726L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { { 2190015477063103243L, 4467773911688298130L, }, { 4385673591362589003L, 2613298240200767303L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int64[,] { { 218849709830610939L, 6126731355285650439L, }, { 1354178776706113442L, 683887961534907542L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int64[,] { { 541928566625862472L, 1215719550097133895L, }, { 4951711694467255464L, 1538277849064135688L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int64[,] { { 3939212295338528923L, 4006983949636866818L, }, { 2644451931965462762L, 5900480843438940941L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8022094943028466200L, 3174408411833771563L, }, { 9021734573290804207L, 5490103169291475083L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int64[,] { { 5595260184236615904L, 5009367355248415557L, }, { 8331568567095692389L, 6695269768606339372L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Int64[,] { { 2089556692381813865L, 7186609763356447537L, }, { 8883530036799869748L, 6534205624939509953L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 3485369237883600663L, 7932421803760000193L, }, { 2005740976045374322L, 6933298700639690115L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Int64[,] { { 8753330553870860473L, 4519705500018475300L, }, { 2299056983730012711L, 6625235190205708069L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 1818629336220561753L, 5992185508146239108L, }, { 5438170500870200180L, 7149053120060884749L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int64[,] { { 5036093225592403791L, 9011924035477596686L, }, { 8342802546510264958L, 6571262398890126070L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Int64[,] { { 4967424879640634757L, 2345544165963023910L, }, { 486876023253489510L, 4537140539034995238L, }, },
    NullableValue = 
new System.Int64[,] { { 8978321829046964822L, 3790106066083571722L, }, { 1795847579222173204L, 5874745697547913003L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int64[,] { { 68545453677425081L, 503782406880409876L, }, { 5195577680548329044L, 6872802067585285038L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7093518935270988938L, 272771367814124064L, }, { 619967252328601422L, 5318105227192307453L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { { 5042314333722360972L, 2961750685353808644L, }, { 1423573021141609927L, 1120303057399958632L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int64[,] { { 9109467406107227873L, 5878415587544950739L, }, { 4292945049535280042L, 7138539789360292293L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Int64[,] { { 4618409327336647008L, 708358983789231385L, }, { 95035778579619931L, 8629557643808627207L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Int64[,] { { 4651200940288772466L, 2531301192116543281L, }, { 3516066256153800039L, 3851875345104767304L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Int64[,] { { 8903614859407369663L, 4618296223117153757L, }, { 1400699723916918527L, 5446926586166199091L, }, },
    NullableValue = 
new System.Int64[,] { { 7084767046322004744L, 6540124544189543343L, }, { 4258523772362359132L, 311918547648993702L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int64[,] { { 8415746335425887163L, 5908233321332304160L, }, { 1310122803216960225L, 1152755611840556201L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int64[,] { { 6450953429231491577L, 3757724690106911906L, }, { 5706739692166497099L, 4549370696107866459L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Int64[,] { { 388668136825147517L, 6112415146759705430L, }, { 677386477748741323L, 4125029953772982846L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4795736259411267241L, 1832294289093456605L, }, { 3163576136363059745L, 3479345492379095936L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int64[,] { { 2469621381810686351L, 4559671045898273154L, }, { 7130758515462125231L, 2052306309785502942L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4385553680438910590L, 2871804792238160172L, }, { 2328498384823658798L, 1812052713487475784L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Int64[,] { { 2586685680140025310L, 4328285173604132374L, }, { 8429996940467433156L, 3462966822102608895L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int64[,] { { 6485518609686650906L, 3034642234132065008L, }, { 8470289098111443550L, 4624670032785652837L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int64[,] { { 3345858334296280681L, 3616035409843862927L, }, { 5402553524885145380L, 42999344936466552L, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
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

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 14520427701865983L, 1705838287931525297L, }, { 2620456197616675012L, 4605469023568051299L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 2153171229228924068L, 6117155683516921414L, }, { 6296460516783583004L, 3810812666519102939L, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                System.Int64[,] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 6686933445343242978L, 128862178340585270L, }, { 3798732953212840964L, 7040055914252607000L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 3921243280434125536L, 3059958233135149332L, }, { 8043118856036563882L, 742113673135703230L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 77, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 1, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 99, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 126, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MI),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD2E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
FROM public.binary_int64bigintmmarrayd2e1m m
LEFT JOIN public.binary_int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI), typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                await ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64MArraybigintMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64MArraybigintMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64MArraybigintMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

