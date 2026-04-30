

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48676558180740903d, y: 0.873526718721321d), new NpgsqlTypes.NpgsqlPoint(x: 0.768518713167533d, y: 0.8578890948678859d), new NpgsqlTypes.NpgsqlPoint(x: 0.30545898296229723d, y: 0.742339788090013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4310514085047277d, y: 0.2168504094071395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797662664993406d, y: 0.6179345079719278d), new NpgsqlTypes.NpgsqlPoint(x: 0.4288062735741587d, y: 0.5241509207220024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17047853495879317d, y: 0.8580374333478998d), new NpgsqlTypes.NpgsqlPoint(x: 0.40832087878477896d, y: 0.8858452628384106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2355288462912818d, y: 0.49018982988158677d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22312386248570337d, y: 0.5597625451671917d), new NpgsqlTypes.NpgsqlPoint(x: 0.19240577318618401d, y: 0.15548897664416994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6166086805600771d, y: 0.0969149185685294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22464434019311175d, y: 0.6005135528754906d), new NpgsqlTypes.NpgsqlPoint(x: 0.34296456618205096d, y: 0.392556840965414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913298179467008d, y: 0.3389840499152629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8176621246450064d, y: 0.12936676874045172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8939092617526345d, y: 0.01558748247630104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787637956084103d, y: 0.15180068897544163d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7819852194317662d, y: 0.8804273729390161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547346172945435d, y: 0.7367860397369539d), new NpgsqlTypes.NpgsqlPoint(x: 0.44354647946160464d, y: 0.8528215433339473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047849124590027325d, y: 0.9706752780730794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859516589428069d, y: 0.8074470615178516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524739080845206d, y: 0.36417868232615636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1847814777986413d, y: 0.9029613513719665d), new NpgsqlTypes.NpgsqlPoint(x: 0.45798006276807934d, y: 0.8681257988652987d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168231856678486d, y: 0.2118674598759459d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21624949837563656d, y: 0.7443094862878766d), new NpgsqlTypes.NpgsqlPoint(x: 0.1027602694333043d, y: 0.6205116631553196d), new NpgsqlTypes.NpgsqlPoint(x: 0.12900857397295162d, y: 0.9675604425109756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2732443711868928d, y: 0.9536216178711896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8656773529567103d, y: 0.8870272286426492d), new NpgsqlTypes.NpgsqlPoint(x: 0.43932989095746167d, y: 0.13494416101749163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7320001211111876d, y: 0.12429211194168954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770983809312581d, y: 0.739903717599563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626870626198467d, y: 0.846242970164268d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4848899847135426d, y: 0.33722635368826126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695711429317194d, y: 0.5575684853452727d), new NpgsqlTypes.NpgsqlPoint(x: 0.26736983820433335d, y: 0.8467254878508658d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3705515933315159d, y: 0.5474037324738723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6442530536260893d, y: 0.9623046511664178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425661136658734d, y: 0.8661254906294372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03313657180436336d, y: 0.8537723686789547d), new NpgsqlTypes.NpgsqlPoint(x: 0.13571508401352284d, y: 0.3682417246681915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846422703435604d, y: 0.9846736998243617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393708188043336d, y: 0.9507355309152852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389959055800087d, y: 0.9636698271375802d), new NpgsqlTypes.NpgsqlPoint(x: 0.34329052367043456d, y: 0.5896259539775421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24925113706878144d, y: 0.7798497231919647d), new NpgsqlTypes.NpgsqlPoint(x: 0.572276126472831d, y: 0.7026210090893583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2175240241137335d, y: 0.47142583970035123d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6182328556372098d, y: 0.7164369003554798d), new NpgsqlTypes.NpgsqlPoint(x: 0.15587017755588872d, y: 0.3902759765079581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759827124285805d, y: 0.9687513295214315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8659249295983656d, y: 0.8215887116291481d), new NpgsqlTypes.NpgsqlPoint(x: 0.48297977247449697d, y: 0.09524662402613404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9089292344722429d, y: 0.6564441499383066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19949364049405383d, y: 0.8260701964868036d), new NpgsqlTypes.NpgsqlPoint(x: 0.09126647875404259d, y: 0.08663916503088076d), new NpgsqlTypes.NpgsqlPoint(x: 0.14029627221137808d, y: 0.3194593143191886d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42279197890530973d, y: 0.03560543932039595d), new NpgsqlTypes.NpgsqlPoint(x: 0.648821429944677d, y: 0.061481102201361604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868218197073959d, y: 0.5191488142024787d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6845496886940521d, y: 0.6051652383700235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987487222553704d, y: 0.6730492884038078d), new NpgsqlTypes.NpgsqlPoint(x: 0.39191572508662886d, y: 0.03511967197016408d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24133544693577258d, y: 0.5678149857742728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585864024796458d, y: 0.14637627543382925d), new NpgsqlTypes.NpgsqlPoint(x: 0.1157703410029407d, y: 0.525236447657905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899401095822077d, y: 0.19499315786622806d), new NpgsqlTypes.NpgsqlPoint(x: 0.620255554437937d, y: 0.09788816527948285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881347210456871d, y: 0.3056375248159313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6136066411974873d, y: 0.8791713473605838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335804883483433d, y: 0.5938939588945378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7666664695569845d, y: 0.6746489050281917d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4842057675253676d, y: 0.5878129430690777d), new NpgsqlTypes.NpgsqlPoint(x: 0.846204016098129d, y: 0.8673460097920623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289692579578932d, y: 0.10965917254514856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5613487772626699d, y: 0.35450004452354344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772469326660564d, y: 0.8439309848253843d), new NpgsqlTypes.NpgsqlPoint(x: 0.10904774936794992d, y: 0.4359199974145296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36611024156288663d, y: 0.9844970854406284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948058566621242d, y: 0.2901454221484945d), new NpgsqlTypes.NpgsqlPoint(x: 0.3902589149466472d, y: 0.614052005327679d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40071454124361605d, y: 0.13719925745825157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380843627076601d, y: 0.22394973162805043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728292797579309d, y: 0.34094006875310434d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7770587357544297d, y: 0.3157394488311701d), new NpgsqlTypes.NpgsqlPoint(x: 0.30600767794827655d, y: 0.9364838292464738d), new NpgsqlTypes.NpgsqlPoint(x: 0.06565525357410196d, y: 0.31293673838096236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37519609945291155d, y: 0.8354772350227707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470293128442952d, y: 0.7466530461297539d), new NpgsqlTypes.NpgsqlPoint(x: 0.12147676716132383d, y: 0.8611802228641934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32152369511426115d, y: 0.6466331237102073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5419280247888413d, y: 0.29485971377774056d), new NpgsqlTypes.NpgsqlPoint(x: 0.16154206929145443d, y: 0.0418557346595686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9250114849942562d, y: 0.7798194647711776d), new NpgsqlTypes.NpgsqlPoint(x: 0.33415334340950986d, y: 0.6237579744395724d), new NpgsqlTypes.NpgsqlPoint(x: 0.254467115418468d, y: 0.5392112444044153d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05646760496643777d, y: 0.8556355862913262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841363718211948d, y: 0.2755623174730013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812873729900267d, y: 0.6146598799123681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18548370904206335d, y: 0.045042043308577084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751687492144033d, y: 0.10394529619175474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032276705431048d, y: 0.7638541803805046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.771185386709152d, y: 0.7906342006021735d), new NpgsqlTypes.NpgsqlPoint(x: 0.45478977184149727d, y: 0.4255016074344692d), new NpgsqlTypes.NpgsqlPoint(x: 0.16424718980232011d, y: 0.14920781468572808d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.719435500536832d, y: 0.8901927994250357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377438991746224d, y: 0.8377904026811687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650032445194788d, y: 0.603771994115898d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05969180166301358d, y: 0.8301961436904529d), new NpgsqlTypes.NpgsqlPoint(x: 0.702663022649449d, y: 0.9167317051275076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820271164291797d, y: 0.26746566264627636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3670237285724349d, y: 0.7826122854931895d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970685742256292d, y: 0.04153760273741536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941063146865318d, y: 0.7056169947396261d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5124317762007761d, y: 0.8223819834681776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851739292677343d, y: 0.7418945808661672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703975805959039d, y: 0.9540706783937621d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5415078098194709d, y: 0.4163184051199976d), new NpgsqlTypes.NpgsqlPoint(x: 0.06160466816490118d, y: 0.6297037264572017d), new NpgsqlTypes.NpgsqlPoint(x: 0.41208445973526475d, y: 0.14027452806284502d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.85763871426698d, y: 0.26754790631941017d), new NpgsqlTypes.NpgsqlPoint(x: 0.21944775466726696d, y: 0.6974015016046694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838782722579229d, y: 0.4293253063652184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4471190437729867d, y: 0.7720162110147839d), new NpgsqlTypes.NpgsqlPoint(x: 0.994495785925126d, y: 0.8827516116241223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633429222316185d, y: 0.7440857524943798d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11956805536718507d, y: 0.4260902471202732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966352707865235d, y: 0.8714653506645215d), new NpgsqlTypes.NpgsqlPoint(x: 0.31821872957487973d, y: 0.11929536395130558d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04103962484953094d, y: 0.21873285128208242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827628194711713d, y: 0.8981219449055984d), new NpgsqlTypes.NpgsqlPoint(x: 0.31642858644387506d, y: 0.516189427957909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16190072671144884d, y: 0.22043148249097255d), new NpgsqlTypes.NpgsqlPoint(x: 0.294027789616379d, y: 0.33865962518921455d), new NpgsqlTypes.NpgsqlPoint(x: 0.38724177101709d, y: 0.6673178498141991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46731591591859456d, y: 0.4416346676313082d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113536882197338d, y: 0.7283825426156664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645982986306367d, y: 0.9104717099988977d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273261619946511d, y: 0.4227661781429787d), new NpgsqlTypes.NpgsqlPoint(x: 0.08796351824657533d, y: 0.01635410278924343d), new NpgsqlTypes.NpgsqlPoint(x: 0.09400954306560017d, y: 0.799621567786609d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11864717475754338d, y: 0.8632467508713517d), new NpgsqlTypes.NpgsqlPoint(x: 0.21445120912688986d, y: 0.22925038729743452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883479232894415d, y: 0.3092289641703607d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9538480198187375d, y: 0.0405228373222849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903972085796477d, y: 0.15197892796164125d), new NpgsqlTypes.NpgsqlPoint(x: 0.549593063886877d, y: 0.495533635462449d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6529515784441215d, y: 0.9196179584186046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506021449586937d, y: 0.1260271674403569d), new NpgsqlTypes.NpgsqlPoint(x: 0.2852167062587d, y: 0.9684906977533124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44525883118684895d, y: 0.773345545130347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3908000379904677d, y: 0.9680729656967378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359621733816839d, y: 0.11116419052428417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.602022590417924d, y: 0.060501011906854196d), new NpgsqlTypes.NpgsqlPoint(x: 0.35399979165732354d, y: 0.6658388473527264d), new NpgsqlTypes.NpgsqlPoint(x: 0.4646091049055491d, y: 0.29504347814092124d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8371368403128946d, y: 0.22266458544353995d), new NpgsqlTypes.NpgsqlPoint(x: 0.710817229012408d, y: 0.39946612267119674d), new NpgsqlTypes.NpgsqlPoint(x: 0.996590501511251d, y: 0.10043661919794378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36483757485717605d, y: 0.7395765194076961d), new NpgsqlTypes.NpgsqlPoint(x: 0.4232228165774704d, y: 0.4937268974410757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392075639580717d, y: 0.2580477332496919d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4703887401358001d, y: 0.5794364282889624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535826517265509d, y: 0.37703420336034044d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642092191711328d, y: 0.09947662960450698d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9777558024682761d, y: 0.3546652383834906d), new NpgsqlTypes.NpgsqlPoint(x: 0.29318023660375314d, y: 0.4281648086763463d), new NpgsqlTypes.NpgsqlPoint(x: 0.48275523762676265d, y: 0.16580937196600454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9645166812681165d, y: 0.447042301491375d), new NpgsqlTypes.NpgsqlPoint(x: 0.13843956087722764d, y: 0.008111569087184245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086864444053286d, y: 0.1686929572428092d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7752619209413445d, y: 0.33607905589884546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484399668897529d, y: 0.5927163147784202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592797444661786d, y: 0.9428734056345539d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4296832296711661d, y: 0.6208008685889411d), new NpgsqlTypes.NpgsqlPoint(x: 0.009651480790129008d, y: 0.1646906150602787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119764893052271d, y: 0.37903118452066d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9833627835557466d, y: 0.23276606903326447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099353056147246d, y: 0.32084374946188476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905857637496874d, y: 0.22169325940206808d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9686781689678985d, y: 0.8566530457776883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659324979084463d, y: 0.17701565270926556d), new NpgsqlTypes.NpgsqlPoint(x: 0.668912044517605d, y: 0.7639205104211352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30373343579913736d, y: 0.594009251413207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574494309884636d, y: 0.9017006179821869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3113283423275661d, y: 0.1323319006147703d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7166175031786579d, y: 0.9288200306908596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122017976882929d, y: 0.3132192166698423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000365964403842d, y: 0.06286833547567272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5211937950223084d, y: 0.4813958773749897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5149363732313893d, y: 0.6639931573516503d), new NpgsqlTypes.NpgsqlPoint(x: 0.42397207156234074d, y: 0.6904562770493059d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0014742698719286684d, y: 0.9454467352349503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144733710331753d, y: 0.7342385807602257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296362975308177d, y: 0.9261514168464774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8266180689438041d, y: 0.3489711528117201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157430804187254d, y: 0.6535209479699359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197275296210505d, y: 0.7267198012118927d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6147232498287124d, y: 0.5829799802056184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991044454056522d, y: 0.9563142629203605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3851460742972145d, y: 0.3054550493095012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7615945779311334d, y: 0.023576962628360953d), new NpgsqlTypes.NpgsqlPoint(x: 0.40981384097072737d, y: 0.36250581922173075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919541454843315d, y: 0.9510045676993837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039752392464059594d, y: 0.9254523399629359d), new NpgsqlTypes.NpgsqlPoint(x: 0.15062204005472568d, y: 0.1283156553889483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566795504331008d, y: 0.5769627941994184d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7769292040465215d, y: 0.22846814354104783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875870735319801d, y: 0.30579480887262356d), new NpgsqlTypes.NpgsqlPoint(x: 0.40066254677387836d, y: 0.08170078262232783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9215441844051921d, y: 0.7405742817452314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214855640909031d, y: 0.3042819175539093d), new NpgsqlTypes.NpgsqlPoint(x: 0.16492480182164593d, y: 0.4504535720287097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23669138153878333d, y: 0.6468066069254977d), new NpgsqlTypes.NpgsqlPoint(x: 0.10370292233943823d, y: 0.45652609971289226d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920311369635356d, y: 0.6702431818677322d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023400500294444404d, y: 0.587091546930867d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304973682938827d, y: 0.5900635117637513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015485314943852d, y: 0.6198873853782972d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3096073495297439d, y: 0.1850380290148309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753044014172225d, y: 0.11950312450305445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1210459940449613d, y: 0.4711360930757762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6164907344239174d, y: 0.031956463075796915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091327157154805d, y: 0.6911111983639754d), new NpgsqlTypes.NpgsqlPoint(x: 0.1585377136002063d, y: 0.29883750068457116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.579383663686956d, y: 0.16677005262273314d), new NpgsqlTypes.NpgsqlPoint(x: 0.08043905445724298d, y: 0.7850051296212102d), new NpgsqlTypes.NpgsqlPoint(x: 0.28770356884818715d, y: 0.545674347392476d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5504033000790682d, y: 0.4257920853331413d), new NpgsqlTypes.NpgsqlPoint(x: 0.18638086670731768d, y: 0.03530826161700307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668657188338727d, y: 0.878234948018066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.728080369058748d, y: 0.2186096300294068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3395996115297254d, y: 0.939349912004292d), new NpgsqlTypes.NpgsqlPoint(x: 0.45672445747245116d, y: 0.9946590881877999d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.733755397836532d, y: 0.7648658951701234d), new NpgsqlTypes.NpgsqlPoint(x: 0.1899208909432637d, y: 0.21833842290360972d), new NpgsqlTypes.NpgsqlPoint(x: 0.743883650754595d, y: 0.5151935361693667d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7268159178973334d, y: 0.4544677655194542d), new NpgsqlTypes.NpgsqlPoint(x: 0.442491610604411d, y: 0.24568550989176907d), new NpgsqlTypes.NpgsqlPoint(x: 0.40935991456300413d, y: 0.42803498445242116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5191017320200767d, y: 0.15749834602314294d), new NpgsqlTypes.NpgsqlPoint(x: 0.49486975527208765d, y: 0.6260255764596258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471124180001853d, y: 0.020744103040843065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3179252898740973d, y: 0.24678231879408463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986561929189848d, y: 0.3906742173959561d), new NpgsqlTypes.NpgsqlPoint(x: 0.24867555925755724d, y: 0.35574545840906857d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16188287425048242d, y: 0.3575203308780428d), new NpgsqlTypes.NpgsqlPoint(x: 0.10041002774141039d, y: 0.0874850556012694d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223898406385467d, y: 0.9937822301231545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9341448598146266d, y: 0.826703905788208d), new NpgsqlTypes.NpgsqlPoint(x: 0.11211973073276893d, y: 0.7735759210725494d), new NpgsqlTypes.NpgsqlPoint(x: 0.40941946641646d, y: 0.13288878437016782d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5798897390685154d, y: 0.014657182537160751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930539132968301d, y: 0.26106899636683045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970539361398236d, y: 0.5900859534930388d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23300884215833917d, y: 0.4365033485012103d), new NpgsqlTypes.NpgsqlPoint(x: 0.24456360514614672d, y: 0.45133414016315565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688253466177204d, y: 0.7288324776590465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165052373691557d, y: 0.045546314043492186d), new NpgsqlTypes.NpgsqlPoint(x: 0.4142440701230258d, y: 0.8003243769819282d), new NpgsqlTypes.NpgsqlPoint(x: 0.09750860720941157d, y: 0.07943406920191365d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.219542993492164d, y: 0.2940135473135945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763172628775789d, y: 0.6741297416646164d), new NpgsqlTypes.NpgsqlPoint(x: 0.04106852911017378d, y: 0.15133677870688278d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.384890632018839d, y: 0.14473633177303646d), new NpgsqlTypes.NpgsqlPoint(x: 0.025610861022916542d, y: 0.5754542810672834d), new NpgsqlTypes.NpgsqlPoint(x: 0.16620047962466178d, y: 0.6064392339310497d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48923632941577166d, y: 0.361395878237158d), new NpgsqlTypes.NpgsqlPoint(x: 0.13843956924188672d, y: 0.41309622732401585d), new NpgsqlTypes.NpgsqlPoint(x: 0.48334986276418956d, y: 0.09971135412637455d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22521195214457623d, y: 0.8594876516806753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1642946115387357d, y: 0.9048796455190612d), new NpgsqlTypes.NpgsqlPoint(x: 0.06192100862600669d, y: 0.4842288930463958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6553101321301463d, y: 0.42352969441443233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262786060788571d, y: 0.5443834341298296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670484560269451d, y: 0.49991606615680795d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11149078197898799d, y: 0.8986734814974784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179822426764084d, y: 0.7038563831475478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593906645616229d, y: 0.27854759713537913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.967236911676014d, y: 0.5780476169668848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357410084633932d, y: 0.43137823517214424d), new NpgsqlTypes.NpgsqlPoint(x: 0.393531153353196d, y: 0.3138280709575887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16854722332985084d, y: 0.13135353643800218d), new NpgsqlTypes.NpgsqlPoint(x: 0.38288176931731543d, y: 0.8084122584278906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034365730530018d, y: 0.29223041698377383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.873217950266325d, y: 0.6947629844628415d), new NpgsqlTypes.NpgsqlPoint(x: 0.16467028777748405d, y: 0.38979864368584194d), new NpgsqlTypes.NpgsqlPoint(x: 0.36517608807628876d, y: 0.11641379317930955d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28543465028341863d, y: 0.6564505492502196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171205431252931d, y: 0.1255412443767412d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303769764329535d, y: 0.8600113015632063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1646889743999881d, y: 0.14155053512144622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524777933041867d, y: 0.7459174162331439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636575387305621d, y: 0.47974063985839377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.841766343524646d, y: 0.17674210544082636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567272840239373d, y: 0.33024280795471117d), new NpgsqlTypes.NpgsqlPoint(x: 0.43769063674299713d, y: 0.5241296109045974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42746570570948694d, y: 0.4706604031792866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621335778421265d, y: 0.8039363825432464d), new NpgsqlTypes.NpgsqlPoint(x: 0.964935925586067d, y: 0.7464675418997774d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716690859306949d, y: 0.36251311287444343d), new NpgsqlTypes.NpgsqlPoint(x: 0.27060360785246573d, y: 0.5944363913218305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218438075673482d, y: 0.8013032730777192d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06635879397398736d, y: 0.37100175591592655d), new NpgsqlTypes.NpgsqlPoint(x: 0.25118955320511394d, y: 0.2853787696686465d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925163433521781d, y: 0.5721811006899918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8110277144805074d, y: 0.9263719425903585d), new NpgsqlTypes.NpgsqlPoint(x: 0.2977880521895202d, y: 0.4177725786811217d), new NpgsqlTypes.NpgsqlPoint(x: 0.18564205554971402d, y: 0.009306366274895783d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9404324099034551d, y: 0.31813491247228876d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011947144501165408d, y: 0.48171874098054657d), new NpgsqlTypes.NpgsqlPoint(x: 0.3398216904237157d, y: 0.7047448762776676d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04094904670940347d, y: 0.5462909199801873d), new NpgsqlTypes.NpgsqlPoint(x: 0.25725455699612376d, y: 0.7519552039924049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055778089939355d, y: 0.5977051313170227d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8412938046829458d, y: 0.6175292925615228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003425051525365d, y: 0.1763936251806889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930364126350562d, y: 0.09128620558977174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23052633669937705d, y: 0.16806828608064606d), new NpgsqlTypes.NpgsqlPoint(x: 0.04574687536644495d, y: 0.8311650763303876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516787322816068d, y: 0.510169447782556d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8031884103664063d, y: 0.9704556705554512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997186754257138d, y: 0.8498570564678677d), new NpgsqlTypes.NpgsqlPoint(x: 0.25189322254068236d, y: 0.4071986552465542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.64280958526105d, y: 0.9274930435948602d), new NpgsqlTypes.NpgsqlPoint(x: 0.12099736367062175d, y: 0.49357767919744877d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717475323883804d, y: 0.1417358297223934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32617750845655813d, y: 0.017925771101170773d), new NpgsqlTypes.NpgsqlPoint(x: 0.4935335327460906d, y: 0.6229941932452865d), new NpgsqlTypes.NpgsqlPoint(x: 0.41853396441789714d, y: 0.15375181649777614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8300009025525538d, y: 0.12525234266277763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5527427489640799d, y: 0.025711481684647874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3052322552353466d, y: 0.6783205112716548d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18861561873270072d, y: 0.9646798425150229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204484312043372d, y: 0.10225357185947126d), new NpgsqlTypes.NpgsqlPoint(x: 0.47885723928906065d, y: 0.8709928974699848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6349673019428428d, y: 0.7504464080431452d), new NpgsqlTypes.NpgsqlPoint(x: 0.13408806397665363d, y: 0.9082423199280312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952715063657194d, y: 0.34898423564321257d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7108918096195547d, y: 0.2029803925793876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230163953568668d, y: 0.3304126651034516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5698648055991943d, y: 0.8105772484398551d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.738941923614821d, y: 0.37141427305377817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291682584235332d, y: 0.9863700871467513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423047044199029d, y: 0.9327170503500057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5481751004783233d, y: 0.3024026797410737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844898155861908d, y: 0.252802975930539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881233194813688d, y: 0.942617188308599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2672480586857917d, y: 0.9592521818660998d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056594351995513d, y: 0.47154945405748194d), new NpgsqlTypes.NpgsqlPoint(x: 0.13349622221537238d, y: 0.6118369285039591d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0013828882652854313d, y: 0.3661928220503199d), new NpgsqlTypes.NpgsqlPoint(x: 0.1240254710753893d, y: 0.7214142109887378d), new NpgsqlTypes.NpgsqlPoint(x: 0.9237822944288315d, y: 0.22972546815372397d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6059610485861943d, y: 0.6935025867818764d), new NpgsqlTypes.NpgsqlPoint(x: 0.10577613137100106d, y: 0.41355938098328604d), new NpgsqlTypes.NpgsqlPoint(x: 0.03973860423948006d, y: 0.6865242171480299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6776064597764256d, y: 0.8942879898658517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3725848762972671d, y: 0.3995571827658706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607255132348066d, y: 0.8759209343910823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9555761161978292d, y: 0.5179129518919593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662619747529581d, y: 0.9078433534396603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695029223790867d, y: 0.09236491848567496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0757078042742223d, y: 0.25516653504430475d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418565399629991d, y: 0.4697930174586189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7074384860803394d, y: 0.15882848133664518d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088657747324098d, y: 0.9129206139152963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924490866469168d, y: 0.8536151041145732d), new NpgsqlTypes.NpgsqlPoint(x: 0.07054382851933605d, y: 0.7296407981176085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707458340111989d, y: 0.44674757198396486d), new NpgsqlTypes.NpgsqlPoint(x: 0.42546958711792715d, y: 0.5409984251062508d), new NpgsqlTypes.NpgsqlPoint(x: 0.33170440209778984d, y: 0.5356613492119326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46680934775068617d, y: 0.10092909885412316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925491751332011d, y: 0.6805163872351794d), new NpgsqlTypes.NpgsqlPoint(x: 0.2652619056848404d, y: 0.544939257847044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4242782158228383d, y: 0.7112228258050457d), new NpgsqlTypes.NpgsqlPoint(x: 0.17973354765060356d, y: 0.9192612730505526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195278608875271d, y: 0.8095792971075305d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9070894681702105d, y: 0.8629641179736857d), new NpgsqlTypes.NpgsqlPoint(x: 0.36129534690892073d, y: 0.4720760514168243d), new NpgsqlTypes.NpgsqlPoint(x: 0.0577069790322946d, y: 0.4291764595191916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6151254241454691d, y: 0.6456237248780827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723474138170958d, y: 0.15801946831726454d), new NpgsqlTypes.NpgsqlPoint(x: 0.06508442259430436d, y: 0.11982453114898672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5708294184089072d, y: 0.3892647319174566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646129468385442d, y: 0.595481780390599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438940540483236d, y: 0.8403046753411827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32601609393664643d, y: 0.2616958469211268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908718170315349d, y: 0.11437127892113275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685433667960254d, y: 0.40206547794482783d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.542448711805681d, y: 0.8151416585439585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674899443211551d, y: 0.8361025632909018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262398031848242d, y: 0.0188323945662896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4208460435295045d, y: 0.24269100027118362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924570641437699d, y: 0.4207874451823187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494907936308225d, y: 0.9126580456552491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9527722866131128d, y: 0.19332979424441288d), new NpgsqlTypes.NpgsqlPoint(x: 0.19514538700939243d, y: 0.5550736165624615d), new NpgsqlTypes.NpgsqlPoint(x: 0.35166241046105073d, y: 0.16073156462117155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7170573508576883d, y: 0.5192911439835701d), new NpgsqlTypes.NpgsqlPoint(x: 0.18348519763220117d, y: 0.610849170447385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060941796278271d, y: 0.4649828363866133d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.820158797339846d, y: 0.740540398506379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5672424278436579d, y: 0.4238669057418383d), new NpgsqlTypes.NpgsqlPoint(x: 0.635829264104557d, y: 0.7759237649314374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7109107598785911d, y: 0.8722011457099657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254265109377306d, y: 0.9500384350198424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040454053980282d, y: 0.6419999681564207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7879247078125318d, y: 0.07991069959196773d), new NpgsqlTypes.NpgsqlPoint(x: 0.964077735839052d, y: 0.410338189799076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580918569984484d, y: 0.5834418941436942d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9347127680058082d, y: 0.6290651881871007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578302764261653d, y: 0.49544275253680126d), new NpgsqlTypes.NpgsqlPoint(x: 0.16045785044364713d, y: 0.20571060625016424d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3900117197306219d, y: 0.9752204016835929d), new NpgsqlTypes.NpgsqlPoint(x: 0.05103527900749594d, y: 0.6126562005309668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340249080342297d, y: 0.846455046653067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8097893731952058d, y: 0.5068239328912205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166393624174837d, y: 0.32882482342784414d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800441881198247d, y: 0.9491313174608312d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5633644340398611d, y: 0.542933152537513d), new NpgsqlTypes.NpgsqlPoint(x: 0.17268934321641038d, y: 0.21621581284993863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558426643435254d, y: 0.23193545642750513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8381729231466639d, y: 0.622393444879637d), new NpgsqlTypes.NpgsqlPoint(x: 0.02220766754853165d, y: 0.051342395496200566d), new NpgsqlTypes.NpgsqlPoint(x: 0.19978393215908963d, y: 0.6326863573112362d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.301805406158685d, y: 0.7556528313789882d), new NpgsqlTypes.NpgsqlPoint(x: 0.37921813527702d, y: 0.4246611317514053d), new NpgsqlTypes.NpgsqlPoint(x: 0.27406205002450934d, y: 0.39802723553613084d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.280049056023129d, y: 0.5517070281595445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4551745979546359d, y: 0.3320769156373907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7883613005439233d, y: 0.11351180016374829d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7622605681798929d, y: 0.9299586292306622d), new NpgsqlTypes.NpgsqlPoint(x: 0.8881279651118811d, y: 0.4581952297446694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100751025464849d, y: 0.6522683488142026d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734568083563439d, y: 0.7829772301518758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461153311059397d, y: 0.5038947223024703d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089340301412294d, y: 0.9748161028911976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22548510256417587d, y: 0.9090791558812513d), new NpgsqlTypes.NpgsqlPoint(x: 0.31693597267995044d, y: 0.4626505862214225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431327985899292d, y: 0.5120112033380682d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4530188547826023d, y: 0.7187615723674183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950011633628195d, y: 0.8574987841810303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148991506216469d, y: 0.21162481030732838d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7775363384796994d, y: 0.49792774011230023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974634802782016d, y: 0.785650481064767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9831875581958255d, y: 0.39598486357860474d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6389678034538194d, y: 0.057507515901145556d), new NpgsqlTypes.NpgsqlPoint(x: 0.30315874820129773d, y: 0.6736891532887763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630267964569703d, y: 0.3564725755726764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35091295224307506d, y: 0.8091880861777047d), new NpgsqlTypes.NpgsqlPoint(x: 0.592344346664179d, y: 0.748752368014224d), new NpgsqlTypes.NpgsqlPoint(x: 0.812047571791944d, y: 0.6202294037331101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.637955716960305d, y: 0.6868936275888557d), new NpgsqlTypes.NpgsqlPoint(x: 0.12077360903099466d, y: 0.19188614678985316d), new NpgsqlTypes.NpgsqlPoint(x: 0.2856468239586244d, y: 0.8696266201150565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38119661450440423d, y: 0.9184156937439595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147195640312795d, y: 0.20548136888597823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117387897046685d, y: 0.6684141793103535d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.938809790588539d, y: 0.6534298699613159d), new NpgsqlTypes.NpgsqlPoint(x: 0.14387518374033403d, y: 0.03500814016483844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364576030270605d, y: 0.36888838482893416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0441350572785798d, y: 0.6709458179790869d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175900707672952d, y: 0.97333778514341d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631389014200424d, y: 0.37632798472961504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14594094339971486d, y: 0.123072102766831d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014882977701201d, y: 0.875080453543104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197172071120905d, y: 0.8359339324324052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4018049602525313d, y: 0.23429982933049698d), new NpgsqlTypes.NpgsqlPoint(x: 0.16122116088494776d, y: 0.02138995970538715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7989087527374439d, y: 0.2532044635117642d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30144953425080956d, y: 0.12229164638862233d), new NpgsqlTypes.NpgsqlPoint(x: 0.4614446735813834d, y: 0.892434207815106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384081839473214d, y: 0.9074180862495653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1858410676062595d, y: 0.19950309607046113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967482755042448d, y: 0.03650373984213484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544571330717046d, y: 0.9607681407256139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34058681596461016d, y: 0.9698527244223074d), new NpgsqlTypes.NpgsqlPoint(x: 0.41186680317119195d, y: 0.09254972335264233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638902938519435d, y: 0.9033030631432581d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6341100966322257d, y: 0.451178225498171d), new NpgsqlTypes.NpgsqlPoint(x: 0.994872871066733d, y: 0.018880117008131414d), new NpgsqlTypes.NpgsqlPoint(x: 0.681373105716667d, y: 0.44348880301040905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9464457481736992d, y: 0.22519847130227122d), new NpgsqlTypes.NpgsqlPoint(x: 0.27055844683147745d, y: 0.7796312918370464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422416620636485d, y: 0.6686716512975046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04382179401946584d, y: 0.3181959539755429d), new NpgsqlTypes.NpgsqlPoint(x: 0.28448094195583085d, y: 0.4664595479182503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739516228425502d, y: 0.8447248122694974d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8113493139874719d, y: 0.3562452347859709d), new NpgsqlTypes.NpgsqlPoint(x: 0.23270473095853617d, y: 0.7764705323264639d), new NpgsqlTypes.NpgsqlPoint(x: 0.00758299949456398d, y: 0.6990132092500915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34147362666215697d, y: 0.019789330255413518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199071348420352d, y: 0.22610658292785035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205561358609567d, y: 0.7653062172569299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06485035007290596d, y: 0.6003055745240058d), new NpgsqlTypes.NpgsqlPoint(x: 0.27626329119274873d, y: 0.5017358750437624d), new NpgsqlTypes.NpgsqlPoint(x: 0.40838573201065065d, y: 0.5194546053581375d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8896997511194875d, y: 0.3740712398820212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3365287509106679d, y: 0.32896151506519555d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840317213952339d, y: 0.4272926322354552d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2870011604195539d, y: 0.2820739300367012d), new NpgsqlTypes.NpgsqlPoint(x: 0.17334891081436066d, y: 0.4279712211837692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521332776834409d, y: 0.06080132665536431d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7648483879079723d, y: 0.060261252120490605d), new NpgsqlTypes.NpgsqlPoint(x: 0.45817054375011557d, y: 0.9918760852351068d), new NpgsqlTypes.NpgsqlPoint(x: 0.12347820450341818d, y: 0.137624560677426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6787648986697401d, y: 0.9823135402612531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890027465791396d, y: 0.6434103884769161d), new NpgsqlTypes.NpgsqlPoint(x: 0.33389396728622545d, y: 0.4879586036067254d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4534156964519185d, y: 0.5058978607242246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806876539598292d, y: 0.5150201186253861d), new NpgsqlTypes.NpgsqlPoint(x: 0.23640441664285095d, y: 0.5519666556879095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8125366930580783d, y: 0.771304522921782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256042617431884d, y: 0.8933577501679564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5405845594302814d, y: 0.1022508113235393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157258583422167d, y: 0.309950289449893d), new NpgsqlTypes.NpgsqlPoint(x: 0.22911089255012806d, y: 0.41332975905528746d), new NpgsqlTypes.NpgsqlPoint(x: 0.31857939619286113d, y: 0.36791953117088183d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011295045567897288d, y: 0.6058708207655162d), new NpgsqlTypes.NpgsqlPoint(x: 0.20893560728658533d, y: 0.5751252128980214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358086620242492d, y: 0.8948752603069122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.684759054468427d, y: 0.0033847700889350074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8439954716416922d, y: 0.5637320193142766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8804774977395043d, y: 0.7551833714069744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767601400400957d, y: 0.8672028233619425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018829198712965d, y: 0.5228751575044853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657858787064538d, y: 0.29135360439340197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34535488425326555d, y: 0.9205952690100511d), new NpgsqlTypes.NpgsqlPoint(x: 0.005416655814174387d, y: 0.3608532952676472d), new NpgsqlTypes.NpgsqlPoint(x: 0.429362093502893d, y: 0.33980677364163814d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34172453116062984d, y: 0.9980597490410198d), new NpgsqlTypes.NpgsqlPoint(x: 0.24188061164714758d, y: 0.6781091466484893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506149188247567d, y: 0.2638918191989894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006498876382277863d, y: 0.37682900825201393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593564661816659d, y: 0.8167345610073578d), new NpgsqlTypes.NpgsqlPoint(x: 0.36920426749009305d, y: 0.6873835002436384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6717512089933053d, y: 0.531559623406706d), new NpgsqlTypes.NpgsqlPoint(x: 0.48524100784032176d, y: 0.9717855500892685d), new NpgsqlTypes.NpgsqlPoint(x: 0.34268205806769725d, y: 0.22091900187077917d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49709131744312096d, y: 0.14362894680288474d), new NpgsqlTypes.NpgsqlPoint(x: 0.20640540972791344d, y: 0.9254828094797639d), new NpgsqlTypes.NpgsqlPoint(x: 0.28274606935605007d, y: 0.099859213111256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22481376888163518d, y: 0.6196746679981557d), new NpgsqlTypes.NpgsqlPoint(x: 0.883534148272162d, y: 0.86269849934323d), new NpgsqlTypes.NpgsqlPoint(x: 0.23932147489983946d, y: 0.10605208187149517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8688231080557339d, y: 0.8732655592365264d), new NpgsqlTypes.NpgsqlPoint(x: 0.4225865680879851d, y: 0.2820329071613801d), new NpgsqlTypes.NpgsqlPoint(x: 0.06233058920682166d, y: 0.8900782777513176d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23128942651528506d, y: 0.02300921207187212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597669662745477d, y: 0.3082391691214531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030132245788214d, y: 0.5866751096768443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.381257462669075d, y: 0.0455212358655499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065531301104647d, y: 0.33976436625056994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036097410861946d, y: 0.9421994590497575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5274057564687298d, y: 0.693127736486376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738710921007795d, y: 0.6452762601411741d), new NpgsqlTypes.NpgsqlPoint(x: 0.2724834932986334d, y: 0.04715294366034506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622424967161998d, y: 0.19403384502155507d), new NpgsqlTypes.NpgsqlPoint(x: 0.48989873545950424d, y: 0.1816907877577002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947022696236723d, y: 0.9209023239621106d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5384490642063628d, y: 0.6123071161581504d), new NpgsqlTypes.NpgsqlPoint(x: 0.08476611304191217d, y: 0.6463913657734183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557932229064504d, y: 0.4286435044229897d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06340410513800032d, y: 0.014317311665566601d), new NpgsqlTypes.NpgsqlPoint(x: 0.16059756393233193d, y: 0.9827308732074879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323788866935909d, y: 0.8965293751513477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1433653904292599d, y: 0.09077197470125331d), new NpgsqlTypes.NpgsqlPoint(x: 0.0867725114874256d, y: 0.2502095156257548d), new NpgsqlTypes.NpgsqlPoint(x: 0.28441094384340315d, y: 0.47037573548437417d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12800893095860288d, y: 0.1306848412376863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7981481848712727d, y: 0.12216967550529412d), new NpgsqlTypes.NpgsqlPoint(x: 0.496634749501625d, y: 0.14353968186750532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5731018096088624d, y: 0.8668881740093006d), new NpgsqlTypes.NpgsqlPoint(x: 0.13548862751504287d, y: 0.8673649619318258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732957788106667d, y: 0.48569137715995625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5644143245089961d, y: 0.21093483592112583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7483003124372573d, y: 0.437544757301515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889222798814138d, y: 0.6300327078588142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1273339566065258d, y: 0.9823403478121375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777201661111025d, y: 0.3742740646391536d), new NpgsqlTypes.NpgsqlPoint(x: 0.18273016408039167d, y: 0.3475776036638982d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8303800292773539d, y: 0.6258899067952668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386563166201715d, y: 0.09773987925901595d), new NpgsqlTypes.NpgsqlPoint(x: 0.36147852271167724d, y: 0.2922462723621201d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5292719551450965d, y: 0.13604143162323734d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462310429940202d, y: 0.26576763312608676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5120369893005832d, y: 0.8822842613073997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48437804623537706d, y: 0.41435715354428193d), new NpgsqlTypes.NpgsqlPoint(x: 0.17238090594352184d, y: 0.6434316894305067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608978978036103d, y: 0.48563885185139066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38244420870152185d, y: 0.10837853932544472d), new NpgsqlTypes.NpgsqlPoint(x: 0.140746252568007d, y: 0.8275912498633059d), new NpgsqlTypes.NpgsqlPoint(x: 0.47712450371810755d, y: 0.3210835160910611d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6576554524611886d, y: 0.5096008455701874d), new NpgsqlTypes.NpgsqlPoint(x: 0.133235883391707d, y: 0.883127406410365d), new NpgsqlTypes.NpgsqlPoint(x: 0.010975575020588102d, y: 0.9144982564224122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.959624286017806d, y: 0.391308991390824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393920779280481d, y: 0.6633374454844971d), new NpgsqlTypes.NpgsqlPoint(x: 0.06318115013135561d, y: 0.040983515058932274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8714625104604825d, y: 0.6930268245689696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8721064844425331d, y: 0.8723822267361595d), new NpgsqlTypes.NpgsqlPoint(x: 0.17220135536054793d, y: 0.18236168270992226d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15745108255746543d, y: 0.06113480182754105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634101515173043d, y: 0.9080507667577681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266655779088069d, y: 0.8565076084233518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8455826057587392d, y: 0.784346783384851d), new NpgsqlTypes.NpgsqlPoint(x: 0.2674290329037706d, y: 0.8446417620517482d), new NpgsqlTypes.NpgsqlPoint(x: 0.44757584999208755d, y: 0.645989468523878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5142991686703432d, y: 0.9997453858999037d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668188789718644d, y: 0.5701317737443746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035629726269534d, y: 0.8381533028736073d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8480277293971794d, y: 0.0663380195195119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122068025236412d, y: 0.31716374516296997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647469415869625d, y: 0.6580540800789589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7179200055513674d, y: 0.5784976394055572d), new NpgsqlTypes.NpgsqlPoint(x: 0.1928563079560871d, y: 0.3863428344638854d), new NpgsqlTypes.NpgsqlPoint(x: 0.23131668505891512d, y: 0.683924777437699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5640598160266558d, y: 0.1321540959053421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4778315514750582d, y: 0.954433044667855d), new NpgsqlTypes.NpgsqlPoint(x: 0.611345994991311d, y: 0.07135635392519635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16228026660817807d, y: 0.3637289819726275d), new NpgsqlTypes.NpgsqlPoint(x: 0.23161307589293434d, y: 0.5590032495836039d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111635428107421d, y: 0.11189627915580136d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9835310711559375d, y: 0.5287277413274616d), new NpgsqlTypes.NpgsqlPoint(x: 0.07763837608804158d, y: 0.6409087564749306d), new NpgsqlTypes.NpgsqlPoint(x: 0.14089378145406384d, y: 0.895483216403003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4692457683820844d, y: 0.09841288792598424d), new NpgsqlTypes.NpgsqlPoint(x: 0.47393063052392337d, y: 0.05797422750476078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705382810587332d, y: 0.41986605353925743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17354581411127534d, y: 0.721042288929456d), new NpgsqlTypes.NpgsqlPoint(x: 0.1949861945961412d, y: 0.38383956979760514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853002135307559d, y: 0.6942845074150542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897117546136426d, y: 0.19787304636872916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126458311727328d, y: 0.6084403315711558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392465279817889d, y: 0.44550235705849683d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.836480497653752d, y: 0.34528314459574483d), new NpgsqlTypes.NpgsqlPoint(x: 0.06437022055764008d, y: 0.278841194583234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833670896783006d, y: 0.1260630414001218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7628546919364977d, y: 0.758915586969318d), new NpgsqlTypes.NpgsqlPoint(x: 0.36715508579280876d, y: 0.7040580597863024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320757752513923d, y: 0.1527614666455992d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7014566847841401d, y: 0.8911951298617257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826752955263584d, y: 0.2689408024248908d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006317588084193d, y: 0.5459974339666384d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611339795815325d, y: 0.6976754551933616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1874744080091979d, y: 0.06348023373002776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5112524577371513d, y: 0.5469293685655862d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3935410037801168d, y: 0.0060146193239832835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176287566034686d, y: 0.8286498557271714d), new NpgsqlTypes.NpgsqlPoint(x: 0.1982431541796289d, y: 0.7261824259514579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1276456368102844d, y: 0.22989744754744346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9528313888489262d, y: 0.16219686194896377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348562169936504d, y: 0.08928351327501671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18636277159986114d, y: 0.7101415450974135d), new NpgsqlTypes.NpgsqlPoint(x: 0.05449543814425162d, y: 0.045622011554482644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500234094486304d, y: 0.9817080810410093d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4343315378204511d, y: 0.7088041037155903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213940896826256d, y: 0.9693004350114347d), new NpgsqlTypes.NpgsqlPoint(x: 0.052438788026918925d, y: 0.7120344511070384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9199012255968625d, y: 0.5610521132019595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516253938373961d, y: 0.12052059666492698d), new NpgsqlTypes.NpgsqlPoint(x: 0.12334586460221164d, y: 0.8080761932146449d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37038878580527945d, y: 0.11875724027711931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898966299060867d, y: 0.41752037000465747d), new NpgsqlTypes.NpgsqlPoint(x: 0.15079075273072662d, y: 0.2967599716158795d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3192576701836466d, y: 0.8123479558597717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231225129016953d, y: 0.5359238394419318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08810003871520455d, y: 0.7538772139529427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10879047626636118d, y: 0.9793227439871671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340648795845224d, y: 0.5472566021002628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440860529483128d, y: 0.03975211511204135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8102473539595908d, y: 0.4646462617121677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5158338068126095d, y: 0.28314361775553554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6174062617971967d, y: 0.7234239409844045d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6130562008392914d, y: 0.2056329987010035d), new NpgsqlTypes.NpgsqlPoint(x: 0.36127321865179296d, y: 0.22692877354891283d), new NpgsqlTypes.NpgsqlPoint(x: 0.31883207699341154d, y: 0.3272837251632228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1710339611866667d, y: 0.4295438982269836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313942233958842d, y: 0.8678450388138697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435140467263198d, y: 0.3648326884121046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7747705022368397d, y: 0.2020635681392975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6599372915003481d, y: 0.8052991361286491d), new NpgsqlTypes.NpgsqlPoint(x: 0.09927703906777319d, y: 0.6971732183087612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3774649053298613d, y: 0.20256390563172466d), new NpgsqlTypes.NpgsqlPoint(x: 0.14342895031848502d, y: 0.4817670878564668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323224829132801d, y: 0.3233316659782207d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7081473633632422d, y: 0.5962130059039129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897825663426034d, y: 0.47445347318344244d), new NpgsqlTypes.NpgsqlPoint(x: 0.3449326877795236d, y: 0.0837103847607531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22069417697249671d, y: 0.7386824845336583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4102477524862721d, y: 0.5333280638269935d), new NpgsqlTypes.NpgsqlPoint(x: 0.23547648764556361d, y: 0.2667468249171189d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3382308238681695d, y: 0.592003348588002d), new NpgsqlTypes.NpgsqlPoint(x: 0.09643357961870491d, y: 0.601289245788505d), new NpgsqlTypes.NpgsqlPoint(x: 0.20039172872195832d, y: 0.7494215363031945d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9616845554744602d, y: 0.8246201518282446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854085191667477d, y: 0.7317921209642536d), new NpgsqlTypes.NpgsqlPoint(x: 0.21595037354039093d, y: 0.9326162551069042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6915958825599879d, y: 0.07481986114000794d), new NpgsqlTypes.NpgsqlPoint(x: 0.445507942149843d, y: 0.8438182537453878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207008432360481d, y: 0.4489634517076492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8014213569245369d, y: 0.9814154606773268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142194295163871d, y: 0.42978522658648055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126612411197148d, y: 0.4667866215228069d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3574019814289223d, y: 0.27467294463669234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357775775784771d, y: 0.9769669410206623d), new NpgsqlTypes.NpgsqlPoint(x: 0.25779081297629236d, y: 0.2555492528060327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4431218612086669d, y: 0.5074219171215066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176882342273508d, y: 0.17315974917801347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635491847393059d, y: 0.7357980250259155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05589747207766593d, y: 0.9106887208967114d), new NpgsqlTypes.NpgsqlPoint(x: 0.04455766191707056d, y: 0.23667659212133063d), new NpgsqlTypes.NpgsqlPoint(x: 0.29721608134551647d, y: 0.7888487153825097d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6231450156841156d, y: 0.13254718633986418d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320106933373984d, y: 0.2324107936120663d), new NpgsqlTypes.NpgsqlPoint(x: 0.05516423304463991d, y: 0.7059928008777652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.506569647852496d, y: 0.4040072514599473d), new NpgsqlTypes.NpgsqlPoint(x: 0.671932009089016d, y: 0.797931867635306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4460805142484857d, y: 0.6960538171069409d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8092436190749934d, y: 0.7665855020015006d), new NpgsqlTypes.NpgsqlPoint(x: 0.3270282932358667d, y: 0.07426754557986581d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696985854086691d, y: 0.6479115230690651d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664435141078731d, y: 0.44808561699500515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160486584183481d, y: 0.05030341568271557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843508448272488d, y: 0.7193781715770564d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6862127633941197d, y: 0.175644069812954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565388868770738d, y: 0.5772641106884893d), new NpgsqlTypes.NpgsqlPoint(x: 0.193170365423457d, y: 0.9720562050491787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4571474668416886d, y: 0.8366141529542847d), new NpgsqlTypes.NpgsqlPoint(x: 0.801982993911651d, y: 0.3795856536015434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490016762976783d, y: 0.22899262764823813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9202061784868681d, y: 0.7803574948592169d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489341892813467d, y: 0.5575527201120826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808238997208504d, y: 0.9736709297015481d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5141749312344033d, y: 0.054447582702032205d), new NpgsqlTypes.NpgsqlPoint(x: 0.32312335524379876d, y: 0.8388509954936343d), new NpgsqlTypes.NpgsqlPoint(x: 0.394719020685128d, y: 0.34205311209852796d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6776493240271029d, y: 0.5193719738022815d), new NpgsqlTypes.NpgsqlPoint(x: 0.18379704706843414d, y: 0.42698010470332615d), new NpgsqlTypes.NpgsqlPoint(x: 0.32383493301055466d, y: 0.23532351574949184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49133429779637194d, y: 0.629086938679247d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388976911369181d, y: 0.4379038090846047d), new NpgsqlTypes.NpgsqlPoint(x: 0.08642160576012581d, y: 0.2677117531824741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788303783589333d, y: 0.007484787096870615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567386700220719d, y: 0.7370535990145197d), new NpgsqlTypes.NpgsqlPoint(x: 0.19053547436609153d, y: 0.18312335617555442d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51019649035312d, y: 0.6044131580161763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5704365868708536d, y: 0.36459982606996943d), new NpgsqlTypes.NpgsqlPoint(x: 0.21875471945321756d, y: 0.4148171363272185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9502742628150863d, y: 0.882421198867016d), new NpgsqlTypes.NpgsqlPoint(x: 0.1757253438559193d, y: 0.5030998894607898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8872709425053875d, y: 0.573520751926264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4535912747876025d, y: 0.4272458431362336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7366791554699238d, y: 0.6356846551808969d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755602920596556d, y: 0.759358856547032d)),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 137, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 123, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 68, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

