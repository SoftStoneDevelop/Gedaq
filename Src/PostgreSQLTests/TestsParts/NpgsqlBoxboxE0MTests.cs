

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
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.461627157334606d,right: 0.8352954219894746d,bottom: 0.11367797787188916d,left: 0.47532932266511296d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6250992257452466d,right: 0.8172762728044494d,bottom: 0.15759013891645468d,left: 0.7412133289452649d),
},
            new NpgsqlBoxboxE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9138456522830598d,right: 0.9280466438698146d,bottom: 0.04123284472790478d,left: 0.38879157699206424d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6815267578007229d,right: 0.6829284583698711d,bottom: 0.49116549297449974d,left: 0.6652142559683589d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8485058417157652d,right: 0.9467636798724877d,bottom: 0.1669136952694198d,left: 0.8535649014708624d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6105492631893173d,right: 0.9860273305887695d,bottom: 0.5758431181273976d,left: 0.08217347987613799d),
},
            new NpgsqlBoxboxE0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.594691295629409d,right: 0.7605799549049779d,bottom: 0.5795728584797487d,left: 0.5649343556985835d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8322722108792985d,right: 0.20289621932836743d,bottom: 0.6962064384996758d,left: 0.11433067515255335d),
},
            new NpgsqlBoxboxE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.06623648206243604d,right: 0.5379905883333639d,bottom: 0.039304074898727004d,left: 0.41682955337032657d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.869526642273396d,right: 0.24171435342073133d,bottom: 0.570596548762732d,left: 0.03373116332869974d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8953027340128302d,right: 0.4725251155988356d,bottom: 0.2696643002373218d,left: 0.27094452772756916d),
},
            new NpgsqlBoxboxE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8350588532136461d,right: 0.6809225725385439d,bottom: 0.5911004488788076d,left: 0.3109943803051429d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9715307625760408d,right: 0.7491996785931246d,bottom: 0.9186687655707867d,left: 0.7071758123435451d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8014931770003283d,right: 0.669251133557802d,bottom: 0.6981474126569022d,left: 0.310430569833522d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7961014770870499d,right: 0.9067368269390895d,bottom: 0.1822504935865218d,left: 0.48707275230863534d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8585737294680529d,right: 0.9294957104563777d,bottom: 0.6530781066312972d,left: 0.9089099166647098d),
},
            new NpgsqlBoxboxE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1439361256785645d,right: 0.7740927036975513d,bottom: 0.08240525894758455d,left: 0.6154374061187945d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8828093266402004d,right: 0.5903114691028172d,bottom: 0.8087503698862663d,left: 0.014327793680885659d),
},
            new NpgsqlBoxboxE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8725153691878142d,right: 0.8839661138590086d,bottom: 0.713304840137371d,left: 0.37847135243637997d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6183984733517617d,right: 0.915226708458501d,bottom: 0.23230303847945377d,left: 0.2536607935698826d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6917366683563907d,right: 0.941797816250469d,bottom: 0.4545761000051385d,left: 0.15130885415484407d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9079449474316741d,right: 0.4894621469609587d,bottom: 0.11408476669562684d,left: 0.22252867990354508d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7457056409291003d,right: 0.9209887601809041d,bottom: 0.6340707412592188d,left: 0.6902686210989922d),
},
            new NpgsqlBoxboxE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.44870494442555664d,right: 0.7401727936297758d,bottom: 0.3510822463524802d,left: 0.28266381879913927d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6291466513541148d,right: 0.9691353333380627d,bottom: 0.010002065200437671d,left: 0.604896536550554d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.45331730771595635d,right: 0.7490095913963367d,bottom: 0.04190894045055371d,left: 0.4138398434672622d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.903665353980881d,right: 0.863862605547346d,bottom: 0.5771408005849211d,left: 0.55465047846652d),
},
            new NpgsqlBoxboxE0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5566782113220377d,right: 0.48742122311343117d,bottom: 0.3625262048754917d,left: 0.19689524542105719d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5083218797163855d,right: 0.8353683850449722d,bottom: 0.24048664455413515d,left: 0.42053990651531603d),
},
            new NpgsqlBoxboxE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6687825413327046d,right: 0.1343729427558562d,bottom: 0.13020116224745448d,left: 0.04854488509063226d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4532154106632168d,right: 0.4885513487569486d,bottom: 0.39847821368898473d,left: 0.10897734188329777d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.29364989529184915d,right: 0.6385216069771534d,bottom: 0.011852663852792267d,left: 0.5201337985099821d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5822934118728943d,right: 0.823429745657608d,bottom: 0.5188491593613191d,left: 0.3187538426920048d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8474899583726683d,right: 0.8491934675320952d,bottom: 0.8085075119485272d,left: 0.1207088455893719d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7839687374737936d,right: 0.9104969963805657d,bottom: 0.17167210583090442d,left: 0.7779334771616306d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4461164795325313d,right: 0.42342836932395866d,bottom: 0.18459934931461397d,left: 0.09489751575334093d),
},
            new NpgsqlBoxboxE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6982533659386501d,right: 0.7882970112515488d,bottom: 0.17786833838476468d,left: 0.7844218226563614d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.48728929804471854d,right: 0.4293593217412829d,bottom: 0.47207027071573715d,left: 0.05537027520527271d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8094376572212368d,right: 0.5640920268186278d,bottom: 0.5671073963336106d,left: 0.5195535696809891d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.13404594726294095d,right: 0.7377050040242981d,bottom: 0.029959103315753022d,left: 0.6035394904205885d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6633539394253828d,right: 0.992775592628742d,bottom: 0.057104718386342346d,left: 0.9191266219333434d),
},
            new NpgsqlBoxboxE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2906867079634252d,right: 0.764168233785943d,bottom: 0.2622634702846076d,left: 0.6564133013729447d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8190743869567263d,right: 0.6634085065242133d,bottom: 0.1288498383868636d,left: 0.27161132671109345d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6990489565547399d,right: 0.731132546971591d,bottom: 0.43397886891227977d,left: 0.30202491347564997d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5349338473380558d,right: 0.6523052659033397d,bottom: 0.05728983156735423d,left: 0.5731648846710579d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5799569116883154d,right: 0.19307927080287868d,bottom: 0.5625006630848228d,left: 0.15870342692638428d),
},
            new NpgsqlBoxboxE0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9341320310245275d,right: 0.2501526351873755d,bottom: 0.016242633584140242d,left: 0.18540312706493067d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.711570885846539d,right: 0.22349279708739567d,bottom: 0.05355003409717962d,left: 0.19094364299934186d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7782772748785965d,right: 0.9457674856337983d,bottom: 0.02690987097575448d,left: 0.5393500377906104d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.704439657061814d,right: 0.639097236598797d,bottom: 0.40629988910799064d,left: 0.6170714763815957d),
},
            new NpgsqlBoxboxE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6549557329474786d,right: 0.7591597313198016d,bottom: 0.18999031849467563d,left: 0.09567210392106307d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8795920803156371d,right: 0.5908433387694164d,bottom: 0.4325362616541867d,left: 0.36941458461638566d),
},
            new NpgsqlBoxboxE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9398310516996542d,right: 0.7589398237359339d,bottom: 0.5775800326110146d,left: 0.5887933601285397d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9202960269984589d,right: 0.5011472646709129d,bottom: 0.008465807759146515d,left: 0.41953070340935694d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8521058925125582d,right: 0.8282412915688285d,bottom: 0.8202570385479422d,left: 0.4041649326650749d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9059142503358008d,right: 0.736403403333112d,bottom: 0.4223878914688426d,left: 0.6921826530965475d),
},
            new NpgsqlBoxboxE0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8688251968734855d,right: 0.9569379471572225d,bottom: 0.0010860396912302228d,left: 0.38233848563385d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5270310912051859d,right: 0.6331974565876511d,bottom: 0.44655880165312234d,left: 0.5462843249900601d),
},
            new NpgsqlBoxboxE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5990737948805306d,right: 0.3582303776540934d,bottom: 0.4610250728552704d,left: 0.19429694235235506d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8079943048748321d,right: 0.5120567188648949d,bottom: 0.3312715554908138d,left: 0.2513739035877035d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9273487991226179d,right: 0.05953565490071633d,bottom: 0.8934338897746039d,left: 0.0449987873650769d),
},
            new NpgsqlBoxboxE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.507154433778239d,right: 0.749272818520872d,bottom: 0.048720571157943704d,left: 0.0881945297344301d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6342322933839974d,right: 0.8007563200888425d,bottom: 0.2372940422254275d,left: 0.12264541618333724d),
},
            new NpgsqlBoxboxE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8748251390982064d,right: 0.7166291708076707d,bottom: 0.6962494258435213d,left: 0.3706986831396679d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2130326489708575d,right: 0.8144452730965909d,bottom: 0.11517116395908067d,left: 0.8035698443831465d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9976918373100983d,right: 0.9831116644957096d,bottom: 0.7367936586214613d,left: 0.12787927594644832d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9884146051196252d,right: 0.8802688790991873d,bottom: 0.17410532735893147d,left: 0.38687023777887364d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7085028984575352d,right: 0.9939303847245213d,bottom: 0.6089707100604872d,left: 0.6062782445119319d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7804583598397384d,right: 0.8892465408857627d,bottom: 0.7053960053415244d,left: 0.8805901993506781d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8531613906812087d,right: 0.4772654880940286d,bottom: 0.23737945992319665d,left: 0.033773284522176095d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7217710976968588d,right: 0.7447355000972098d,bottom: 0.5949965784952963d,left: 0.14382642829337533d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3421785658219376d,right: 0.8046394738252464d,bottom: 0.01423545979389984d,left: 0.384752522370853d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43537811420480166d,right: 0.7243313485531232d,bottom: 0.26700600503546634d,left: 0.18320805304694943d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5792360222679691d,right: 0.5182941472694982d,bottom: 0.0561633817273226d,left: 0.12385119315325865d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9100634607869609d,right: 0.9643581426142845d,bottom: 0.35112383881506737d,left: 0.9584496437312972d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7028420595520655d,right: 0.2851275552428809d,bottom: 0.30989658324711267d,left: 0.20374494810100285d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.74081774910594d,right: 0.704387793494449d,bottom: 0.22150477149056058d,left: 0.23386902516471142d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7085971544265274d,right: 0.5533208858553428d,bottom: 0.4135433752377854d,left: 0.44559060844520204d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6003684442683974d,right: 0.6820332712216087d,bottom: 0.11389696525137605d,left: 0.15752785716023454d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9431810596408025d,right: 0.5910006364197025d,bottom: 0.7854583059713331d,left: 0.021235747537750593d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7410724558725743d,right: 0.4748548689518717d,bottom: 0.03526446487435775d,left: 0.3527492929117616d),
},
            new NpgsqlBoxboxE0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7109210116576941d,right: 0.7544443720888846d,bottom: 0.4671876576971473d,left: 0.20887425742658872d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9495873702775038d,right: 0.5362238494287216d,bottom: 0.0628134515916845d,left: 0.5347396412228929d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
