

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


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6849241902265956d, y: 0.7943660768025833d), radius: 0.15113324043313803d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1988797262484826d, y: 0.4594895054570194d), radius: 0.8738838176539654d),
},
            new NpgsqlCirclecircle0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991186368825114d, y: 0.5166038834257121d), radius: 0.32438350503371816d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10764895010542197d, y: 0.8205340078762398d), radius: 0.6701110640178884d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5059913640808019d, y: 0.8505664282178794d), radius: 0.29088521692408553d),
},
            new NpgsqlCirclecircle0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04107362697838801d, y: 0.006428881541678311d), radius: 0.3534919811576236d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29466714743003175d, y: 0.3817980605193052d), radius: 0.8009827057102448d),
},
            new NpgsqlCirclecircle0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3653637946335415d, y: 0.14106888097849113d), radius: 0.6440510871347261d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3369384951870361d, y: 0.43826444193540737d), radius: 0.1867634835234795d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18306824693448331d, y: 0.7984050858389963d), radius: 0.9519042911573384d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781602260203466d, y: 0.6953904924513133d), radius: 0.8174295760701579d),
},
            new NpgsqlCirclecircle0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11627264242568225d, y: 0.19090272791146856d), radius: 0.9861996059678324d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557162834620289d, y: 0.26833834637971155d), radius: 0.8310137214526042d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26600422207444474d, y: 0.7121704530818432d), radius: 0.5745713225340506d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058428232134548d, y: 0.1783350539893559d), radius: 0.18006652473951779d),
},
            new NpgsqlCirclecircle0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005201805674063031d, y: 0.3866293298704453d), radius: 0.27493512478564497d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5289264368993554d, y: 0.5792735000273395d), radius: 0.574446878268488d),
},
            new NpgsqlCirclecircle0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4495611102357242d, y: 0.49833334481406133d), radius: 0.21595096727030372d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7398961178758778d, y: 0.36620676463937796d), radius: 0.0758752658823868d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018990535759973892d, y: 0.9306262334466007d), radius: 0.5356091771287183d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8740705055792078d, y: 0.9153782272323441d), radius: 0.7514746133574418d),
},
            new NpgsqlCirclecircle0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9700355411487765d, y: 0.4355207241637138d), radius: 0.222066683315303d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058230920246983064d, y: 0.5360577066669494d), radius: 0.955083922104961d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7396457291229704d, y: 0.6702054632822855d), radius: 0.6649199623436004d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668850112197012d, y: 0.426008117344463d), radius: 0.3143623399150969d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5241148365074798d, y: 0.8506419260651825d), radius: 0.7083421860709417d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29922181607908716d, y: 0.10076727984806955d), radius: 0.998717122842705d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7458900655488023d, y: 0.276674957676905d), radius: 0.3264966534259037d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6718995763032973d, y: 0.6864635259629391d), radius: 0.6604688057134759d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8059562150997894d, y: 0.934124177314978d), radius: 0.8388863686127743d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777790313610583d, y: 0.7981865153616047d), radius: 0.16600579564468176d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5409965325217782d, y: 0.8407178854639277d), radius: 0.5447477144265794d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.128832654842434d, y: 0.359412587706456d), radius: 0.6547872042683552d),
},
            new NpgsqlCirclecircle0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9472316349572026d, y: 0.21633611783519435d), radius: 0.22085340327831204d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357972382936931d, y: 0.7817638276820076d), radius: 0.861753571231122d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06289101632548d, y: 0.8946608482352995d), radius: 0.019699223860197734d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14078371990410954d, y: 0.30678618704701555d), radius: 0.10633426541766622d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9087084653723648d, y: 0.9184084892630792d), radius: 0.8690922174853725d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050594718151733d, y: 0.7463581939646696d), radius: 0.22835910074837118d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7500815038622006d, y: 0.9616359249717383d), radius: 0.4468620671454866d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6036915322319293d, y: 0.7673663889940464d), radius: 0.6047166305147554d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757588607966423d, y: 0.8964044377860131d), radius: 0.9699188746628422d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6856992693499045d, y: 0.27641494140735656d), radius: 0.4470803468163582d),
},
            new NpgsqlCirclecircle0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3185046125675739d, y: 0.09216962710619803d), radius: 0.23827103063119137d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007314350262326075d, y: 0.11570768637336903d), radius: 0.8919196614972019d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6307844959682134d, y: 0.7639283664381368d), radius: 0.6859341357746954d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5466828401300602d, y: 0.7656897664146207d), radius: 0.4249346194336754d),
},
            new NpgsqlCirclecircle0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746774872352259d, y: 0.9818435263833115d), radius: 0.5389825765780231d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492783235037578d, y: 0.8906823875537603d), radius: 0.7122846562895484d),
},
            new NpgsqlCirclecircle0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8008595052905205d, y: 0.6848046446976943d), radius: 0.9383400495435742d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39663463950960676d, y: 0.7083709258965765d), radius: 0.865709365566885d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4687710972277669d, y: 0.7945718064064295d), radius: 0.37149339173239915d),
},
            new NpgsqlCirclecircle0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746570828457895d, y: 0.6154698588076393d), radius: 0.32058936208435485d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2750226225924761d, y: 0.7794447371668093d), radius: 0.8543340422720196d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588256858504551d, y: 0.7733938693886719d), radius: 0.6403556194304253d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02286704378970328d, y: 0.40566828321569726d), radius: 0.04600954604490759d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9186473070878275d, y: 0.4544736700570321d), radius: 0.10065409521293878d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19361640882262166d, y: 0.7021416947035672d), radius: 0.5556087519275836d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13592844136590743d, y: 0.3991569411436541d), radius: 0.714999409645983d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299493238255242d, y: 0.7041634745844164d), radius: 0.30304610725945247d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6359272955127869d, y: 0.24131836816786723d), radius: 0.9553297204275574d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9575189753753723d, y: 0.682481686337034d), radius: 0.501579788475125d),
},
            new NpgsqlCirclecircle0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9059613360346064d, y: 0.3715517999924415d), radius: 0.16715059333378735d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07127172470864584d, y: 0.08474392833849964d), radius: 0.09539220077600108d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24844700972338407d, y: 0.43552494529556374d), radius: 0.343032205918519d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542478634634745d, y: 0.19456942758376772d), radius: 0.1115554395318662d),
},
            new NpgsqlCirclecircle0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3472675349281603d, y: 0.0416760237376822d), radius: 0.9665424578918781d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33145733840758707d, y: 0.8442810961784356d), radius: 0.14751449025102448d),
},
            new NpgsqlCirclecircle0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34560982188238687d, y: 0.7595710023185112d), radius: 0.31820925941487777d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7190704185828972d, y: 0.5913450372405619d), radius: 0.49669400079726955d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8802542781075849d, y: 0.6206752030137295d), radius: 0.15147228511707223d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48163880715334106d, y: 0.9586785347581276d), radius: 0.6312652838503966d),
},
            new NpgsqlCirclecircle0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9967409269953353d, y: 0.3195145896312588d), radius: 0.657139134902232d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8763927100639699d, y: 0.3199334308914068d), radius: 0.3246783657692536d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3756590182683325d, y: 0.4177994663812391d), radius: 0.1554372424962438d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7298527021350482d, y: 0.9498200937813599d), radius: 0.23671766518503035d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254481383062481d, y: 0.7350545914123242d), radius: 0.012931957516049586d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8165261538779653d, y: 0.03988643078034637d), radius: 0.2314060978139807d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.873913916622789d, y: 0.8122230568816443d), radius: 0.5593366798492726d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5558552173293998d, y: 0.5645576018417623d), radius: 0.47293243185285194d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.700280160069998d, y: 0.757635732548747d), radius: 0.9524451644035483d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
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
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781602260203466d, y: 0.6953904924513133d), radius: 0.8174295760701579d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058428232134548d, y: 0.1783350539893559d), radius: 0.18006652473951779d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5289264368993554d, y: 0.5792735000273395d), radius: 0.574446878268488d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8740705055792078d, y: 0.9153782272323441d), radius: 0.7514746133574418d)));
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
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
            queryMapTypes: null,
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
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 42;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[34], false);
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
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 102, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 52, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[34], false);
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 30, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[24],_testData[29], false);
                NpgsqlCirclecircle0M.AssertModel(models[25],_testData[30], false);
                NpgsqlCirclecircle0M.AssertModel(models[26],_testData[31], false);
                NpgsqlCirclecircle0M.AssertModel(models[27],_testData[32], false);
                NpgsqlCirclecircle0M.AssertModel(models[28],_testData[33], false);
                NpgsqlCirclecircle0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[29], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[30], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[31], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[32], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[33], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[34], false);
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
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6849241902265956d, y: 0.7943660768025833d), radius: 0.15113324043313803d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1988797262484826d, y: 0.4594895054570194d), radius: 0.8738838176539654d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991186368825114d, y: 0.5166038834257121d), radius: 0.32438350503371816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10764895010542197d, y: 0.8205340078762398d), radius: 0.6701110640178884d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5059913640808019d, y: 0.8505664282178794d), radius: 0.29088521692408553d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04107362697838801d, y: 0.006428881541678311d), radius: 0.3534919811576236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29466714743003175d, y: 0.3817980605193052d), radius: 0.8009827057102448d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3653637946335415d, y: 0.14106888097849113d), radius: 0.6440510871347261d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3369384951870361d, y: 0.43826444193540737d), radius: 0.1867634835234795d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18306824693448331d, y: 0.7984050858389963d), radius: 0.9519042911573384d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781602260203466d, y: 0.6953904924513133d), radius: 0.8174295760701579d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11627264242568225d, y: 0.19090272791146856d), radius: 0.9861996059678324d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557162834620289d, y: 0.26833834637971155d), radius: 0.8310137214526042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26600422207444474d, y: 0.7121704530818432d), radius: 0.5745713225340506d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058428232134548d, y: 0.1783350539893559d), radius: 0.18006652473951779d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005201805674063031d, y: 0.3866293298704453d), radius: 0.27493512478564497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5289264368993554d, y: 0.5792735000273395d), radius: 0.574446878268488d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4495611102357242d, y: 0.49833334481406133d), radius: 0.21595096727030372d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7398961178758778d, y: 0.36620676463937796d), radius: 0.0758752658823868d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018990535759973892d, y: 0.9306262334466007d), radius: 0.5356091771287183d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8740705055792078d, y: 0.9153782272323441d), radius: 0.7514746133574418d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9700355411487765d, y: 0.4355207241637138d), radius: 0.222066683315303d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058230920246983064d, y: 0.5360577066669494d), radius: 0.955083922104961d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7396457291229704d, y: 0.6702054632822855d), radius: 0.6649199623436004d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668850112197012d, y: 0.426008117344463d), radius: 0.3143623399150969d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5241148365074798d, y: 0.8506419260651825d), radius: 0.7083421860709417d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29922181607908716d, y: 0.10076727984806955d), radius: 0.998717122842705d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7458900655488023d, y: 0.276674957676905d), radius: 0.3264966534259037d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6718995763032973d, y: 0.6864635259629391d), radius: 0.6604688057134759d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8059562150997894d, y: 0.934124177314978d), radius: 0.8388863686127743d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777790313610583d, y: 0.7981865153616047d), radius: 0.16600579564468176d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5409965325217782d, y: 0.8407178854639277d), radius: 0.5447477144265794d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.128832654842434d, y: 0.359412587706456d), radius: 0.6547872042683552d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9472316349572026d, y: 0.21633611783519435d), radius: 0.22085340327831204d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357972382936931d, y: 0.7817638276820076d), radius: 0.861753571231122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06289101632548d, y: 0.8946608482352995d), radius: 0.019699223860197734d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14078371990410954d, y: 0.30678618704701555d), radius: 0.10633426541766622d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9087084653723648d, y: 0.9184084892630792d), radius: 0.8690922174853725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050594718151733d, y: 0.7463581939646696d), radius: 0.22835910074837118d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7500815038622006d, y: 0.9616359249717383d), radius: 0.4468620671454866d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6036915322319293d, y: 0.7673663889940464d), radius: 0.6047166305147554d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757588607966423d, y: 0.8964044377860131d), radius: 0.9699188746628422d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6856992693499045d, y: 0.27641494140735656d), radius: 0.4470803468163582d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3185046125675739d, y: 0.09216962710619803d), radius: 0.23827103063119137d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007314350262326075d, y: 0.11570768637336903d), radius: 0.8919196614972019d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6307844959682134d, y: 0.7639283664381368d), radius: 0.6859341357746954d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5466828401300602d, y: 0.7656897664146207d), radius: 0.4249346194336754d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746774872352259d, y: 0.9818435263833115d), radius: 0.5389825765780231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492783235037578d, y: 0.8906823875537603d), radius: 0.7122846562895484d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8008595052905205d, y: 0.6848046446976943d), radius: 0.9383400495435742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39663463950960676d, y: 0.7083709258965765d), radius: 0.865709365566885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4687710972277669d, y: 0.7945718064064295d), radius: 0.37149339173239915d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746570828457895d, y: 0.6154698588076393d), radius: 0.32058936208435485d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2750226225924761d, y: 0.7794447371668093d), radius: 0.8543340422720196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588256858504551d, y: 0.7733938693886719d), radius: 0.6403556194304253d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02286704378970328d, y: 0.40566828321569726d), radius: 0.04600954604490759d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9186473070878275d, y: 0.4544736700570321d), radius: 0.10065409521293878d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19361640882262166d, y: 0.7021416947035672d), radius: 0.5556087519275836d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13592844136590743d, y: 0.3991569411436541d), radius: 0.714999409645983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299493238255242d, y: 0.7041634745844164d), radius: 0.30304610725945247d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6359272955127869d, y: 0.24131836816786723d), radius: 0.9553297204275574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9575189753753723d, y: 0.682481686337034d), radius: 0.501579788475125d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9059613360346064d, y: 0.3715517999924415d), radius: 0.16715059333378735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07127172470864584d, y: 0.08474392833849964d), radius: 0.09539220077600108d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24844700972338407d, y: 0.43552494529556374d), radius: 0.343032205918519d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542478634634745d, y: 0.19456942758376772d), radius: 0.1115554395318662d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3472675349281603d, y: 0.0416760237376822d), radius: 0.9665424578918781d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33145733840758707d, y: 0.8442810961784356d), radius: 0.14751449025102448d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34560982188238687d, y: 0.7595710023185112d), radius: 0.31820925941487777d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7190704185828972d, y: 0.5913450372405619d), radius: 0.49669400079726955d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8802542781075849d, y: 0.6206752030137295d), radius: 0.15147228511707223d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48163880715334106d, y: 0.9586785347581276d), radius: 0.6312652838503966d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9967409269953353d, y: 0.3195145896312588d), radius: 0.657139134902232d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8763927100639699d, y: 0.3199334308914068d), radius: 0.3246783657692536d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3756590182683325d, y: 0.4177994663812391d), radius: 0.1554372424962438d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7298527021350482d, y: 0.9498200937813599d), radius: 0.23671766518503035d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254481383062481d, y: 0.7350545914123242d), radius: 0.012931957516049586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8165261538779653d, y: 0.03988643078034637d), radius: 0.2314060978139807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.873913916622789d, y: 0.8122230568816443d), radius: 0.5593366798492726d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5558552173293998d, y: 0.5645576018417623d), radius: 0.47293243185285194d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.700280160069998d, y: 0.757635732548747d), radius: 0.9524451644035483d))));//Value

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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6849241902265956d, y: 0.7943660768025833d), radius: 0.15113324043313803d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1988797262484826d, y: 0.4594895054570194d), radius: 0.8738838176539654d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991186368825114d, y: 0.5166038834257121d), radius: 0.32438350503371816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10764895010542197d, y: 0.8205340078762398d), radius: 0.6701110640178884d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5059913640808019d, y: 0.8505664282178794d), radius: 0.29088521692408553d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04107362697838801d, y: 0.006428881541678311d), radius: 0.3534919811576236d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29466714743003175d, y: 0.3817980605193052d), radius: 0.8009827057102448d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3653637946335415d, y: 0.14106888097849113d), radius: 0.6440510871347261d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3369384951870361d, y: 0.43826444193540737d), radius: 0.1867634835234795d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18306824693448331d, y: 0.7984050858389963d), radius: 0.9519042911573384d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781602260203466d, y: 0.6953904924513133d), radius: 0.8174295760701579d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11627264242568225d, y: 0.19090272791146856d), radius: 0.9861996059678324d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557162834620289d, y: 0.26833834637971155d), radius: 0.8310137214526042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26600422207444474d, y: 0.7121704530818432d), radius: 0.5745713225340506d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058428232134548d, y: 0.1783350539893559d), radius: 0.18006652473951779d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005201805674063031d, y: 0.3866293298704453d), radius: 0.27493512478564497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5289264368993554d, y: 0.5792735000273395d), radius: 0.574446878268488d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4495611102357242d, y: 0.49833334481406133d), radius: 0.21595096727030372d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7398961178758778d, y: 0.36620676463937796d), radius: 0.0758752658823868d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018990535759973892d, y: 0.9306262334466007d), radius: 0.5356091771287183d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8740705055792078d, y: 0.9153782272323441d), radius: 0.7514746133574418d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9700355411487765d, y: 0.4355207241637138d), radius: 0.222066683315303d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058230920246983064d, y: 0.5360577066669494d), radius: 0.955083922104961d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7396457291229704d, y: 0.6702054632822855d), radius: 0.6649199623436004d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668850112197012d, y: 0.426008117344463d), radius: 0.3143623399150969d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5241148365074798d, y: 0.8506419260651825d), radius: 0.7083421860709417d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29922181607908716d, y: 0.10076727984806955d), radius: 0.998717122842705d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7458900655488023d, y: 0.276674957676905d), radius: 0.3264966534259037d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6718995763032973d, y: 0.6864635259629391d), radius: 0.6604688057134759d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8059562150997894d, y: 0.934124177314978d), radius: 0.8388863686127743d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777790313610583d, y: 0.7981865153616047d), radius: 0.16600579564468176d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5409965325217782d, y: 0.8407178854639277d), radius: 0.5447477144265794d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.128832654842434d, y: 0.359412587706456d), radius: 0.6547872042683552d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9472316349572026d, y: 0.21633611783519435d), radius: 0.22085340327831204d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357972382936931d, y: 0.7817638276820076d), radius: 0.861753571231122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06289101632548d, y: 0.8946608482352995d), radius: 0.019699223860197734d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14078371990410954d, y: 0.30678618704701555d), radius: 0.10633426541766622d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9087084653723648d, y: 0.9184084892630792d), radius: 0.8690922174853725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050594718151733d, y: 0.7463581939646696d), radius: 0.22835910074837118d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7500815038622006d, y: 0.9616359249717383d), radius: 0.4468620671454866d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6036915322319293d, y: 0.7673663889940464d), radius: 0.6047166305147554d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757588607966423d, y: 0.8964044377860131d), radius: 0.9699188746628422d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6856992693499045d, y: 0.27641494140735656d), radius: 0.4470803468163582d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3185046125675739d, y: 0.09216962710619803d), radius: 0.23827103063119137d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007314350262326075d, y: 0.11570768637336903d), radius: 0.8919196614972019d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6307844959682134d, y: 0.7639283664381368d), radius: 0.6859341357746954d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5466828401300602d, y: 0.7656897664146207d), radius: 0.4249346194336754d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746774872352259d, y: 0.9818435263833115d), radius: 0.5389825765780231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492783235037578d, y: 0.8906823875537603d), radius: 0.7122846562895484d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8008595052905205d, y: 0.6848046446976943d), radius: 0.9383400495435742d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39663463950960676d, y: 0.7083709258965765d), radius: 0.865709365566885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4687710972277669d, y: 0.7945718064064295d), radius: 0.37149339173239915d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746570828457895d, y: 0.6154698588076393d), radius: 0.32058936208435485d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2750226225924761d, y: 0.7794447371668093d), radius: 0.8543340422720196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588256858504551d, y: 0.7733938693886719d), radius: 0.6403556194304253d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02286704378970328d, y: 0.40566828321569726d), radius: 0.04600954604490759d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9186473070878275d, y: 0.4544736700570321d), radius: 0.10065409521293878d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19361640882262166d, y: 0.7021416947035672d), radius: 0.5556087519275836d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13592844136590743d, y: 0.3991569411436541d), radius: 0.714999409645983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299493238255242d, y: 0.7041634745844164d), radius: 0.30304610725945247d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6359272955127869d, y: 0.24131836816786723d), radius: 0.9553297204275574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9575189753753723d, y: 0.682481686337034d), radius: 0.501579788475125d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9059613360346064d, y: 0.3715517999924415d), radius: 0.16715059333378735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07127172470864584d, y: 0.08474392833849964d), radius: 0.09539220077600108d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24844700972338407d, y: 0.43552494529556374d), radius: 0.343032205918519d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542478634634745d, y: 0.19456942758376772d), radius: 0.1115554395318662d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3472675349281603d, y: 0.0416760237376822d), radius: 0.9665424578918781d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33145733840758707d, y: 0.8442810961784356d), radius: 0.14751449025102448d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34560982188238687d, y: 0.7595710023185112d), radius: 0.31820925941487777d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7190704185828972d, y: 0.5913450372405619d), radius: 0.49669400079726955d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8802542781075849d, y: 0.6206752030137295d), radius: 0.15147228511707223d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48163880715334106d, y: 0.9586785347581276d), radius: 0.6312652838503966d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9967409269953353d, y: 0.3195145896312588d), radius: 0.657139134902232d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8763927100639699d, y: 0.3199334308914068d), radius: 0.3246783657692536d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3756590182683325d, y: 0.4177994663812391d), radius: 0.1554372424962438d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7298527021350482d, y: 0.9498200937813599d), radius: 0.23671766518503035d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254481383062481d, y: 0.7350545914123242d), radius: 0.012931957516049586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8165261538779653d, y: 0.03988643078034637d), radius: 0.2314060978139807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.873913916622789d, y: 0.8122230568816443d), radius: 0.5593366798492726d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5558552173293998d, y: 0.5645576018417623d), radius: 0.47293243185285194d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.700280160069998d, y: 0.757635732548747d), radius: 0.9524451644035483d))));//Value

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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI), typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

