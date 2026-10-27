

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
    internal partial interface IDecimalMArraynumericMMArrayD2
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD2 : IDecimalMArraynumericMMArrayD2
    {


#region TestData

        private readonly DecimalnumericMMArrayD2E1M[] _testData = new DecimalnumericMMArrayD2E1M[]
        {
            new DecimalnumericMMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Decimal[,] { { 0.724673058421709m, 0.894438528404633m, }, { 0.0100261679878845m, 0.379692156103002m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Decimal[,] { { 0.494477207775601m, 0.57050486202458m, }, { 0.345508128349716m, 0.817251138008855m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Decimal[,] { { 0.119310096680747m, 0.219091291040284m, }, { 0.840895130974761m, 0.809989039062036m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.578498908904373m, 0.530024887456911m, }, { 0.473886836710011m, 0.90556845960406m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.0918214074035523m, 0.778044515558656m, }, { 0.617610099801148m, 0.896296441053047m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Decimal[,] { { 0.0629501728325456m, 0.330276145026342m, }, { 0.329958815122085m, 0.629888250131075m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.969224653931658m, 0.615391087711242m, }, { 0.316434469514937m, 0.117181729954804m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Decimal[,] { { 0.9842756094984m, 0.742792589885264m, }, { 0.599552241764882m, 0.612008058345352m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Decimal[,] { { 0.889154925431821m, 0.136314951614792m, }, { 0.64500136389308m, 0.0563870172713874m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.671153337307148m, 0.390518230393996m, }, { 0.947102176632694m, 0.694188568585918m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Decimal[,] { { 0.42492409490721m, 0.847438478004487m, }, { 0.150417646780444m, 0.0782708826738551m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Decimal[,] { { 0.42873610217218m, 0.0161638232795354m, }, { 0.539634283647983m, 0.534283745151975m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Decimal[,] { { 0.465394619923638m, 0.617495192961873m, }, { 0.290048812587447m, 0.00533996216968191m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.22111668114084m, 0.800618369091979m, }, { 0.730059524712931m, 0.769235080160108m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Decimal[,] { { 0.57358447058542m, 0.596378640782213m, }, { 0.00455557850480326m, 0.358526615559809m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.118908032572219m, 0.103775300092737m, }, { 0.112881476159454m, 0.104081951451438m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Decimal[,] { { 0.402864155716733m, 0.221124924916392m, }, { 0.801633667695526m, 0.422778785359561m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Decimal[,] { { 0.214516193924202m, 0.389970401948566m, }, { 0.176849182263133m, 0.185213747988476m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.406254918411744m, 0.268728019232434m, }, { 0.473090507267603m, 0.321406473867234m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Decimal[,] { { 0.266775868860684m, 0.645394716842545m, }, { 0.0929787125106679m, 0.866611860953125m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.713550571189056m, 0.735901123498421m, }, { 0.160939713445088m, 0.945826189535381m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Decimal[,] { { 0.543152108049081m, 0.181526280622136m, }, { 0.232570425391843m, 0.985252804880074m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Decimal[,] { { 0.310687645380887m, 0.147359469971984m, }, { 0.147297422084876m, 0.554219214455529m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.457563112048065m, 0.258634869889957m, }, { 0.561489150471924m, 0.680521041772462m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Decimal[,] { { 0.604357315822197m, 0.571288194307706m, }, { 0.0303997138079078m, 0.480458919056763m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.676396716583415m, 0.701987771263412m, }, { 0.187751160069976m, 0.903514387294994m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Decimal[,] { { 0.97280956397264m, 0.805601511728099m, }, { 0.986227445950338m, 0.785116331269502m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Decimal[,] { { 0.901819238973118m, 0.904651974682936m, }, { 0.0985116218638794m, 0.404022429228128m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Decimal[,] { { 0.884585427462212m, 0.647841443832878m, }, { 0.365593169038053m, 0.607104973504468m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.712474351341611m, 0.138483336806089m, }, { 0.113373348608794m, 0.580412935810211m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Decimal[,] { { 0.306066521138558m, 0.128273494450485m, }, { 0.765546656753138m, 0.855846244934758m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Decimal[,] { { 0.420703817135016m, 0.392188121822933m, }, { 0.885770300933175m, 0.180601540213197m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.777762820504409m, 0.158227840977546m, }, { 0.711527774866558m, 0.333926137571372m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Decimal[,] { { 0.710292480281727m, 0.861586795014744m, }, { 0.273510107450625m, 0.552536896618812m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.781086747113779m, 0.528356267199235m, }, { 0.0515634936237366m, 0.717360986981227m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Decimal[,] { { 0.706641251290465m, 0.635000297559984m, }, { 0.00927958926755901m, 0.441528093832189m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Decimal[,] { { 0.136490693125441m, 0.694136005750649m, }, { 0.428603614660494m, 0.306784956536766m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.198057540981001m, 0.871198598696592m, }, { 0.07595870672069m, 0.421224380243025m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.147987258450567m, 0.119611726676786m, }, { 0.88878320961441m, 0.803928127616919m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Decimal[,] { { 0.941703613365183m, 0.249204468879161m, }, { 0.480539646045966m, 0.531247935842915m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Decimal[,] { { 0.0610461968901044m, 0.055183874746744m, }, { 0.591160986317575m, 0.72867779658117m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Decimal[,] { { 0.910101122010148m, 0.921518299240259m, }, { 0.529725920411464m, 0.0950885498540479m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.235100456116129m, 0.58054799553265m, }, { 0.883981352428684m, 0.411701234553237m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.849939684002244m, 0.307336815812162m, }, { 0.785439711740402m, 0.473811539084451m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Decimal[,] { { 0.62134006383709m, 0.121057437279107m, }, { 0.549099520576582m, 0.303121681296527m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.855026641428243m, 0.319698882151848m, }, { 0.233920280064667m, 0.268536095768083m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Decimal[,] { { 0.233959877946918m, 0.224602997770831m, }, { 0.118814306463899m, 0.00968768660751307m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Decimal[,] { { 0.434002110700391m, 0.959330651474739m, }, { 0.844062826411463m, 0.33270164717647m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.125231757038431m, 0.0850846902809467m, }, { 0.903088943026627m, 0.86885968255525m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.748471587509801m, 0.0924486534652698m, }, { 0.806001171199471m, 0.355722243010624m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Decimal[,] { { 0.0829683571961511m, 0.411825888890992m, }, { 0.222291982196038m, 0.828143939989501m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.404849191307222m, 0.258215815606129m, }, { 0.63629779960393m, 0.746600439780712m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Decimal[,] { { 0.678583734880238m, 0.590465067959005m, }, { 0.0988253796794505m, 0.977883403254616m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Decimal[,] { { 0.0405095104246029m, 0.0203836677172812m, }, { 0.408104543173957m, 0.338601357971564m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Decimal[,] { { 0.235808939472519m, 0.772735654134013m, }, { 0.348818720311187m, 0.488043763792244m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Decimal[,] { { 0.602770959673022m, 0.087879304759523m, }, { 0.0545469125577306m, 0.0733971523297959m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Decimal[,] { { 0.675968858689909m, 0.806688184494858m, }, { 0.0458830672385178m, 0.880533094829494m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.0355449446695796m, 0.221129870569791m, }, { 0.707720359664086m, 0.852995219594096m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Decimal[,] { { 0.838670937416341m, 0.318542814131491m, }, { 0.310197876491672m, 0.0655152558802774m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Decimal[,] { { 0.860773536770557m, 0.630232281166078m, }, { 0.168564086703171m, 0.942896762878601m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Decimal[,] { { 0.438266474386225m, 0.0644278195432579m, }, { 0.944513301946761m, 0.0174494002071588m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Decimal[,] { { 0.489570421155926m, 0.578742716494341m, }, { 0.958516190858748m, 0.401038556711339m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.000126443273905319m, 0.199625763805228m, }, { 0.928867459877558m, 0.906206842914358m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Decimal[,] { { 0.789086042121644m, 0.276297937371564m, }, { 0.343677824603794m, 0.138853188007813m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Decimal[,] { { 0.473406094514002m, 0.412453330832545m, }, { 0.160366081411814m, 0.465563406645685m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.0261616132037454m, 0.788912755093385m, }, { 0.230558770539482m, 0.822022742009317m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.00833680214373533m, 0.525906194330269m, }, { 0.0804755819013493m, 0.92774081995145m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Decimal[,] { { 0.865958177254527m, 0.708978075456852m, }, { 0.881371829222114m, 0.141566585511871m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.850540942922779m, 0.586198975804358m, }, { 0.281525771207939m, 0.326508236294258m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Decimal[,] { { 0.546832324528448m, 0.298316368377407m, }, { 0.262662197124781m, 0.501340652430363m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Decimal[,] { { 0.709639291840253m, 0.251234232176927m, }, { 0.493119163792361m, 0.146026946759378m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.59493972430098m, 0.750909688241397m, }, { 0.263837602612476m, 0.547233792781719m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.533683096067676m, 0.578655922640916m, }, { 0.549980014532439m, 0.470902542990737m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Decimal[,] { { 0.148619325614753m, 0.637021285792187m, }, { 0.614929047844929m, 0.745846499965087m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.244320255172528m, 0.205387614856388m, }, { 0.845526067214993m, 0.888056846583242m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Decimal[,] { { 0.394904378871358m, 0.367743251706205m, }, { 0.706601778377378m, 0.693609747721644m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Decimal[,] { { 0.309244845758569m, 0.0455612128987259m, }, { 0.60275998039023m, 0.107535144038274m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.383321471057627m, 0.868792566180506m, }, { 0.426963791667291m, 0.311601951166884m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.81989230986655m, 0.427055678726744m, }, { 0.962052567412252m, 0.236265979748394m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Decimal[,] { { 0.807097675535592m, 0.993574474651028m, }, { 0.208374079041869m, 0.719962845457987m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.504400848490139m, 0.651298042561903m, }, { 0.445835963432016m, 0.728646112565291m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Decimal[,] { { 0.488242321050996m, 0.257236204488818m, }, { 0.122025702270967m, 0.742732846338436m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Decimal[,] { { 0.80144677720102m, 0.92410523119978m, }, { 0.0244112979480251m, 0.692724969152572m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.000901119996034039m, 0.273657835760164m, }, { 0.710002175734543m, 0.9977589817563m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Decimal[,] { { 0.128399259230193m, 0.76251916763357m, }, { 0.942701345829309m, 0.857482708860761m, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.22111668114084m, 0.800618369091979m, }, { 0.730059524712931m, 0.769235080160108m, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.118908032572219m, 0.103775300092737m, }, { 0.112881476159454m, 0.104081951451438m, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                System.Decimal[,] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.713550571189056m, 0.735901123498421m, }, { 0.160939713445088m, 0.945826189535381m, }, }));
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.676396716583415m, 0.701987771263412m, }, { 0.187751160069976m, 0.903514387294994m, }, }));
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 138, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 75, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 104, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
FROM public.binary_decimalnumericmmarrayd2e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI), typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