INSERT INTO public.npgsqlboxbox0mi(
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
    npgsqlboxbox0mi_id
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8585737294680529d,right: 0.9294957104563777d,bottom: 0.6530781066312972d,left: 0.9089099166647098d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8828093266402004d,right: 0.5903114691028172d,bottom: 0.8087503698862663d,left: 0.014327793680885659d)));
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
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
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
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7457056409291003d,right: 0.9209887601809041d,bottom: 0.6340707412592188d,left: 0.6902686210989922d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.903665353980881d,right: 0.863862605547346d,bottom: 0.5771408005849211d,left: 0.55465047846652d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5083218797163855d,right: 0.8353683850449722d,bottom: 0.24048664455413515d,left: 0.42053990651531603d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
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
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                parametr1.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr2.Value = 72;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[34], false);
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[34], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 154, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[34], false);
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 147, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[23],_testData[34], false);
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.461627157334606d,right: 0.8352954219894746d,bottom: 0.11367797787188916d,left: 0.47532932266511296d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6250992257452466d,right: 0.8172762728044494d,bottom: 0.15759013891645468d,left: 0.7412133289452649d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9138456522830598d,right: 0.9280466438698146d,bottom: 0.04123284472790478d,left: 0.38879157699206424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6815267578007229d,right: 0.6829284583698711d,bottom: 0.49116549297449974d,left: 0.6652142559683589d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8485058417157652d,right: 0.9467636798724877d,bottom: 0.1669136952694198d,left: 0.8535649014708624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6105492631893173d,right: 0.9860273305887695d,bottom: 0.5758431181273976d,left: 0.08217347987613799d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.594691295629409d,right: 0.7605799549049779d,bottom: 0.5795728584797487d,left: 0.5649343556985835d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8322722108792985d,right: 0.20289621932836743d,bottom: 0.6962064384996758d,left: 0.11433067515255335d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06623648206243604d,right: 0.5379905883333639d,bottom: 0.039304074898727004d,left: 0.41682955337032657d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.869526642273396d,right: 0.24171435342073133d,bottom: 0.570596548762732d,left: 0.03373116332869974d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8953027340128302d,right: 0.4725251155988356d,bottom: 0.2696643002373218d,left: 0.27094452772756916d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8350588532136461d,right: 0.6809225725385439d,bottom: 0.5911004488788076d,left: 0.3109943803051429d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9715307625760408d,right: 0.7491996785931246d,bottom: 0.9186687655707867d,left: 0.7071758123435451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8014931770003283d,right: 0.669251133557802d,bottom: 0.6981474126569022d,left: 0.310430569833522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7961014770870499d,right: 0.9067368269390895d,bottom: 0.1822504935865218d,left: 0.48707275230863534d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8585737294680529d,right: 0.9294957104563777d,bottom: 0.6530781066312972d,left: 0.9089099166647098d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1439361256785645d,right: 0.7740927036975513d,bottom: 0.08240525894758455d,left: 0.6154374061187945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8828093266402004d,right: 0.5903114691028172d,bottom: 0.8087503698862663d,left: 0.014327793680885659d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8725153691878142d,right: 0.8839661138590086d,bottom: 0.713304840137371d,left: 0.37847135243637997d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6183984733517617d,right: 0.915226708458501d,bottom: 0.23230303847945377d,left: 0.2536607935698826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6917366683563907d,right: 0.941797816250469d,bottom: 0.4545761000051385d,left: 0.15130885415484407d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9079449474316741d,right: 0.4894621469609587d,bottom: 0.11408476669562684d,left: 0.22252867990354508d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7457056409291003d,right: 0.9209887601809041d,bottom: 0.6340707412592188d,left: 0.6902686210989922d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44870494442555664d,right: 0.7401727936297758d,bottom: 0.3510822463524802d,left: 0.28266381879913927d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6291466513541148d,right: 0.9691353333380627d,bottom: 0.010002065200437671d,left: 0.604896536550554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45331730771595635d,right: 0.7490095913963367d,bottom: 0.04190894045055371d,left: 0.4138398434672622d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.903665353980881d,right: 0.863862605547346d,bottom: 0.5771408005849211d,left: 0.55465047846652d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5566782113220377d,right: 0.48742122311343117d,bottom: 0.3625262048754917d,left: 0.19689524542105719d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5083218797163855d,right: 0.8353683850449722d,bottom: 0.24048664455413515d,left: 0.42053990651531603d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687825413327046d,right: 0.1343729427558562d,bottom: 0.13020116224745448d,left: 0.04854488509063226d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4532154106632168d,right: 0.4885513487569486d,bottom: 0.39847821368898473d,left: 0.10897734188329777d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29364989529184915d,right: 0.6385216069771534d,bottom: 0.011852663852792267d,left: 0.5201337985099821d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5822934118728943d,right: 0.823429745657608d,bottom: 0.5188491593613191d,left: 0.3187538426920048d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8474899583726683d,right: 0.8491934675320952d,bottom: 0.8085075119485272d,left: 0.1207088455893719d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7839687374737936d,right: 0.9104969963805657d,bottom: 0.17167210583090442d,left: 0.7779334771616306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4461164795325313d,right: 0.42342836932395866d,bottom: 0.18459934931461397d,left: 0.09489751575334093d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6982533659386501d,right: 0.7882970112515488d,bottom: 0.17786833838476468d,left: 0.7844218226563614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48728929804471854d,right: 0.4293593217412829d,bottom: 0.47207027071573715d,left: 0.05537027520527271d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8094376572212368d,right: 0.5640920268186278d,bottom: 0.5671073963336106d,left: 0.5195535696809891d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13404594726294095d,right: 0.7377050040242981d,bottom: 0.029959103315753022d,left: 0.6035394904205885d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6633539394253828d,right: 0.992775592628742d,bottom: 0.057104718386342346d,left: 0.9191266219333434d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2906867079634252d,right: 0.764168233785943d,bottom: 0.2622634702846076d,left: 0.6564133013729447d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190743869567263d,right: 0.6634085065242133d,bottom: 0.1288498383868636d,left: 0.27161132671109345d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6990489565547399d,right: 0.731132546971591d,bottom: 0.43397886891227977d,left: 0.30202491347564997d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5349338473380558d,right: 0.6523052659033397d,bottom: 0.05728983156735423d,left: 0.5731648846710579d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5799569116883154d,right: 0.19307927080287868d,bottom: 0.5625006630848228d,left: 0.15870342692638428d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9341320310245275d,right: 0.2501526351873755d,bottom: 0.016242633584140242d,left: 0.18540312706493067d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.711570885846539d,right: 0.22349279708739567d,bottom: 0.05355003409717962d,left: 0.19094364299934186d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7782772748785965d,right: 0.9457674856337983d,bottom: 0.02690987097575448d,left: 0.5393500377906104d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.704439657061814d,right: 0.639097236598797d,bottom: 0.40629988910799064d,left: 0.6170714763815957d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6549557329474786d,right: 0.7591597313198016d,bottom: 0.18999031849467563d,left: 0.09567210392106307d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8795920803156371d,right: 0.5908433387694164d,bottom: 0.4325362616541867d,left: 0.36941458461638566d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9398310516996542d,right: 0.7589398237359339d,bottom: 0.5775800326110146d,left: 0.5887933601285397d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9202960269984589d,right: 0.5011472646709129d,bottom: 0.008465807759146515d,left: 0.41953070340935694d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521058925125582d,right: 0.8282412915688285d,bottom: 0.8202570385479422d,left: 0.4041649326650749d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9059142503358008d,right: 0.736403403333112d,bottom: 0.4223878914688426d,left: 0.6921826530965475d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8688251968734855d,right: 0.9569379471572225d,bottom: 0.0010860396912302228d,left: 0.38233848563385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5270310912051859d,right: 0.6331974565876511d,bottom: 0.44655880165312234d,left: 0.5462843249900601d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5990737948805306d,right: 0.3582303776540934d,bottom: 0.4610250728552704d,left: 0.19429694235235506d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8079943048748321d,right: 0.5120567188648949d,bottom: 0.3312715554908138d,left: 0.2513739035877035d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9273487991226179d,right: 0.05953565490071633d,bottom: 0.8934338897746039d,left: 0.0449987873650769d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.507154433778239d,right: 0.749272818520872d,bottom: 0.048720571157943704d,left: 0.0881945297344301d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6342322933839974d,right: 0.8007563200888425d,bottom: 0.2372940422254275d,left: 0.12264541618333724d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8748251390982064d,right: 0.7166291708076707d,bottom: 0.6962494258435213d,left: 0.3706986831396679d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2130326489708575d,right: 0.8144452730965909d,bottom: 0.11517116395908067d,left: 0.8035698443831465d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9976918373100983d,right: 0.9831116644957096d,bottom: 0.7367936586214613d,left: 0.12787927594644832d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9884146051196252d,right: 0.8802688790991873d,bottom: 0.17410532735893147d,left: 0.38687023777887364d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7085028984575352d,right: 0.9939303847245213d,bottom: 0.6089707100604872d,left: 0.6062782445119319d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7804583598397384d,right: 0.8892465408857627d,bottom: 0.7053960053415244d,left: 0.8805901993506781d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8531613906812087d,right: 0.4772654880940286d,bottom: 0.23737945992319665d,left: 0.033773284522176095d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7217710976968588d,right: 0.7447355000972098d,bottom: 0.5949965784952963d,left: 0.14382642829337533d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3421785658219376d,right: 0.8046394738252464d,bottom: 0.01423545979389984d,left: 0.384752522370853d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43537811420480166d,right: 0.7243313485531232d,bottom: 0.26700600503546634d,left: 0.18320805304694943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5792360222679691d,right: 0.5182941472694982d,bottom: 0.0561633817273226d,left: 0.12385119315325865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9100634607869609d,right: 0.9643581426142845d,bottom: 0.35112383881506737d,left: 0.9584496437312972d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7028420595520655d,right: 0.2851275552428809d,bottom: 0.30989658324711267d,left: 0.20374494810100285d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.74081774910594d,right: 0.704387793494449d,bottom: 0.22150477149056058d,left: 0.23386902516471142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7085971544265274d,right: 0.5533208858553428d,bottom: 0.4135433752377854d,left: 0.44559060844520204d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6003684442683974d,right: 0.6820332712216087d,bottom: 0.11389696525137605d,left: 0.15752785716023454d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9431810596408025d,right: 0.5910006364197025d,bottom: 0.7854583059713331d,left: 0.021235747537750593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7410724558725743d,right: 0.4748548689518717d,bottom: 0.03526446487435775d,left: 0.3527492929117616d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7109210116576941d,right: 0.7544443720888846d,bottom: 0.4671876576971473d,left: 0.20887425742658872d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9495873702775038d,right: 0.5362238494287216d,bottom: 0.0628134515916845d,left: 0.5347396412228929d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.461627157334606d,right: 0.8352954219894746d,bottom: 0.11367797787188916d,left: 0.47532932266511296d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6250992257452466d,right: 0.8172762728044494d,bottom: 0.15759013891645468d,left: 0.7412133289452649d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9138456522830598d,right: 0.9280466438698146d,bottom: 0.04123284472790478d,left: 0.38879157699206424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6815267578007229d,right: 0.6829284583698711d,bottom: 0.49116549297449974d,left: 0.6652142559683589d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8485058417157652d,right: 0.9467636798724877d,bottom: 0.1669136952694198d,left: 0.8535649014708624d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6105492631893173d,right: 0.9860273305887695d,bottom: 0.5758431181273976d,left: 0.08217347987613799d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.594691295629409d,right: 0.7605799549049779d,bottom: 0.5795728584797487d,left: 0.5649343556985835d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8322722108792985d,right: 0.20289621932836743d,bottom: 0.6962064384996758d,left: 0.11433067515255335d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.06623648206243604d,right: 0.5379905883333639d,bottom: 0.039304074898727004d,left: 0.41682955337032657d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.869526642273396d,right: 0.24171435342073133d,bottom: 0.570596548762732d,left: 0.03373116332869974d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8953027340128302d,right: 0.4725251155988356d,bottom: 0.2696643002373218d,left: 0.27094452772756916d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8350588532136461d,right: 0.6809225725385439d,bottom: 0.5911004488788076d,left: 0.3109943803051429d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9715307625760408d,right: 0.7491996785931246d,bottom: 0.9186687655707867d,left: 0.7071758123435451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8014931770003283d,right: 0.669251133557802d,bottom: 0.6981474126569022d,left: 0.310430569833522d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7961014770870499d,right: 0.9067368269390895d,bottom: 0.1822504935865218d,left: 0.48707275230863534d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8585737294680529d,right: 0.9294957104563777d,bottom: 0.6530781066312972d,left: 0.9089099166647098d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1439361256785645d,right: 0.7740927036975513d,bottom: 0.08240525894758455d,left: 0.6154374061187945d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8828093266402004d,right: 0.5903114691028172d,bottom: 0.8087503698862663d,left: 0.014327793680885659d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8725153691878142d,right: 0.8839661138590086d,bottom: 0.713304840137371d,left: 0.37847135243637997d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6183984733517617d,right: 0.915226708458501d,bottom: 0.23230303847945377d,left: 0.2536607935698826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6917366683563907d,right: 0.941797816250469d,bottom: 0.4545761000051385d,left: 0.15130885415484407d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9079449474316741d,right: 0.4894621469609587d,bottom: 0.11408476669562684d,left: 0.22252867990354508d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7457056409291003d,right: 0.9209887601809041d,bottom: 0.6340707412592188d,left: 0.6902686210989922d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.44870494442555664d,right: 0.7401727936297758d,bottom: 0.3510822463524802d,left: 0.28266381879913927d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6291466513541148d,right: 0.9691353333380627d,bottom: 0.010002065200437671d,left: 0.604896536550554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45331730771595635d,right: 0.7490095913963367d,bottom: 0.04190894045055371d,left: 0.4138398434672622d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.903665353980881d,right: 0.863862605547346d,bottom: 0.5771408005849211d,left: 0.55465047846652d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5566782113220377d,right: 0.48742122311343117d,bottom: 0.3625262048754917d,left: 0.19689524542105719d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5083218797163855d,right: 0.8353683850449722d,bottom: 0.24048664455413515d,left: 0.42053990651531603d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6687825413327046d,right: 0.1343729427558562d,bottom: 0.13020116224745448d,left: 0.04854488509063226d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4532154106632168d,right: 0.4885513487569486d,bottom: 0.39847821368898473d,left: 0.10897734188329777d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.29364989529184915d,right: 0.6385216069771534d,bottom: 0.011852663852792267d,left: 0.5201337985099821d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5822934118728943d,right: 0.823429745657608d,bottom: 0.5188491593613191d,left: 0.3187538426920048d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8474899583726683d,right: 0.8491934675320952d,bottom: 0.8085075119485272d,left: 0.1207088455893719d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7839687374737936d,right: 0.9104969963805657d,bottom: 0.17167210583090442d,left: 0.7779334771616306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4461164795325313d,right: 0.42342836932395866d,bottom: 0.18459934931461397d,left: 0.09489751575334093d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6982533659386501d,right: 0.7882970112515488d,bottom: 0.17786833838476468d,left: 0.7844218226563614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48728929804471854d,right: 0.4293593217412829d,bottom: 0.47207027071573715d,left: 0.05537027520527271d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8094376572212368d,right: 0.5640920268186278d,bottom: 0.5671073963336106d,left: 0.5195535696809891d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13404594726294095d,right: 0.7377050040242981d,bottom: 0.029959103315753022d,left: 0.6035394904205885d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6633539394253828d,right: 0.992775592628742d,bottom: 0.057104718386342346d,left: 0.9191266219333434d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2906867079634252d,right: 0.764168233785943d,bottom: 0.2622634702846076d,left: 0.6564133013729447d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8190743869567263d,right: 0.6634085065242133d,bottom: 0.1288498383868636d,left: 0.27161132671109345d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6990489565547399d,right: 0.731132546971591d,bottom: 0.43397886891227977d,left: 0.30202491347564997d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5349338473380558d,right: 0.6523052659033397d,bottom: 0.05728983156735423d,left: 0.5731648846710579d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5799569116883154d,right: 0.19307927080287868d,bottom: 0.5625006630848228d,left: 0.15870342692638428d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9341320310245275d,right: 0.2501526351873755d,bottom: 0.016242633584140242d,left: 0.18540312706493067d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.711570885846539d,right: 0.22349279708739567d,bottom: 0.05355003409717962d,left: 0.19094364299934186d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7782772748785965d,right: 0.9457674856337983d,bottom: 0.02690987097575448d,left: 0.5393500377906104d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.704439657061814d,right: 0.639097236598797d,bottom: 0.40629988910799064d,left: 0.6170714763815957d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6549557329474786d,right: 0.7591597313198016d,bottom: 0.18999031849467563d,left: 0.09567210392106307d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8795920803156371d,right: 0.5908433387694164d,bottom: 0.4325362616541867d,left: 0.36941458461638566d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9398310516996542d,right: 0.7589398237359339d,bottom: 0.5775800326110146d,left: 0.5887933601285397d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9202960269984589d,right: 0.5011472646709129d,bottom: 0.008465807759146515d,left: 0.41953070340935694d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521058925125582d,right: 0.8282412915688285d,bottom: 0.8202570385479422d,left: 0.4041649326650749d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9059142503358008d,right: 0.736403403333112d,bottom: 0.4223878914688426d,left: 0.6921826530965475d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8688251968734855d,right: 0.9569379471572225d,bottom: 0.0010860396912302228d,left: 0.38233848563385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5270310912051859d,right: 0.6331974565876511d,bottom: 0.44655880165312234d,left: 0.5462843249900601d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5990737948805306d,right: 0.3582303776540934d,bottom: 0.4610250728552704d,left: 0.19429694235235506d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8079943048748321d,right: 0.5120567188648949d,bottom: 0.3312715554908138d,left: 0.2513739035877035d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9273487991226179d,right: 0.05953565490071633d,bottom: 0.8934338897746039d,left: 0.0449987873650769d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.507154433778239d,right: 0.749272818520872d,bottom: 0.048720571157943704d,left: 0.0881945297344301d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6342322933839974d,right: 0.8007563200888425d,bottom: 0.2372940422254275d,left: 0.12264541618333724d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8748251390982064d,right: 0.7166291708076707d,bottom: 0.6962494258435213d,left: 0.3706986831396679d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2130326489708575d,right: 0.8144452730965909d,bottom: 0.11517116395908067d,left: 0.8035698443831465d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9976918373100983d,right: 0.9831116644957096d,bottom: 0.7367936586214613d,left: 0.12787927594644832d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9884146051196252d,right: 0.8802688790991873d,bottom: 0.17410532735893147d,left: 0.38687023777887364d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7085028984575352d,right: 0.9939303847245213d,bottom: 0.6089707100604872d,left: 0.6062782445119319d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7804583598397384d,right: 0.8892465408857627d,bottom: 0.7053960053415244d,left: 0.8805901993506781d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8531613906812087d,right: 0.4772654880940286d,bottom: 0.23737945992319665d,left: 0.033773284522176095d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7217710976968588d,right: 0.7447355000972098d,bottom: 0.5949965784952963d,left: 0.14382642829337533d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3421785658219376d,right: 0.8046394738252464d,bottom: 0.01423545979389984d,left: 0.384752522370853d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43537811420480166d,right: 0.7243313485531232d,bottom: 0.26700600503546634d,left: 0.18320805304694943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5792360222679691d,right: 0.5182941472694982d,bottom: 0.0561633817273226d,left: 0.12385119315325865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9100634607869609d,right: 0.9643581426142845d,bottom: 0.35112383881506737d,left: 0.9584496437312972d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7028420595520655d,right: 0.2851275552428809d,bottom: 0.30989658324711267d,left: 0.20374494810100285d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.74081774910594d,right: 0.704387793494449d,bottom: 0.22150477149056058d,left: 0.23386902516471142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7085971544265274d,right: 0.5533208858553428d,bottom: 0.4135433752377854d,left: 0.44559060844520204d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6003684442683974d,right: 0.6820332712216087d,bottom: 0.11389696525137605d,left: 0.15752785716023454d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9431810596408025d,right: 0.5910006364197025d,bottom: 0.7854583059713331d,left: 0.021235747537750593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7410724558725743d,right: 0.4748548689518717d,bottom: 0.03526446487435775d,left: 0.3527492929117616d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7109210116576941d,right: 0.7544443720888846d,bottom: 0.4671876576971473d,left: 0.20887425742658872d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9495873702775038d,right: 0.5362238494287216d,bottom: 0.0628134515916845d,left: 0.5347396412228929d))));

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
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
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
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
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
npgsqlboxbox0mi_id,
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
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

