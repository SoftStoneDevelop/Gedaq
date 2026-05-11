

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxboxE0M[] _testData = new NpgsqlBoxboxE0M[]
        {
            new NpgsqlBoxboxE0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9301922682784308d,right: 0.848894139284497d,bottom: 0.7575740867832851d,left: 0.19189672984765238d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9162958655677981d,right: 0.6449255082509295d,bottom: 0.7802748038122714d,left: 0.576156139859051d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5497100438540794d,right: 0.6240733318191771d,bottom: 0.4349165005261987d,left: 0.17051318828140216d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6311100699445789d,right: 0.5103410757406371d,bottom: 0.5192163388265586d,left: 0.3411213373217049d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4590839971193189d,right: 0.7991619294358445d,bottom: 0.4526796421044461d,left: 0.4499572854979226d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7961324021116896d,right: 0.5171229816905754d,bottom: 0.46682485380151895d,left: 0.18450393368028684d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.48810477211611203d,right: 0.9898986174791123d,bottom: 0.3696117877552174d,left: 0.13308345491895068d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6204240976737272d,right: 0.7749011942554096d,bottom: 0.33496996142834956d,left: 0.004667037083557091d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6567544178890595d,right: 0.786547792265954d,bottom: 0.647733442370307d,left: 0.4714847112689434d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9028850859645067d,right: 0.5899695934526685d,bottom: 0.6107976559359696d,left: 0.1788411112640268d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6490297355713852d,right: 0.3537516784015925d,bottom: 0.4620306904009115d,left: 0.11232704013797079d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8581727546080699d,right: 0.9676779638894757d,bottom: 0.7881806590145176d,left: 0.9315213998628287d),
},
            new NpgsqlBoxboxE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8943758091867535d,right: 0.44807363119893084d,bottom: 0.4777262848526812d,left: 0.2066550539818971d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.328389938856833d,right: 0.6772543344956317d,bottom: 0.18527146469808786d,left: 0.3519040619149053d),
},
            new NpgsqlBoxboxE0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6784630674550293d,right: 0.4986706811163132d,bottom: 0.6337930109483361d,left: 0.32397008109296643d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.30818993203585165d,right: 0.4653419895118205d,bottom: 0.24429216060740722d,left: 0.4372235026843838d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7423222309442278d,right: 0.23343336853321495d,bottom: 0.3825807098693701d,left: 0.0818519640368518d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8777444993815345d,right: 0.6732118927410117d,bottom: 0.2626963971920878d,left: 0.4758205660222521d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8730041893932118d,right: 0.9023670753931423d,bottom: 0.37136548369438005d,left: 0.7382247258823661d),
},
            new NpgsqlBoxboxE0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7775142548399724d,right: 0.36693124731757387d,bottom: 0.08411371541798673d,left: 0.36397882954944616d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9332407468468241d,right: 0.7691150376384011d,bottom: 0.12118349751780533d,left: 0.6714837141592072d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.39337723570729566d,right: 0.8295936391458624d,bottom: 0.15858678390493575d,left: 0.7926214233581339d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9723777015122995d,right: 0.020767595615970524d,bottom: 0.37666657155952776d,left: 0.011542418934064824d),
},
            new NpgsqlBoxboxE0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9277855933876172d,right: 0.1933599130591197d,bottom: 0.8834335219912606d,left: 0.012600477567786261d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5254573613257132d,right: 0.5690756133792813d,bottom: 0.42278882001979856d,left: 0.01159372733011077d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6209511413801858d,right: 0.6130706008387574d,bottom: 0.49439675866455135d,left: 0.44594952437128277d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5018961153910905d,right: 0.9930440720266324d,bottom: 0.008878521629808178d,left: 0.8095421892751145d),
},
            new NpgsqlBoxboxE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7592565130696239d,right: 0.9319327521451166d,bottom: 0.2866779689788159d,left: 0.6395678127628138d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5855871545392972d,right: 0.9888143000999136d,bottom: 0.14547154566107856d,left: 0.8662923295085914d),
},
            new NpgsqlBoxboxE0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.527096901085007d,right: 0.28303648798927084d,bottom: 0.31588733795350443d,left: 0.19138403816108607d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9666142797279275d,right: 0.5503617009401189d,bottom: 0.7895365797956199d,left: 0.2326446953392981d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6133885806195571d,right: 0.474759209172282d,bottom: 0.3239079690647898d,left: 0.12751466728285632d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6138374066532751d,right: 0.890764071156717d,bottom: 0.005209183204804013d,left: 0.10052181127359439d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8938420514882438d,right: 0.7680307842337336d,bottom: 0.8638975648295097d,left: 0.11998817457393496d),
},
            new NpgsqlBoxboxE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7965818282007254d,right: 0.810006943368342d,bottom: 0.15810854998508583d,left: 0.7830451648641168d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9719617836937644d,right: 0.6434957120827594d,bottom: 0.5429934332200264d,left: 0.02836178364956954d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5612008667461336d,right: 0.2738179835632043d,bottom: 0.2760988040329816d,left: 0.12823528290935116d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.551333957297941d,right: 0.846412705666421d,bottom: 0.18466594366291333d,left: 0.0793957817244787d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.679596016722102d,right: 0.36685554715272684d,bottom: 0.5387924248229994d,left: 0.15571890481499706d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9332683560235001d,right: 0.7889355093185831d,bottom: 0.583975666237598d,left: 0.009129357206488886d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6454894672391357d,right: 0.8120228524010301d,bottom: 0.06414049920087028d,left: 0.579039072735741d),
},
            new NpgsqlBoxboxE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17556612060056642d,right: 0.3574615835554644d,bottom: 0.13941751029769722d,left: 0.06664582095142668d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8679640495517543d,right: 0.75537177937342d,bottom: 0.44447887188463775d,left: 0.2080412824389003d),
},
            new NpgsqlBoxboxE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4387623847889819d,right: 0.513668449573001d,bottom: 0.10952426430939588d,left: 0.4680792856362146d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9316073918290246d,right: 0.08756044391311035d,bottom: 0.8780483818108227d,left: 0.057990962890087316d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7187784035962539d,right: 0.926301336582418d,bottom: 0.703802098942019d,left: 0.776338484020682d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7973188338556908d,right: 0.827905347054417d,bottom: 0.29826754011067935d,left: 0.0055305634229292355d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4342635881682253d,right: 0.7421477158918388d,bottom: 0.29598975273969363d,left: 0.5198462454752071d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6254952397196959d,right: 0.6189799969485209d,bottom: 0.5753197511056275d,left: 0.10521679038261189d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34604970086666775d,right: 0.1814594180467345d,bottom: 0.09707211323881404d,left: 0.14415352004568238d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.991656321785452d,right: 0.6349496719348979d,bottom: 0.4539927178296953d,left: 0.3180000669892913d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8760356817390796d,right: 0.43896774174149855d,bottom: 0.032263236551582364d,left: 0.14709976404936254d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5775938682623184d,right: 0.9758243062409762d,bottom: 0.40689031385532126d,left: 0.4100914506092005d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6464098141036199d,right: 0.8697133871170931d,bottom: 0.4208038542305118d,left: 0.36251771625114404d),
},
            new NpgsqlBoxboxE0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4333652103191852d,right: 0.9458556112326643d,bottom: 0.060196052634192365d,left: 0.4911446090953677d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9846833172886811d,right: 0.629644616844629d,bottom: 0.05468150534825911d,left: 0.49237645859641366d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6833143925903252d,right: 0.42259675173557365d,bottom: 0.4101237475362641d,left: 0.40634166432894636d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8305050688496752d,right: 0.564658636273085d,bottom: 0.3756677326234308d,left: 0.4495735898668334d),
},
            new NpgsqlBoxboxE0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7465055059244332d,right: 0.8549167606009949d,bottom: 0.6221890772548959d,left: 0.5194478524624556d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5742490975049414d,right: 0.9430676454075241d,bottom: 0.541305852957149d,left: 0.1793124690456942d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3443616967639853d,right: 0.897161017175199d,bottom: 0.2552854749418709d,left: 0.5415473735953025d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8398191128520439d,right: 0.8431970490031933d,bottom: 0.6449583870096078d,left: 0.6064195366412494d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7676041471433377d,right: 0.7913805745396398d,bottom: 0.6347802673891837d,left: 0.44268303927793073d),
},
            new NpgsqlBoxboxE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.444300148715023d,right: 0.9544639348732784d,bottom: 0.39163768856331527d,left: 0.7003015263078899d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3916458121809496d,right: 0.13944360569095082d,bottom: 0.08866784031058295d,left: 0.03724494822722768d),
},
            new NpgsqlBoxboxE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5412705265224049d,right: 0.9282652046147537d,bottom: 0.3765533868166726d,left: 0.8856942692654385d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.32350562517523407d,right: 0.919351082166175d,bottom: 0.1342509622781981d,left: 0.673453102886495d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8948814841452459d,right: 0.9837609104923237d,bottom: 0.415763147227566d,left: 0.9318789824056279d),
},
            new NpgsqlBoxboxE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.993077743401841d,right: 0.7109739933099541d,bottom: 0.4341290476811397d,left: 0.5348796637684742d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6917960104438148d,right: 0.8059711902160531d,bottom: 0.2766855664514397d,left: 0.2769388047793163d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8905026357795102d,right: 0.5764665348976195d,bottom: 0.4021021296498847d,left: 0.52902997921388d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7430102227573978d,right: 0.5584696002609165d,bottom: 0.3751196287155151d,left: 0.5282263994912074d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4116975886100588d,right: 0.9800641964021751d,bottom: 0.01159683997682237d,left: 0.8536071787932605d),
},
            new NpgsqlBoxboxE0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.980080689155192d,right: 0.4862889849873435d,bottom: 0.20403073450298004d,left: 0.05571958333855287d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7636096114933371d,right: 0.7295189764785043d,bottom: 0.5477542601701091d,left: 0.7052780495560993d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9406767977687004d,right: 0.651529353547857d,bottom: 0.30177651890934143d,left: 0.2854974285300468d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8581727546080699d,right: 0.9676779638894757d,bottom: 0.7881806590145176d,left: 0.9315213998628287d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.328389938856833d,right: 0.6772543344956317d,bottom: 0.18527146469808786d,left: 0.3519040619149053d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8730041893932118d,right: 0.9023670753931423d,bottom: 0.37136548369438005d,left: 0.7382247258823661d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9723777015122995d,right: 0.020767595615970524d,bottom: 0.37666657155952776d,left: 0.011542418934064824d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5018961153910905d,right: 0.9930440720266324d,bottom: 0.008878521629808178d,left: 0.8095421892751145d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxboxe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxboxe0mi_id", 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 52, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 77, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 129, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 5, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 92, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9301922682784308d,right: 0.848894139284497d,bottom: 0.7575740867832851d,left: 0.19189672984765238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9162958655677981d,right: 0.6449255082509295d,bottom: 0.7802748038122714d,left: 0.576156139859051d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5497100438540794d,right: 0.6240733318191771d,bottom: 0.4349165005261987d,left: 0.17051318828140216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6311100699445789d,right: 0.5103410757406371d,bottom: 0.5192163388265586d,left: 0.3411213373217049d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4590839971193189d,right: 0.7991619294358445d,bottom: 0.4526796421044461d,left: 0.4499572854979226d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7961324021116896d,right: 0.5171229816905754d,bottom: 0.46682485380151895d,left: 0.18450393368028684d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48810477211611203d,right: 0.9898986174791123d,bottom: 0.3696117877552174d,left: 0.13308345491895068d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6204240976737272d,right: 0.7749011942554096d,bottom: 0.33496996142834956d,left: 0.004667037083557091d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6567544178890595d,right: 0.786547792265954d,bottom: 0.647733442370307d,left: 0.4714847112689434d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9028850859645067d,right: 0.5899695934526685d,bottom: 0.6107976559359696d,left: 0.1788411112640268d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6490297355713852d,right: 0.3537516784015925d,bottom: 0.4620306904009115d,left: 0.11232704013797079d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8581727546080699d,right: 0.9676779638894757d,bottom: 0.7881806590145176d,left: 0.9315213998628287d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8943758091867535d,right: 0.44807363119893084d,bottom: 0.4777262848526812d,left: 0.2066550539818971d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.328389938856833d,right: 0.6772543344956317d,bottom: 0.18527146469808786d,left: 0.3519040619149053d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6784630674550293d,right: 0.4986706811163132d,bottom: 0.6337930109483361d,left: 0.32397008109296643d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30818993203585165d,right: 0.4653419895118205d,bottom: 0.24429216060740722d,left: 0.4372235026843838d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7423222309442278d,right: 0.23343336853321495d,bottom: 0.3825807098693701d,left: 0.0818519640368518d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8777444993815345d,right: 0.6732118927410117d,bottom: 0.2626963971920878d,left: 0.4758205660222521d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8730041893932118d,right: 0.9023670753931423d,bottom: 0.37136548369438005d,left: 0.7382247258823661d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7775142548399724d,right: 0.36693124731757387d,bottom: 0.08411371541798673d,left: 0.36397882954944616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332407468468241d,right: 0.7691150376384011d,bottom: 0.12118349751780533d,left: 0.6714837141592072d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39337723570729566d,right: 0.8295936391458624d,bottom: 0.15858678390493575d,left: 0.7926214233581339d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9723777015122995d,right: 0.020767595615970524d,bottom: 0.37666657155952776d,left: 0.011542418934064824d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9277855933876172d,right: 0.1933599130591197d,bottom: 0.8834335219912606d,left: 0.012600477567786261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5254573613257132d,right: 0.5690756133792813d,bottom: 0.42278882001979856d,left: 0.01159372733011077d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6209511413801858d,right: 0.6130706008387574d,bottom: 0.49439675866455135d,left: 0.44594952437128277d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5018961153910905d,right: 0.9930440720266324d,bottom: 0.008878521629808178d,left: 0.8095421892751145d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7592565130696239d,right: 0.9319327521451166d,bottom: 0.2866779689788159d,left: 0.6395678127628138d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5855871545392972d,right: 0.9888143000999136d,bottom: 0.14547154566107856d,left: 0.8662923295085914d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.527096901085007d,right: 0.28303648798927084d,bottom: 0.31588733795350443d,left: 0.19138403816108607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666142797279275d,right: 0.5503617009401189d,bottom: 0.7895365797956199d,left: 0.2326446953392981d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6133885806195571d,right: 0.474759209172282d,bottom: 0.3239079690647898d,left: 0.12751466728285632d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6138374066532751d,right: 0.890764071156717d,bottom: 0.005209183204804013d,left: 0.10052181127359439d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8938420514882438d,right: 0.7680307842337336d,bottom: 0.8638975648295097d,left: 0.11998817457393496d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7965818282007254d,right: 0.810006943368342d,bottom: 0.15810854998508583d,left: 0.7830451648641168d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9719617836937644d,right: 0.6434957120827594d,bottom: 0.5429934332200264d,left: 0.02836178364956954d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5612008667461336d,right: 0.2738179835632043d,bottom: 0.2760988040329816d,left: 0.12823528290935116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.551333957297941d,right: 0.846412705666421d,bottom: 0.18466594366291333d,left: 0.0793957817244787d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.679596016722102d,right: 0.36685554715272684d,bottom: 0.5387924248229994d,left: 0.15571890481499706d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332683560235001d,right: 0.7889355093185831d,bottom: 0.583975666237598d,left: 0.009129357206488886d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6454894672391357d,right: 0.8120228524010301d,bottom: 0.06414049920087028d,left: 0.579039072735741d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17556612060056642d,right: 0.3574615835554644d,bottom: 0.13941751029769722d,left: 0.06664582095142668d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8679640495517543d,right: 0.75537177937342d,bottom: 0.44447887188463775d,left: 0.2080412824389003d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4387623847889819d,right: 0.513668449573001d,bottom: 0.10952426430939588d,left: 0.4680792856362146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9316073918290246d,right: 0.08756044391311035d,bottom: 0.8780483818108227d,left: 0.057990962890087316d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7187784035962539d,right: 0.926301336582418d,bottom: 0.703802098942019d,left: 0.776338484020682d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7973188338556908d,right: 0.827905347054417d,bottom: 0.29826754011067935d,left: 0.0055305634229292355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4342635881682253d,right: 0.7421477158918388d,bottom: 0.29598975273969363d,left: 0.5198462454752071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6254952397196959d,right: 0.6189799969485209d,bottom: 0.5753197511056275d,left: 0.10521679038261189d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34604970086666775d,right: 0.1814594180467345d,bottom: 0.09707211323881404d,left: 0.14415352004568238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.991656321785452d,right: 0.6349496719348979d,bottom: 0.4539927178296953d,left: 0.3180000669892913d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8760356817390796d,right: 0.43896774174149855d,bottom: 0.032263236551582364d,left: 0.14709976404936254d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5775938682623184d,right: 0.9758243062409762d,bottom: 0.40689031385532126d,left: 0.4100914506092005d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6464098141036199d,right: 0.8697133871170931d,bottom: 0.4208038542305118d,left: 0.36251771625114404d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4333652103191852d,right: 0.9458556112326643d,bottom: 0.060196052634192365d,left: 0.4911446090953677d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9846833172886811d,right: 0.629644616844629d,bottom: 0.05468150534825911d,left: 0.49237645859641366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6833143925903252d,right: 0.42259675173557365d,bottom: 0.4101237475362641d,left: 0.40634166432894636d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8305050688496752d,right: 0.564658636273085d,bottom: 0.3756677326234308d,left: 0.4495735898668334d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7465055059244332d,right: 0.8549167606009949d,bottom: 0.6221890772548959d,left: 0.5194478524624556d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5742490975049414d,right: 0.9430676454075241d,bottom: 0.541305852957149d,left: 0.1793124690456942d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3443616967639853d,right: 0.897161017175199d,bottom: 0.2552854749418709d,left: 0.5415473735953025d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8398191128520439d,right: 0.8431970490031933d,bottom: 0.6449583870096078d,left: 0.6064195366412494d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7676041471433377d,right: 0.7913805745396398d,bottom: 0.6347802673891837d,left: 0.44268303927793073d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.444300148715023d,right: 0.9544639348732784d,bottom: 0.39163768856331527d,left: 0.7003015263078899d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3916458121809496d,right: 0.13944360569095082d,bottom: 0.08866784031058295d,left: 0.03724494822722768d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5412705265224049d,right: 0.9282652046147537d,bottom: 0.3765533868166726d,left: 0.8856942692654385d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32350562517523407d,right: 0.919351082166175d,bottom: 0.1342509622781981d,left: 0.673453102886495d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8948814841452459d,right: 0.9837609104923237d,bottom: 0.415763147227566d,left: 0.9318789824056279d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.993077743401841d,right: 0.7109739933099541d,bottom: 0.4341290476811397d,left: 0.5348796637684742d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6917960104438148d,right: 0.8059711902160531d,bottom: 0.2766855664514397d,left: 0.2769388047793163d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8905026357795102d,right: 0.5764665348976195d,bottom: 0.4021021296498847d,left: 0.52902997921388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7430102227573978d,right: 0.5584696002609165d,bottom: 0.3751196287155151d,left: 0.5282263994912074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4116975886100588d,right: 0.9800641964021751d,bottom: 0.01159683997682237d,left: 0.8536071787932605d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.980080689155192d,right: 0.4862889849873435d,bottom: 0.20403073450298004d,left: 0.05571958333855287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7636096114933371d,right: 0.7295189764785043d,bottom: 0.5477542601701091d,left: 0.7052780495560993d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9406767977687004d,right: 0.651529353547857d,bottom: 0.30177651890934143d,left: 0.2854974285300468d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9301922682784308d,right: 0.848894139284497d,bottom: 0.7575740867832851d,left: 0.19189672984765238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9162958655677981d,right: 0.6449255082509295d,bottom: 0.7802748038122714d,left: 0.576156139859051d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5497100438540794d,right: 0.6240733318191771d,bottom: 0.4349165005261987d,left: 0.17051318828140216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6311100699445789d,right: 0.5103410757406371d,bottom: 0.5192163388265586d,left: 0.3411213373217049d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4590839971193189d,right: 0.7991619294358445d,bottom: 0.4526796421044461d,left: 0.4499572854979226d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7961324021116896d,right: 0.5171229816905754d,bottom: 0.46682485380151895d,left: 0.18450393368028684d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48810477211611203d,right: 0.9898986174791123d,bottom: 0.3696117877552174d,left: 0.13308345491895068d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6204240976737272d,right: 0.7749011942554096d,bottom: 0.33496996142834956d,left: 0.004667037083557091d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6567544178890595d,right: 0.786547792265954d,bottom: 0.647733442370307d,left: 0.4714847112689434d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9028850859645067d,right: 0.5899695934526685d,bottom: 0.6107976559359696d,left: 0.1788411112640268d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6490297355713852d,right: 0.3537516784015925d,bottom: 0.4620306904009115d,left: 0.11232704013797079d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8581727546080699d,right: 0.9676779638894757d,bottom: 0.7881806590145176d,left: 0.9315213998628287d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8943758091867535d,right: 0.44807363119893084d,bottom: 0.4777262848526812d,left: 0.2066550539818971d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.328389938856833d,right: 0.6772543344956317d,bottom: 0.18527146469808786d,left: 0.3519040619149053d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6784630674550293d,right: 0.4986706811163132d,bottom: 0.6337930109483361d,left: 0.32397008109296643d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30818993203585165d,right: 0.4653419895118205d,bottom: 0.24429216060740722d,left: 0.4372235026843838d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7423222309442278d,right: 0.23343336853321495d,bottom: 0.3825807098693701d,left: 0.0818519640368518d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8777444993815345d,right: 0.6732118927410117d,bottom: 0.2626963971920878d,left: 0.4758205660222521d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8730041893932118d,right: 0.9023670753931423d,bottom: 0.37136548369438005d,left: 0.7382247258823661d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7775142548399724d,right: 0.36693124731757387d,bottom: 0.08411371541798673d,left: 0.36397882954944616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332407468468241d,right: 0.7691150376384011d,bottom: 0.12118349751780533d,left: 0.6714837141592072d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.39337723570729566d,right: 0.8295936391458624d,bottom: 0.15858678390493575d,left: 0.7926214233581339d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9723777015122995d,right: 0.020767595615970524d,bottom: 0.37666657155952776d,left: 0.011542418934064824d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9277855933876172d,right: 0.1933599130591197d,bottom: 0.8834335219912606d,left: 0.012600477567786261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5254573613257132d,right: 0.5690756133792813d,bottom: 0.42278882001979856d,left: 0.01159372733011077d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6209511413801858d,right: 0.6130706008387574d,bottom: 0.49439675866455135d,left: 0.44594952437128277d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5018961153910905d,right: 0.9930440720266324d,bottom: 0.008878521629808178d,left: 0.8095421892751145d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7592565130696239d,right: 0.9319327521451166d,bottom: 0.2866779689788159d,left: 0.6395678127628138d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5855871545392972d,right: 0.9888143000999136d,bottom: 0.14547154566107856d,left: 0.8662923295085914d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.527096901085007d,right: 0.28303648798927084d,bottom: 0.31588733795350443d,left: 0.19138403816108607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9666142797279275d,right: 0.5503617009401189d,bottom: 0.7895365797956199d,left: 0.2326446953392981d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6133885806195571d,right: 0.474759209172282d,bottom: 0.3239079690647898d,left: 0.12751466728285632d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6138374066532751d,right: 0.890764071156717d,bottom: 0.005209183204804013d,left: 0.10052181127359439d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8938420514882438d,right: 0.7680307842337336d,bottom: 0.8638975648295097d,left: 0.11998817457393496d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7965818282007254d,right: 0.810006943368342d,bottom: 0.15810854998508583d,left: 0.7830451648641168d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9719617836937644d,right: 0.6434957120827594d,bottom: 0.5429934332200264d,left: 0.02836178364956954d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5612008667461336d,right: 0.2738179835632043d,bottom: 0.2760988040329816d,left: 0.12823528290935116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.551333957297941d,right: 0.846412705666421d,bottom: 0.18466594366291333d,left: 0.0793957817244787d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.679596016722102d,right: 0.36685554715272684d,bottom: 0.5387924248229994d,left: 0.15571890481499706d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9332683560235001d,right: 0.7889355093185831d,bottom: 0.583975666237598d,left: 0.009129357206488886d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6454894672391357d,right: 0.8120228524010301d,bottom: 0.06414049920087028d,left: 0.579039072735741d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17556612060056642d,right: 0.3574615835554644d,bottom: 0.13941751029769722d,left: 0.06664582095142668d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8679640495517543d,right: 0.75537177937342d,bottom: 0.44447887188463775d,left: 0.2080412824389003d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4387623847889819d,right: 0.513668449573001d,bottom: 0.10952426430939588d,left: 0.4680792856362146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9316073918290246d,right: 0.08756044391311035d,bottom: 0.8780483818108227d,left: 0.057990962890087316d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7187784035962539d,right: 0.926301336582418d,bottom: 0.703802098942019d,left: 0.776338484020682d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7973188338556908d,right: 0.827905347054417d,bottom: 0.29826754011067935d,left: 0.0055305634229292355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4342635881682253d,right: 0.7421477158918388d,bottom: 0.29598975273969363d,left: 0.5198462454752071d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6254952397196959d,right: 0.6189799969485209d,bottom: 0.5753197511056275d,left: 0.10521679038261189d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34604970086666775d,right: 0.1814594180467345d,bottom: 0.09707211323881404d,left: 0.14415352004568238d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.991656321785452d,right: 0.6349496719348979d,bottom: 0.4539927178296953d,left: 0.3180000669892913d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8760356817390796d,right: 0.43896774174149855d,bottom: 0.032263236551582364d,left: 0.14709976404936254d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5775938682623184d,right: 0.9758243062409762d,bottom: 0.40689031385532126d,left: 0.4100914506092005d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6464098141036199d,right: 0.8697133871170931d,bottom: 0.4208038542305118d,left: 0.36251771625114404d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4333652103191852d,right: 0.9458556112326643d,bottom: 0.060196052634192365d,left: 0.4911446090953677d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9846833172886811d,right: 0.629644616844629d,bottom: 0.05468150534825911d,left: 0.49237645859641366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6833143925903252d,right: 0.42259675173557365d,bottom: 0.4101237475362641d,left: 0.40634166432894636d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8305050688496752d,right: 0.564658636273085d,bottom: 0.3756677326234308d,left: 0.4495735898668334d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7465055059244332d,right: 0.8549167606009949d,bottom: 0.6221890772548959d,left: 0.5194478524624556d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5742490975049414d,right: 0.9430676454075241d,bottom: 0.541305852957149d,left: 0.1793124690456942d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3443616967639853d,right: 0.897161017175199d,bottom: 0.2552854749418709d,left: 0.5415473735953025d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8398191128520439d,right: 0.8431970490031933d,bottom: 0.6449583870096078d,left: 0.6064195366412494d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7676041471433377d,right: 0.7913805745396398d,bottom: 0.6347802673891837d,left: 0.44268303927793073d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.444300148715023d,right: 0.9544639348732784d,bottom: 0.39163768856331527d,left: 0.7003015263078899d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3916458121809496d,right: 0.13944360569095082d,bottom: 0.08866784031058295d,left: 0.03724494822722768d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5412705265224049d,right: 0.9282652046147537d,bottom: 0.3765533868166726d,left: 0.8856942692654385d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32350562517523407d,right: 0.919351082166175d,bottom: 0.1342509622781981d,left: 0.673453102886495d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8948814841452459d,right: 0.9837609104923237d,bottom: 0.415763147227566d,left: 0.9318789824056279d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.993077743401841d,right: 0.7109739933099541d,bottom: 0.4341290476811397d,left: 0.5348796637684742d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6917960104438148d,right: 0.8059711902160531d,bottom: 0.2766855664514397d,left: 0.2769388047793163d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8905026357795102d,right: 0.5764665348976195d,bottom: 0.4021021296498847d,left: 0.52902997921388d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7430102227573978d,right: 0.5584696002609165d,bottom: 0.3751196287155151d,left: 0.5282263994912074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4116975886100588d,right: 0.9800641964021751d,bottom: 0.01159683997682237d,left: 0.8536071787932605d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.980080689155192d,right: 0.4862889849873435d,bottom: 0.20403073450298004d,left: 0.05571958333855287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7636096114933371d,right: 0.7295189764785043d,bottom: 0.5477542601701091d,left: 0.7052780495560993d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9406767977687004d,right: 0.651529353547857d,bottom: 0.30177651890934143d,left: 0.2854974285300468d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxboxe0m m
LEFT JOIN public.binary_npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI), typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

