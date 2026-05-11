

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
    Id = 4,
    Value = 
new System.Int64[,] { { 5137994703583002500L, 7820310797204926034L, }, { 8968549528577959582L, 4635106460737336946L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6444592610205908903L, 7422830069324078952L, }, { 2558319110293514825L, 5539966421827831958L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 2264537470130674091L, 3730707222848135427L, }, { 8031559225563857906L, 3350871618286240769L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int64[,] { { 1009976933497026706L, 3566988414163842907L, }, { 2897908660835337435L, 7258896103406468458L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int64[,] { { 1564074078124844607L, 9175048022768330530L, }, { 1942559628037302746L, 4136218627700745160L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int64[,] { { 8726317376263285928L, 7047851076037684159L, }, { 856201141908053109L, 3566857406585870576L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int64[,] { { 7164762147765502881L, 7377305730292676853L, }, { 5245699810163008487L, 3477987718230067350L, }, },
    NullableValue = 
new System.Int64[,] { { 1146264207817211718L, 7749294388504767319L, }, { 6779312418326245210L, 168578527326020383L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int64[,] { { 959378202864609797L, 5065939401703036790L, }, { 5692954842190049117L, 1003378849063295623L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7881541640488222249L, 7158572013029126767L, }, { 2830072069772314238L, 2806290946408001984L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int64[,] { { 2111083610784985947L, 5491998100802432182L, }, { 6858818807162407204L, 3880356096506653490L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int64[,] { { 7774988855107361019L, 6648889611620791592L, }, { 295063416750367327L, 2106417246433281485L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int64[,] { { 7126073571737723551L, 9195000744618449845L, }, { 1665599118494979089L, 5914956651373053585L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int64[,] { { 2699182610140236224L, 822339862681561819L, }, { 4430058419294587568L, 9179576889055182873L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Int64[,] { { 6810114737884782334L, 2336565128603489194L, }, { 8337819896226911015L, 208354734917006010L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int64[,] { { 4520470240326577804L, 6853845802354074152L, }, { 3213616357831521669L, 6410289225404004402L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6711628813694843963L, 8226630907323948043L, }, { 6100023410653939430L, 3657593872489543517L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int64[,] { { 1059566935705802725L, 7725097206535233132L, }, { 749400902113874330L, 6981235580305124000L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int64[,] { { 2662157995492861115L, 2700326904502790159L, }, { 876896146558320031L, 4257353779084792923L, }, },
    NullableValue = 
new System.Int64[,] { { 7507537615833061062L, 2094456078771942514L, }, { 4158164902484595066L, 1732678499587640519L, }, },
},
    NullableValue = 
new System.Int64[,] { { 1443906293702440624L, 2469594349484323020L, }, { 7564049137131582249L, 5859335273809115542L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int64[,] { { 1969790768255922812L, 20960050544564056L, }, { 7529982661854774207L, 5581371468167896250L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int64[,] { { 1921077588759990216L, 842126087954901149L, }, { 2787445954401168718L, 5603645305449619409L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 2930104670441059985L, 6685771456276679655L, }, { 1112615961832236854L, 2428672148187370573L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5208215886966761958L, 6973551381411556377L, }, { 296316272882235847L, 1381370128916439854L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Int64[,] { { 5674524175659348518L, 4868224431683081200L, }, { 3274892544973864495L, 1912591141399606066L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int64[,] { { 4977171521969340769L, 8062980904728829935L, }, { 4968798561886851132L, 3234351975782622595L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int64[,] { { 77793424352707024L, 1631919355333526078L, }, { 3972623293418295202L, 6412118139346599235L, }, },
    NullableValue = 
new System.Int64[,] { { 4610726360107776913L, 4145348657687340473L, }, { 5507935548882124532L, 6493074040289939988L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5224314407715253247L, 1710359352006357693L, }, { 3208301414469469059L, 6869057868674381119L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int64[,] { { 9053030728992401748L, 8572596554493602187L, }, { 4036040944354441390L, 5736185142229772223L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { { 2351234263751629787L, 5890847595711842143L, }, { 4519465533843668638L, 6397376523429901633L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Int64[,] { { 8298673239487967790L, 103094511034600088L, }, { 6704646137864047144L, 5298318049135011045L, }, },
    NullableValue = 
new System.Int64[,] { { 3154242866241299858L, 6672236678729860074L, }, { 6848153778721597347L, 967404832371762900L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int64[,] { { 3092293639600942979L, 6853693502962793420L, }, { 3417978692572432381L, 2916731584582227634L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Int64[,] { { 2616218021280520925L, 4455444832260997264L, }, { 5956986117757658782L, 6164607521927117593L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { { 1465244982341814033L, 1385232674105112649L, }, { 8262589626033613208L, 4518296361702952756L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2735717372225670196L, 1791586297440466550L, }, { 1728337562604049360L, 106809763751094671L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Int64[,] { { 1506074131327156979L, 8245121229949752289L, }, { 1237893918136995230L, 865570203158638111L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3735119352428160988L, 6306499515933831125L, }, { 3948236309184004324L, 1576818082641536664L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Int64[,] { { 3809137455484478295L, 2429720039030584523L, }, { 4619059998609731081L, 6890630661676024913L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Int64[,] { { 6444159269140031223L, 3503042545245833506L, }, { 6239546868810852185L, 4768408209266293630L, }, },
    NullableValue = 
new System.Int64[,] { { 5705337608857543607L, 706204704082559777L, }, { 3258120492101003672L, 6135079253726196011L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Int64[,] { { 314756284747716624L, 2283660739296802882L, }, { 1122041512580677023L, 7121076300357228733L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6067169215645475913L, 1598583313198577333L, }, { 6925577361762879858L, 3234520173347125539L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Int64[,] { { 659127277035491048L, 4418893839743169800L, }, { 8520719616241343581L, 602697340556791762L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int64[,] { { 2663673120464476993L, 8615355552783120238L, }, { 4143964949378914284L, 4273277303676819238L, }, },
    NullableValue = 
new System.Int64[,] { { 648309401930834309L, 1691973563399803983L, }, { 3420236709710514142L, 2920056234959014892L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int64[,] { { 2872555419751481213L, 5169789627174625593L, }, { 7728711495677515862L, 8575811470104129494L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7764893871747971117L, 2371914164132485707L, }, { 2789027910716667728L, 1243351739889874507L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int64[,] { { 8294562204226603817L, 3369361125579465753L, }, { 4822043444167764553L, 277798700802278020L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int64[,] { { 793627463534368151L, 8494395280874881933L, }, { 5610932231777333482L, 6175859538840141464L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6709282458555593210L, 2206282870786833175L, }, { 6205401823015914705L, 1331831966564226592L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int64[,] { { 5038857077069195827L, 8045712403116418076L, }, { 8177822388401585125L, 4306176370738614395L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int64[,] { { 3534274306716088862L, 4566647560809592496L, }, { 1947787586188151598L, 5862659508093564928L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Int64[,] { { 768135859112470853L, 8402177761189855482L, }, { 4769349227564552494L, 8965355241054398260L, }, },
    NullableValue = 
new System.Int64[,] { { 8407917367575809804L, 9177348895147654597L, }, { 4521070506326334229L, 5858408131303383078L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4303046803376189919L, 8042618667757460322L, }, { 7492149094790732864L, 3871663135376122274L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Int64[,] { { 3715015896222786580L, 5421629833750741977L, }, { 234782209149709494L, 6416412311200121425L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 600481783717750033L, 8441424460399568201L, }, { 9136130145472799970L, 1463486482730246394L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int64[,] { { 2668527928794413337L, 7619481204966726938L, }, { 4125897700410363465L, 3278387270576364255L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int64[,] { { 2227652888689490079L, 3392238864946199519L, }, { 4144540286118553878L, 7239024442039435436L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { { 3301131999973832162L, 4624151885155638914L, }, { 4620304221044151583L, 583867095721025301L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7312169319401238295L, 6706451161298006521L, }, { 3878645338309936377L, 710235450792429677L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int64[,] { { 5599516478899916107L, 623088439226748674L, }, { 5976919237599577425L, 6113692151425753374L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int64[,] { { 9180180410650941468L, 5295144800480291070L, }, { 6104370103816291076L, 7532932407529212187L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 9221109030332080841L, 7055912873494814367L, }, { 8690079980110371715L, 1508089253972874510L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int64[,] { { 622755145790414703L, 7706289865884402710L, }, { 5667696126494832563L, 3223260386854075025L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4555735649299858946L, 2850145379663834616L, }, { 366436530499616765L, 8792659463409919061L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 4527971897935078445L, 4732819144947124279L, }, { 2771303317097589038L, 7614667829699933006L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int64[,] { { 5235096594132330191L, 7816439951179872512L, }, { 7045947764083032204L, 4007237799186466269L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4878376163193538597L, 8058631501034702175L, }, { 2397201484713205625L, 3710779640947405537L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Int64[,] { { 3930535271808987246L, 6301276897623591517L, }, { 2313270669597393561L, 8894445076303747339L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4449205698999042914L, 2697688805271458673L, }, { 463540974545946145L, 6974123929163717805L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int64[,] { { 1974662429129106449L, 7081803651717883357L, }, { 830242474040042472L, 7327339901719653610L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int64[,] { { 7590629932712700188L, 7112812044384996287L, }, { 7769727830659420987L, 1986608877198773539L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6026756965794968546L, 6626402302701616935L, }, { 9072818823606716653L, 4027304121152440264L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int64[,] { { 3396663992048308714L, 7396032486713228892L, }, { 7485348457479724206L, 6695783385941759872L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 1628158544639741444L, 3365023288289647300L, }, { 4464913616391643172L, 4485069792208085452L, }, },
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 7881541640488222249L, 7158572013029126767L, }, { 2830072069772314238L, 2806290946408001984L, }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 6711628813694843963L, 8226630907323948043L, }, { 6100023410653939430L, 3657593872489543517L, }, }));
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 1443906293702440624L, 2469594349484323020L, }, { 7564049137131582249L, 5859335273809115542L, }, }));
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
new System.Int64[,] { { 5208215886966761958L, 6973551381411556377L, }, { 296316272882235847L, 1381370128916439854L, }, }));
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
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
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 153, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 38, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 10, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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

