

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
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8028496429335384d,right: 0.5629062991836887d,bottom: 0.3749406420555018d,left: 0.20400882027438672d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6611800595616306d,right: 0.6517132801805811d,bottom: 0.5464592404563298d,left: 0.11028390744465166d),
},
            new NpgsqlBoxboxE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9502124467592254d,right: 0.8413721609945877d,bottom: 0.6383651535944389d,left: 0.17813218152854648d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9843843324254677d,right: 0.6873238714228851d,bottom: 0.6017570021892721d,left: 0.5614055302828067d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2625450672058468d,right: 0.46069556064628425d,bottom: 0.24396159802158068d,left: 0.3314558963107591d),
},
            new NpgsqlBoxboxE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5661845844095167d,right: 0.16277681165983393d,bottom: 0.3303435536706809d,left: 0.05841515705513045d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3147868747249781d,right: 0.6223999738908097d,bottom: 0.08791180833257184d,left: 0.28431108322697096d),
},
            new NpgsqlBoxboxE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6384974190797437d,right: 0.8597251500065025d,bottom: 0.289389255408827d,left: 0.4129293348665387d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8619660949811836d,right: 0.5608565991186398d,bottom: 0.09983258342010837d,left: 0.04015380319731332d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9315951677252777d,right: 0.6385371607601723d,bottom: 0.028695341468002566d,left: 0.5689509300611407d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5159255360127096d,right: 0.8829802195775359d,bottom: 0.17965217272205258d,left: 0.5474228888637044d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7950321272267556d,right: 0.06186801615681381d,bottom: 0.41022461198940585d,left: 0.01310268604032927d),
},
            new NpgsqlBoxboxE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7136642265306996d,right: 0.5425947202055205d,bottom: 0.16352068217304538d,left: 0.26028981606870416d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9075186319111399d,right: 0.19532361390491393d,bottom: 0.46650672624524037d,left: 0.178189972196374d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.14846585872113371d,right: 0.8631106933651216d,bottom: 0.13443082828102138d,left: 0.2050225726198608d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9543038062229059d,right: 0.6571966186687742d,bottom: 0.682574437406668d,left: 0.172590149446746d),
},
            new NpgsqlBoxboxE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6301789595907089d,right: 0.41737474970682d,bottom: 0.16837420294426741d,left: 0.3232232871083097d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8076892195817198d,right: 0.8836453560467111d,bottom: 0.4757889096614989d,left: 0.8657540265939925d),
},
            new NpgsqlBoxboxE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9623483915687301d,right: 0.9626784602624504d,bottom: 0.3622290296328664d,left: 0.3449667205605357d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9574964280215278d,right: 0.3606242883142453d,bottom: 0.5173130254919872d,left: 0.14727195915410363d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3152637136528812d,right: 0.7506302961273162d,bottom: 0.06044518511329555d,left: 0.6462172396190868d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4925490541496773d,right: 0.7394707178021375d,bottom: 0.4589887717149558d,left: 0.5350218702722261d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9799030338260827d,right: 0.5342868567402429d,bottom: 0.49768508835742886d,left: 0.444978568615642d),
},
            new NpgsqlBoxboxE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6085633260012304d,right: 0.9028223980577069d,bottom: 0.10150296561188621d,left: 0.3202068147498164d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6696442871840734d,right: 0.6792633460138309d,bottom: 0.6489940234175735d,left: 0.3573426599837958d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9100113318392168d,right: 0.33139189814135095d,bottom: 0.41575038118203655d,left: 0.14073168696670624d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4717579128130136d,right: 0.7565025665857462d,bottom: 0.17486949792721784d,left: 0.4515138391744803d),
},
            new NpgsqlBoxboxE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.42741756075268356d,right: 0.20917089271535616d,bottom: 0.08411227237797081d,left: 0.06312231065197493d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.988832866553114d,right: 0.8711283923756628d,bottom: 0.6236251090248496d,left: 0.4706647559921524d),
},
            new NpgsqlBoxboxE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5790864585591038d,right: 0.18802384290185448d,bottom: 0.3962233694958154d,left: 0.07255425996124132d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6528810753943363d,right: 0.30316161501319316d,bottom: 0.5921226313652288d,left: 0.04229453516491399d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5008339887750546d,right: 0.195742010375475d,bottom: 0.1221144367024809d,left: 0.048619022803273015d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6234279822285521d,right: 0.8654350522273158d,bottom: 0.05522372798030817d,left: 0.3302195911933925d),
},
            new NpgsqlBoxboxE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7537717332187446d,right: 0.7063227892170313d,bottom: 0.6810310037947118d,left: 0.08552660660981481d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7090345756512738d,right: 0.7505665819201058d,bottom: 0.3370090839777553d,left: 0.1487768708877547d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.301255399164188d,right: 0.4378445444612141d,bottom: 0.08645784420340696d,left: 0.42716432211844346d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8963857098901581d,right: 0.8748156088685143d,bottom: 0.1134267433808458d,left: 0.07136058476257423d),
},
            new NpgsqlBoxboxE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6182878609345155d,right: 0.9002780905564451d,bottom: 0.5162606680991184d,left: 0.3934092068101256d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1562210401898212d,right: 0.9749321057905789d,bottom: 0.1230704052232886d,left: 0.18317349494464175d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46009706055363d,right: 0.5420508093938531d,bottom: 0.020030940848290157d,left: 0.27812222422420574d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6408151209102275d,right: 0.8980498210192585d,bottom: 0.57568261859685d,left: 0.5756387933945307d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3715358130169041d,right: 0.22893140065360995d,bottom: 0.11431190023320448d,left: 0.08585287033580358d),
},
            new NpgsqlBoxboxE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7736211275864537d,right: 0.7143790293422977d,bottom: 0.3512182826508825d,left: 0.43647393421628655d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7959478984061082d,right: 0.8783484870933063d,bottom: 0.09541134951989061d,left: 0.7193844081895774d),
},
            new NpgsqlBoxboxE0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9423755434556538d,right: 0.9773421041343083d,bottom: 0.3023077704844116d,left: 0.36814081713529656d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5788988488286555d,right: 0.9058090507815745d,bottom: 0.47146163609713754d,left: 0.809834070620479d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2834920993125696d,right: 0.6634068887571194d,bottom: 0.0754576612354314d,left: 0.5888882929169994d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5125389931564274d,right: 0.9241371722437304d,bottom: 0.29412281837747933d,left: 0.7281389666408814d),
},
            new NpgsqlBoxboxE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4952307447963391d,right: 0.7595995606134601d,bottom: 0.0374280474733788d,left: 0.028664054140854378d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6035553997505159d,right: 0.5599472482426703d,bottom: 0.16772398383150033d,left: 0.0004689672732728356d),
},
            new NpgsqlBoxboxE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5412542079044987d,right: 0.24355490287132087d,bottom: 0.3480610743650062d,left: 0.10177610521655178d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9580249309742109d,right: 0.9161214297331104d,bottom: 0.20403745599727585d,left: 0.6049235187656342d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7858423795995795d,right: 0.9450032290170441d,bottom: 0.29408916704400156d,left: 0.4345752405726673d),
},
            new NpgsqlBoxboxE0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5220598620980014d,right: 0.718481994944571d,bottom: 0.3108744171476824d,left: 0.3355304878528016d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1666736324693745d,right: 0.9129776928716302d,bottom: 0.1244812024053259d,left: 0.5311873487681852d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.42884871104586253d,right: 0.8639317567141531d,bottom: 0.36971086394781816d,left: 0.24836099006329881d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5638126189572114d,right: 0.7205165181833846d,bottom: 0.1529996895153417d,left: 0.4315359288218761d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6877387652165879d,right: 0.9197721464100352d,bottom: 0.5116006796868452d,left: 0.448223647089269d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.29513540872193755d,right: 0.8127215664561991d,bottom: 0.15754932329458138d,left: 0.7441071389813376d),
},
            new NpgsqlBoxboxE0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9935259572657754d,right: 0.3401656834920177d,bottom: 0.25067504252496864d,left: 0.26272411615533076d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6025369361192101d,right: 0.8656450580865152d,bottom: 0.10120431181462686d,left: 0.35370021643994876d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4626735417986634d,right: 0.9254438084063131d,bottom: 0.10764803275617496d,left: 0.0954031190005934d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8014552641862656d,right: 0.4593552592914204d,bottom: 0.536782842049843d,left: 0.04069024973642066d),
},
            new NpgsqlBoxboxE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.06314175498547114d,right: 0.44756918774482246d,bottom: 0.004334097373426826d,left: 0.3619037851553588d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5767660318917477d,right: 0.7576624297841318d,bottom: 0.05474606603128063d,left: 0.4403118640603655d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8141954669041623d,right: 0.7364871721275681d,bottom: 0.1790707483345806d,left: 0.6765839145141308d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9207691030228368d,right: 0.9316529956206088d,bottom: 0.18146884216740156d,left: 0.5526554620691051d),
},
            new NpgsqlBoxboxE0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8140252361586632d,right: 0.7959783129016116d,bottom: 0.15251853762020517d,left: 0.7721663206030162d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6640449899197591d,right: 0.8299683521054859d,bottom: 0.5070171791641651d,left: 0.5254784840152641d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8457700936569491d,right: 0.14305522023658312d,bottom: 0.07708497831191541d,left: 0.09019115880838624d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6745732549626228d,right: 0.7508607160596319d,bottom: 0.28723275504733636d,left: 0.31154537053428055d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43509372612674524d,right: 0.5998145584629028d,bottom: 0.06604246769199706d,left: 0.32131914824707764d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9941062330926272d,right: 0.9770916229950907d,bottom: 0.8976680597430802d,left: 0.38478645113881416d),
},
            new NpgsqlBoxboxE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9953064379033377d,right: 0.3365125144759332d,bottom: 0.23576458152634439d,left: 0.010731775064732219d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8604334332100354d,right: 0.4760766949181985d,bottom: 0.1582880034089943d,left: 0.0017290525171201887d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9950952763625804d,right: 0.2283612118076005d,bottom: 0.047292170010380774d,left: 0.02997948492376923d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.51407466264277d,right: 0.9533387985916489d,bottom: 0.0009347081504094135d,left: 0.3432451269541621d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.65951991800486d,right: 0.3877947199043603d,bottom: 0.12031054477988012d,left: 0.15813802413877898d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8838114418994342d,right: 0.701927904749939d,bottom: 0.06426974119637996d,left: 0.28939190155339467d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9816879173699609d,right: 0.5676777867641659d,bottom: 0.12025164688012202d,left: 0.3995661783995378d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7055928200052807d,right: 0.765055908331012d,bottom: 0.3357969957737711d,left: 0.3392456895636746d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.858664555520903d,right: 0.829806298828085d,bottom: 0.6714143837900823d,left: 0.5235305989254113d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8516121925111005d,right: 0.28646917567027763d,bottom: 0.047069987768311616d,left: 0.26618906769374073d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7950321272267556d,right: 0.06186801615681381d,bottom: 0.41022461198940585d,left: 0.01310268604032927d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9543038062229059d,right: 0.6571966186687742d,bottom: 0.682574437406668d,left: 0.172590149446746d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8076892195817198d,right: 0.8836453560467111d,bottom: 0.4757889096614989d,left: 0.8657540265939925d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9799030338260827d,right: 0.5342868567402429d,bottom: 0.49768508835742886d,left: 0.444978568615642d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4717579128130136d,right: 0.7565025665857462d,bottom: 0.17486949792721784d,left: 0.4515138391744803d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.988832866553114d,right: 0.8711283923756628d,bottom: 0.6236251090248496d,left: 0.4706647559921524d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6234279822285521d,right: 0.8654350522273158d,bottom: 0.05522372798030817d,left: 0.3302195911933925d)));
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
                parametr1.Value = 106;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 71, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 43, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 158, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[13], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[14], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[15], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[16], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[17], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[17],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[18],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[19],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[20],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[21],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[34], false);
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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8028496429335384d,right: 0.5629062991836887d,bottom: 0.3749406420555018d,left: 0.20400882027438672d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6611800595616306d,right: 0.6517132801805811d,bottom: 0.5464592404563298d,left: 0.11028390744465166d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9502124467592254d,right: 0.8413721609945877d,bottom: 0.6383651535944389d,left: 0.17813218152854648d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9843843324254677d,right: 0.6873238714228851d,bottom: 0.6017570021892721d,left: 0.5614055302828067d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2625450672058468d,right: 0.46069556064628425d,bottom: 0.24396159802158068d,left: 0.3314558963107591d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5661845844095167d,right: 0.16277681165983393d,bottom: 0.3303435536706809d,left: 0.05841515705513045d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3147868747249781d,right: 0.6223999738908097d,bottom: 0.08791180833257184d,left: 0.28431108322697096d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6384974190797437d,right: 0.8597251500065025d,bottom: 0.289389255408827d,left: 0.4129293348665387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8619660949811836d,right: 0.5608565991186398d,bottom: 0.09983258342010837d,left: 0.04015380319731332d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9315951677252777d,right: 0.6385371607601723d,bottom: 0.028695341468002566d,left: 0.5689509300611407d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5159255360127096d,right: 0.8829802195775359d,bottom: 0.17965217272205258d,left: 0.5474228888637044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7950321272267556d,right: 0.06186801615681381d,bottom: 0.41022461198940585d,left: 0.01310268604032927d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7136642265306996d,right: 0.5425947202055205d,bottom: 0.16352068217304538d,left: 0.26028981606870416d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9075186319111399d,right: 0.19532361390491393d,bottom: 0.46650672624524037d,left: 0.178189972196374d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14846585872113371d,right: 0.8631106933651216d,bottom: 0.13443082828102138d,left: 0.2050225726198608d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9543038062229059d,right: 0.6571966186687742d,bottom: 0.682574437406668d,left: 0.172590149446746d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6301789595907089d,right: 0.41737474970682d,bottom: 0.16837420294426741d,left: 0.3232232871083097d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8076892195817198d,right: 0.8836453560467111d,bottom: 0.4757889096614989d,left: 0.8657540265939925d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9623483915687301d,right: 0.9626784602624504d,bottom: 0.3622290296328664d,left: 0.3449667205605357d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9574964280215278d,right: 0.3606242883142453d,bottom: 0.5173130254919872d,left: 0.14727195915410363d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3152637136528812d,right: 0.7506302961273162d,bottom: 0.06044518511329555d,left: 0.6462172396190868d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4925490541496773d,right: 0.7394707178021375d,bottom: 0.4589887717149558d,left: 0.5350218702722261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9799030338260827d,right: 0.5342868567402429d,bottom: 0.49768508835742886d,left: 0.444978568615642d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6085633260012304d,right: 0.9028223980577069d,bottom: 0.10150296561188621d,left: 0.3202068147498164d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6696442871840734d,right: 0.6792633460138309d,bottom: 0.6489940234175735d,left: 0.3573426599837958d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9100113318392168d,right: 0.33139189814135095d,bottom: 0.41575038118203655d,left: 0.14073168696670624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4717579128130136d,right: 0.7565025665857462d,bottom: 0.17486949792721784d,left: 0.4515138391744803d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42741756075268356d,right: 0.20917089271535616d,bottom: 0.08411227237797081d,left: 0.06312231065197493d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.988832866553114d,right: 0.8711283923756628d,bottom: 0.6236251090248496d,left: 0.4706647559921524d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5790864585591038d,right: 0.18802384290185448d,bottom: 0.3962233694958154d,left: 0.07255425996124132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6528810753943363d,right: 0.30316161501319316d,bottom: 0.5921226313652288d,left: 0.04229453516491399d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5008339887750546d,right: 0.195742010375475d,bottom: 0.1221144367024809d,left: 0.048619022803273015d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6234279822285521d,right: 0.8654350522273158d,bottom: 0.05522372798030817d,left: 0.3302195911933925d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7537717332187446d,right: 0.7063227892170313d,bottom: 0.6810310037947118d,left: 0.08552660660981481d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7090345756512738d,right: 0.7505665819201058d,bottom: 0.3370090839777553d,left: 0.1487768708877547d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.301255399164188d,right: 0.4378445444612141d,bottom: 0.08645784420340696d,left: 0.42716432211844346d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8963857098901581d,right: 0.8748156088685143d,bottom: 0.1134267433808458d,left: 0.07136058476257423d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6182878609345155d,right: 0.9002780905564451d,bottom: 0.5162606680991184d,left: 0.3934092068101256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1562210401898212d,right: 0.9749321057905789d,bottom: 0.1230704052232886d,left: 0.18317349494464175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46009706055363d,right: 0.5420508093938531d,bottom: 0.020030940848290157d,left: 0.27812222422420574d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6408151209102275d,right: 0.8980498210192585d,bottom: 0.57568261859685d,left: 0.5756387933945307d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3715358130169041d,right: 0.22893140065360995d,bottom: 0.11431190023320448d,left: 0.08585287033580358d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7736211275864537d,right: 0.7143790293422977d,bottom: 0.3512182826508825d,left: 0.43647393421628655d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7959478984061082d,right: 0.8783484870933063d,bottom: 0.09541134951989061d,left: 0.7193844081895774d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9423755434556538d,right: 0.9773421041343083d,bottom: 0.3023077704844116d,left: 0.36814081713529656d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5788988488286555d,right: 0.9058090507815745d,bottom: 0.47146163609713754d,left: 0.809834070620479d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2834920993125696d,right: 0.6634068887571194d,bottom: 0.0754576612354314d,left: 0.5888882929169994d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5125389931564274d,right: 0.9241371722437304d,bottom: 0.29412281837747933d,left: 0.7281389666408814d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4952307447963391d,right: 0.7595995606134601d,bottom: 0.0374280474733788d,left: 0.028664054140854378d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6035553997505159d,right: 0.5599472482426703d,bottom: 0.16772398383150033d,left: 0.0004689672732728356d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5412542079044987d,right: 0.24355490287132087d,bottom: 0.3480610743650062d,left: 0.10177610521655178d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9580249309742109d,right: 0.9161214297331104d,bottom: 0.20403745599727585d,left: 0.6049235187656342d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7858423795995795d,right: 0.9450032290170441d,bottom: 0.29408916704400156d,left: 0.4345752405726673d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5220598620980014d,right: 0.718481994944571d,bottom: 0.3108744171476824d,left: 0.3355304878528016d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1666736324693745d,right: 0.9129776928716302d,bottom: 0.1244812024053259d,left: 0.5311873487681852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42884871104586253d,right: 0.8639317567141531d,bottom: 0.36971086394781816d,left: 0.24836099006329881d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5638126189572114d,right: 0.7205165181833846d,bottom: 0.1529996895153417d,left: 0.4315359288218761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6877387652165879d,right: 0.9197721464100352d,bottom: 0.5116006796868452d,left: 0.448223647089269d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29513540872193755d,right: 0.8127215664561991d,bottom: 0.15754932329458138d,left: 0.7441071389813376d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9935259572657754d,right: 0.3401656834920177d,bottom: 0.25067504252496864d,left: 0.26272411615533076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6025369361192101d,right: 0.8656450580865152d,bottom: 0.10120431181462686d,left: 0.35370021643994876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4626735417986634d,right: 0.9254438084063131d,bottom: 0.10764803275617496d,left: 0.0954031190005934d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8014552641862656d,right: 0.4593552592914204d,bottom: 0.536782842049843d,left: 0.04069024973642066d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06314175498547114d,right: 0.44756918774482246d,bottom: 0.004334097373426826d,left: 0.3619037851553588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5767660318917477d,right: 0.7576624297841318d,bottom: 0.05474606603128063d,left: 0.4403118640603655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8141954669041623d,right: 0.7364871721275681d,bottom: 0.1790707483345806d,left: 0.6765839145141308d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9207691030228368d,right: 0.9316529956206088d,bottom: 0.18146884216740156d,left: 0.5526554620691051d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8140252361586632d,right: 0.7959783129016116d,bottom: 0.15251853762020517d,left: 0.7721663206030162d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6640449899197591d,right: 0.8299683521054859d,bottom: 0.5070171791641651d,left: 0.5254784840152641d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8457700936569491d,right: 0.14305522023658312d,bottom: 0.07708497831191541d,left: 0.09019115880838624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6745732549626228d,right: 0.7508607160596319d,bottom: 0.28723275504733636d,left: 0.31154537053428055d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43509372612674524d,right: 0.5998145584629028d,bottom: 0.06604246769199706d,left: 0.32131914824707764d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9941062330926272d,right: 0.9770916229950907d,bottom: 0.8976680597430802d,left: 0.38478645113881416d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9953064379033377d,right: 0.3365125144759332d,bottom: 0.23576458152634439d,left: 0.010731775064732219d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8604334332100354d,right: 0.4760766949181985d,bottom: 0.1582880034089943d,left: 0.0017290525171201887d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9950952763625804d,right: 0.2283612118076005d,bottom: 0.047292170010380774d,left: 0.02997948492376923d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.51407466264277d,right: 0.9533387985916489d,bottom: 0.0009347081504094135d,left: 0.3432451269541621d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.65951991800486d,right: 0.3877947199043603d,bottom: 0.12031054477988012d,left: 0.15813802413877898d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8838114418994342d,right: 0.701927904749939d,bottom: 0.06426974119637996d,left: 0.28939190155339467d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9816879173699609d,right: 0.5676777867641659d,bottom: 0.12025164688012202d,left: 0.3995661783995378d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7055928200052807d,right: 0.765055908331012d,bottom: 0.3357969957737711d,left: 0.3392456895636746d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.858664555520903d,right: 0.829806298828085d,bottom: 0.6714143837900823d,left: 0.5235305989254113d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8516121925111005d,right: 0.28646917567027763d,bottom: 0.047069987768311616d,left: 0.26618906769374073d))));//Value

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
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8028496429335384d,right: 0.5629062991836887d,bottom: 0.3749406420555018d,left: 0.20400882027438672d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6611800595616306d,right: 0.6517132801805811d,bottom: 0.5464592404563298d,left: 0.11028390744465166d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9502124467592254d,right: 0.8413721609945877d,bottom: 0.6383651535944389d,left: 0.17813218152854648d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9843843324254677d,right: 0.6873238714228851d,bottom: 0.6017570021892721d,left: 0.5614055302828067d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2625450672058468d,right: 0.46069556064628425d,bottom: 0.24396159802158068d,left: 0.3314558963107591d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5661845844095167d,right: 0.16277681165983393d,bottom: 0.3303435536706809d,left: 0.05841515705513045d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3147868747249781d,right: 0.6223999738908097d,bottom: 0.08791180833257184d,left: 0.28431108322697096d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6384974190797437d,right: 0.8597251500065025d,bottom: 0.289389255408827d,left: 0.4129293348665387d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8619660949811836d,right: 0.5608565991186398d,bottom: 0.09983258342010837d,left: 0.04015380319731332d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9315951677252777d,right: 0.6385371607601723d,bottom: 0.028695341468002566d,left: 0.5689509300611407d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5159255360127096d,right: 0.8829802195775359d,bottom: 0.17965217272205258d,left: 0.5474228888637044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7950321272267556d,right: 0.06186801615681381d,bottom: 0.41022461198940585d,left: 0.01310268604032927d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7136642265306996d,right: 0.5425947202055205d,bottom: 0.16352068217304538d,left: 0.26028981606870416d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9075186319111399d,right: 0.19532361390491393d,bottom: 0.46650672624524037d,left: 0.178189972196374d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.14846585872113371d,right: 0.8631106933651216d,bottom: 0.13443082828102138d,left: 0.2050225726198608d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9543038062229059d,right: 0.6571966186687742d,bottom: 0.682574437406668d,left: 0.172590149446746d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6301789595907089d,right: 0.41737474970682d,bottom: 0.16837420294426741d,left: 0.3232232871083097d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8076892195817198d,right: 0.8836453560467111d,bottom: 0.4757889096614989d,left: 0.8657540265939925d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9623483915687301d,right: 0.9626784602624504d,bottom: 0.3622290296328664d,left: 0.3449667205605357d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9574964280215278d,right: 0.3606242883142453d,bottom: 0.5173130254919872d,left: 0.14727195915410363d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3152637136528812d,right: 0.7506302961273162d,bottom: 0.06044518511329555d,left: 0.6462172396190868d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4925490541496773d,right: 0.7394707178021375d,bottom: 0.4589887717149558d,left: 0.5350218702722261d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9799030338260827d,right: 0.5342868567402429d,bottom: 0.49768508835742886d,left: 0.444978568615642d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6085633260012304d,right: 0.9028223980577069d,bottom: 0.10150296561188621d,left: 0.3202068147498164d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6696442871840734d,right: 0.6792633460138309d,bottom: 0.6489940234175735d,left: 0.3573426599837958d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9100113318392168d,right: 0.33139189814135095d,bottom: 0.41575038118203655d,left: 0.14073168696670624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4717579128130136d,right: 0.7565025665857462d,bottom: 0.17486949792721784d,left: 0.4515138391744803d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42741756075268356d,right: 0.20917089271535616d,bottom: 0.08411227237797081d,left: 0.06312231065197493d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.988832866553114d,right: 0.8711283923756628d,bottom: 0.6236251090248496d,left: 0.4706647559921524d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5790864585591038d,right: 0.18802384290185448d,bottom: 0.3962233694958154d,left: 0.07255425996124132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6528810753943363d,right: 0.30316161501319316d,bottom: 0.5921226313652288d,left: 0.04229453516491399d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5008339887750546d,right: 0.195742010375475d,bottom: 0.1221144367024809d,left: 0.048619022803273015d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6234279822285521d,right: 0.8654350522273158d,bottom: 0.05522372798030817d,left: 0.3302195911933925d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7537717332187446d,right: 0.7063227892170313d,bottom: 0.6810310037947118d,left: 0.08552660660981481d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7090345756512738d,right: 0.7505665819201058d,bottom: 0.3370090839777553d,left: 0.1487768708877547d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.301255399164188d,right: 0.4378445444612141d,bottom: 0.08645784420340696d,left: 0.42716432211844346d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8963857098901581d,right: 0.8748156088685143d,bottom: 0.1134267433808458d,left: 0.07136058476257423d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6182878609345155d,right: 0.9002780905564451d,bottom: 0.5162606680991184d,left: 0.3934092068101256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1562210401898212d,right: 0.9749321057905789d,bottom: 0.1230704052232886d,left: 0.18317349494464175d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46009706055363d,right: 0.5420508093938531d,bottom: 0.020030940848290157d,left: 0.27812222422420574d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6408151209102275d,right: 0.8980498210192585d,bottom: 0.57568261859685d,left: 0.5756387933945307d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3715358130169041d,right: 0.22893140065360995d,bottom: 0.11431190023320448d,left: 0.08585287033580358d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7736211275864537d,right: 0.7143790293422977d,bottom: 0.3512182826508825d,left: 0.43647393421628655d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7959478984061082d,right: 0.8783484870933063d,bottom: 0.09541134951989061d,left: 0.7193844081895774d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9423755434556538d,right: 0.9773421041343083d,bottom: 0.3023077704844116d,left: 0.36814081713529656d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5788988488286555d,right: 0.9058090507815745d,bottom: 0.47146163609713754d,left: 0.809834070620479d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2834920993125696d,right: 0.6634068887571194d,bottom: 0.0754576612354314d,left: 0.5888882929169994d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5125389931564274d,right: 0.9241371722437304d,bottom: 0.29412281837747933d,left: 0.7281389666408814d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4952307447963391d,right: 0.7595995606134601d,bottom: 0.0374280474733788d,left: 0.028664054140854378d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6035553997505159d,right: 0.5599472482426703d,bottom: 0.16772398383150033d,left: 0.0004689672732728356d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5412542079044987d,right: 0.24355490287132087d,bottom: 0.3480610743650062d,left: 0.10177610521655178d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9580249309742109d,right: 0.9161214297331104d,bottom: 0.20403745599727585d,left: 0.6049235187656342d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7858423795995795d,right: 0.9450032290170441d,bottom: 0.29408916704400156d,left: 0.4345752405726673d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5220598620980014d,right: 0.718481994944571d,bottom: 0.3108744171476824d,left: 0.3355304878528016d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1666736324693745d,right: 0.9129776928716302d,bottom: 0.1244812024053259d,left: 0.5311873487681852d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.42884871104586253d,right: 0.8639317567141531d,bottom: 0.36971086394781816d,left: 0.24836099006329881d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5638126189572114d,right: 0.7205165181833846d,bottom: 0.1529996895153417d,left: 0.4315359288218761d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6877387652165879d,right: 0.9197721464100352d,bottom: 0.5116006796868452d,left: 0.448223647089269d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29513540872193755d,right: 0.8127215664561991d,bottom: 0.15754932329458138d,left: 0.7441071389813376d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9935259572657754d,right: 0.3401656834920177d,bottom: 0.25067504252496864d,left: 0.26272411615533076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6025369361192101d,right: 0.8656450580865152d,bottom: 0.10120431181462686d,left: 0.35370021643994876d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4626735417986634d,right: 0.9254438084063131d,bottom: 0.10764803275617496d,left: 0.0954031190005934d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8014552641862656d,right: 0.4593552592914204d,bottom: 0.536782842049843d,left: 0.04069024973642066d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06314175498547114d,right: 0.44756918774482246d,bottom: 0.004334097373426826d,left: 0.3619037851553588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5767660318917477d,right: 0.7576624297841318d,bottom: 0.05474606603128063d,left: 0.4403118640603655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8141954669041623d,right: 0.7364871721275681d,bottom: 0.1790707483345806d,left: 0.6765839145141308d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9207691030228368d,right: 0.9316529956206088d,bottom: 0.18146884216740156d,left: 0.5526554620691051d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8140252361586632d,right: 0.7959783129016116d,bottom: 0.15251853762020517d,left: 0.7721663206030162d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6640449899197591d,right: 0.8299683521054859d,bottom: 0.5070171791641651d,left: 0.5254784840152641d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8457700936569491d,right: 0.14305522023658312d,bottom: 0.07708497831191541d,left: 0.09019115880838624d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6745732549626228d,right: 0.7508607160596319d,bottom: 0.28723275504733636d,left: 0.31154537053428055d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43509372612674524d,right: 0.5998145584629028d,bottom: 0.06604246769199706d,left: 0.32131914824707764d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9941062330926272d,right: 0.9770916229950907d,bottom: 0.8976680597430802d,left: 0.38478645113881416d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9953064379033377d,right: 0.3365125144759332d,bottom: 0.23576458152634439d,left: 0.010731775064732219d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8604334332100354d,right: 0.4760766949181985d,bottom: 0.1582880034089943d,left: 0.0017290525171201887d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9950952763625804d,right: 0.2283612118076005d,bottom: 0.047292170010380774d,left: 0.02997948492376923d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.51407466264277d,right: 0.9533387985916489d,bottom: 0.0009347081504094135d,left: 0.3432451269541621d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.65951991800486d,right: 0.3877947199043603d,bottom: 0.12031054477988012d,left: 0.15813802413877898d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8838114418994342d,right: 0.701927904749939d,bottom: 0.06426974119637996d,left: 0.28939190155339467d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9816879173699609d,right: 0.5676777867641659d,bottom: 0.12025164688012202d,left: 0.3995661783995378d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7055928200052807d,right: 0.765055908331012d,bottom: 0.3357969957737711d,left: 0.3392456895636746d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.858664555520903d,right: 0.829806298828085d,bottom: 0.6714143837900823d,left: 0.5235305989254113d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8516121925111005d,right: 0.28646917567027763d,bottom: 0.047069987768311616d,left: 0.26618906769374073d))));//Value

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

