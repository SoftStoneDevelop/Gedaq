

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
    Id = 6,
    Value = 
new System.Int64[4]
{
600338786761529812L,
7625628748206908627L,
1887257378676382793L,
4893643324557842045L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7837634931894449647L,
7583240258587851452L,
2382588471078864538L,
5963380259118624994L,
},
},
            new Int64bigintArray1M
{
    Id = 15,
    Value = 
new System.Int64[4]
{
6192971728066891428L,
6546532069518579715L,
6997823868211557077L,
4459556119043514531L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 4,
    Value = 
new System.Int64[4]
{
1194761412301588150L,
6205493943492577946L,
3243669552431395385L,
2293347877368974189L,
},
    NullableValue = 
new System.Int64[4]
{
4616557075948588655L,
2808683766332721144L,
5960069407562981032L,
2016810355699006318L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 18,
    Value = 
new System.Int64[4]
{
5024755072058588828L,
1773481327538512507L,
4183763772708981867L,
5130223788440697810L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5999251904698939953L,
5776215635772440712L,
8480585043339614427L,
6040676498584002324L,
},
},
            new Int64bigintArray1M
{
    Id = 23,
    Value = 
new System.Int64[4]
{
7045874337547094805L,
3586859578677746071L,
3105478475015074164L,
5958457044047786287L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 10,
    Value = 
new System.Int64[4]
{
9047187856808605576L,
5550289683434974621L,
1936038079382547229L,
8378642914549226352L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5573442631960267832L,
479817472198642220L,
6221146650963218789L,
9067823345338517714L,
},
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[3]
{
326897590434154391L,
3211618693088837331L,
436818702032994265L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3384709743137737382L,
6326192044945560125L,
4380854218183201814L,
},
},
            new Int64bigintArray1M
{
    Id = 36,
    Value = 
new System.Int64[3]
{
4846984894324520484L,
8785205820387102065L,
2453496607800803393L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 13,
    Value = 
new System.Int64[4]
{
1487666932183566381L,
2924562584515824967L,
1586035735391872750L,
2585730149029890003L,
},
    NullableValue = 
new System.Int64[3]
{
4761715152898656228L,
8840391984686830684L,
2046699021308040542L,
},
},
    NullableValue = 
new System.Int64[3]
{
5761652337927772468L,
4612847030946942009L,
8037438072674545119L,
},
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[3]
{
772213153729607589L,
7308033288151502313L,
7840929001863876748L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
2672773848295960711L,
531454730515839525L,
1642644620839208424L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 20,
    Value = 
new System.Int64[3]
{
6544953950030183567L,
8982131023676517683L,
839369036527079669L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8014206977093951516L,
218736802474952754L,
4439452899034233620L,
9013271743432638657L,
},
},
            new Int64bigintArray1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
5312825557389966500L,
5497549540847092459L,
2768723875623771780L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4555610146282076240L,
9141075037021526563L,
6208811323139110985L,
707418186608360179L,
},
},
            new Int64bigintArray1M
{
    Id = 55,
    Value = 
new System.Int64[4]
{
3062220115788601516L,
1717835220576332259L,
6252975918780001354L,
1800134880385656572L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[3]
{
3217502598740289673L,
1245478852491043698L,
4295530713234338581L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 61,
    Value = 
new System.Int64[3]
{
5802468402016905920L,
1275083914480187607L,
7119798562609562857L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4530020457506496100L,
7059175094946245648L,
2027817577684433267L,
999400189072891596L,
},
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[4]
{
7471472947934950001L,
4912734757534607331L,
8007986999391091521L,
2703550803302038250L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
5280964078507522219L,
3550917183232299018L,
6112350127876363856L,
2088739636362106167L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 71,
    Value = 
new System.Int64[4]
{
7623861869666331475L,
7658899672792615609L,
5619658887001634346L,
8365251999242994022L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5190434760940714637L,
970809646654901200L,
3849719382489715174L,
},
},
            new Int64bigintArray1M
{
    Id = 72,
    Value = 
new System.Int64[3]
{
414672942753776491L,
7793577821185249518L,
5662330397152072051L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 41,
    Value = 
new System.Int64[3]
{
7587064543913184316L,
8224529500686463511L,
2449707083873890896L,
},
    NullableValue = 
new System.Int64[4]
{
7931698673383638328L,
3949826901274064323L,
7582688549948255415L,
6779455478816748199L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 81,
    Value = 
new System.Int64[3]
{
4601427756823218855L,
5962182287502211728L,
891719794502340940L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[3]
{
5681697193074541017L,
4042007938857829154L,
7504603485353774873L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 46,
    Value = 
new System.Int64[4]
{
8185920114787086053L,
1502096544029526972L,
4463639501599057200L,
7718472662111302655L,
},
    NullableValue = 
new System.Int64[4]
{
21926880270279088L,
5387277669100046554L,
6155928170042426526L,
8562979359869350025L,
},
},
    NullableValue = 
new System.Int64[3]
{
7258884131369352502L,
5699568144044140202L,
1631251340298475436L,
},
},
            new Int64bigintArray1M
{
    Id = 83,
    Value = 
new System.Int64[3]
{
522863338460075116L,
92607203808031692L,
561920744172252920L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
629438423556651141L,
9009258865361309635L,
4074818591750344316L,
5895598109227461661L,
},
},
            new Int64bigintArray1M
{
    Id = 92,
    Value = 
new System.Int64[3]
{
1261116249305778581L,
2609972203426307453L,
6583894615824968271L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 47,
    Value = 
new System.Int64[4]
{
8609682687535301711L,
1465323061863043864L,
3825523471057897880L,
8348232588781225752L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2794773000886673437L,
4422373392023478409L,
980751659520934846L,
3133738214937498133L,
},
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[3]
{
1234336827868400774L,
7662404695842270432L,
4478779610916367141L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2069977109734432645L,
4634903917124790632L,
5454236167779541555L,
},
},
            new Int64bigintArray1M
{
    Id = 96,
    Value = 
new System.Int64[3]
{
4373893490354711841L,
2440836573304280482L,
2632693906543501096L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 48,
    Value = 
new System.Int64[3]
{
5169829743897185135L,
3448139979312979634L,
5475220589144614475L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 100,
    Value = 
new System.Int64[3]
{
4788464924935809460L,
2888620578270274771L,
7076740340393608612L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 103,
    Value = 
new System.Int64[4]
{
6347772165817524320L,
3419564078055027221L,
8676580435133534666L,
4874049734470086347L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
6558094401735684468L,
7001724463636146228L,
5005958001274161142L,
721057384605742383L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
6871067566357715533L,
599481385766618021L,
6734541513238061861L,
},
},
            new Int64bigintArray1M
{
    Id = 109,
    Value = 
new System.Int64[4]
{
2479781398179410705L,
5529434289084767893L,
4267396916023662528L,
3148357508541279837L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7803928276417400960L,
5210520631755796556L,
95186429257867766L,
2789194391400678469L,
},
},
            new Int64bigintArray1M
{
    Id = 117,
    Value = 
new System.Int64[4]
{
5543731077424684544L,
7555877946782643713L,
2716938432644479637L,
9203810457504759245L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
8772349105812198156L,
6406994272353504956L,
724229161702412573L,
6379141728487106664L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2427372108416833429L,
2524469580098409599L,
285035546151714430L,
},
},
            new Int64bigintArray1M
{
    Id = 121,
    Value = 
new System.Int64[3]
{
7270585029318927254L,
6068725373002112261L,
796492018511681333L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
7543601372527109359L,
2552497098891666648L,
7337772309288509041L,
7571040765104004627L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 67,
    Value = 
new System.Int64[3]
{
8183130098694185547L,
8142338076789889359L,
7854859340489203639L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2974079542551033053L,
262503665538683236L,
1623231961691721256L,
8462972830723518850L,
},
},
            new Int64bigintArray1M
{
    Id = 127,
    Value = 
new System.Int64[4]
{
3916865149391341980L,
5842400397521984470L,
2102112519658385177L,
483697683401206755L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6648570979094858469L,
904506785181039742L,
8354294422130683579L,
},
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
33384546063872982L,
605211088391964546L,
2380413588781444290L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 70,
    Value = 
new System.Int64[3]
{
5383712625240282015L,
7589444044648880329L,
4301916706442629942L,
},
    NullableValue = 
new System.Int64[3]
{
2591028811311688106L,
4779452345630508424L,
1921956219479742938L,
},
},
    NullableValue = 
new System.Int64[4]
{
3862141219109726941L,
2598520955377296036L,
6688992644404192779L,
5639216355334408383L,
},
},
            new Int64bigintArray1M
{
    Id = 143,
    Value = 
new System.Int64[3]
{
2633172282036850966L,
4299995178167597789L,
3476100522666911913L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6010171122634099494L,
5667424299197114312L,
739842328556540155L,
1655925569424250781L,
},
},
            new Int64bigintArray1M
{
    Id = 151,
    Value = 
new System.Int64[3]
{
4223975086657582961L,
2659475506226011809L,
9037053768322331693L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 76,
    Value = 
new System.Int64[4]
{
6265652909213852976L,
1611457990425468201L,
7858804835058725617L,
2469146277148003975L,
},
    NullableValue = 
new System.Int64[4]
{
7684237307584736420L,
2330695646062794475L,
5102682653827054124L,
4191235376953758795L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 152,
    Value = 
new System.Int64[4]
{
7640736703052114217L,
2697214465897525352L,
70147321616355908L,
5080839709464636180L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2667428672816682552L,
1989209878293607620L,
7837379199562011273L,
},
},
            new Int64bigintArray1M
{
    Id = 158,
    Value = 
new System.Int64[4]
{
4697460085595641493L,
7912998126242938780L,
7501844721866559443L,
3740645523059291634L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 83,
    Value = 
new System.Int64[3]
{
8697513819598564409L,
6554996780013290498L,
2072276870719822532L,
},
    NullableValue = 
new System.Int64[3]
{
9114230481338723282L,
4981218872869396108L,
7950671153294340399L,
},
},
    NullableValue = 
new System.Int64[3]
{
1626889416174774459L,
1357909631632069856L,
4933601826825070236L,
},
},
            new Int64bigintArray1M
{
    Id = 166,
    Value = 
new System.Int64[3]
{
2899093863528591866L,
1899542641588877519L,
1080942000013316281L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 174,
    Value = 
new System.Int64[4]
{
1149758957551904634L,
8859464380633661700L,
8952358667407541829L,
5776031432775293826L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 90,
    Value = 
new System.Int64[3]
{
54586624930926490L,
4937876743670307911L,
1383853437560598260L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 177,
    Value = 
new System.Int64[4]
{
6496511809862400862L,
5037060859402537796L,
5763299190380778100L,
8477057918945167536L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
3384709743137737382L,
6326192044945560125L,
4380854218183201814L,
}));
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
5761652337927772468L,
4612847030946942009L,
8037438072674545119L,
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
8014206977093951516L,
218736802474952754L,
4439452899034233620L,
9013271743432638657L,
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
4555610146282076240L,
9141075037021526563L,
6208811323139110985L,
707418186608360179L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4530020457506496100L,
7059175094946245648L,
2027817577684433267L,
999400189072891596L,
}));
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 151;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 127, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 83, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 166, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 42, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[34], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray1M.AssertModel(models[0],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

