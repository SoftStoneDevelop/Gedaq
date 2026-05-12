

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5803776025519152d, y: 0.3601729396019969d), new NpgsqlTypes.NpgsqlPoint(x: 0.462411657780765d, y: 0.32124210083240223d), new NpgsqlTypes.NpgsqlPoint(x: 0.58519451829712d, y: 0.7054094322800484d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7385504083157379d, y: 0.8617338714807957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786283992181208d, y: 0.8361166778550035d), new NpgsqlTypes.NpgsqlPoint(x: 0.47559165183418683d, y: 0.7682262447592285d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6610091097759336d, y: 0.4572278508195041d), new NpgsqlTypes.NpgsqlPoint(x: 0.1991526011655903d, y: 0.31179265604177575d), new NpgsqlTypes.NpgsqlPoint(x: 0.021257657278807685d, y: 0.4993983582508774d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9492108685605336d, y: 0.924193084464138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789895951901612d, y: 0.7300613537805962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785214635338916d, y: 0.13065359063063087d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.601384090210878d, y: 0.22894285217246846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9650238126405439d, y: 0.1270323936620209d), new NpgsqlTypes.NpgsqlPoint(x: 0.836232533199879d, y: 0.18129907476569007d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8739938779933744d, y: 0.013522554546784527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941161257409025d, y: 0.6456155191765481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791334558156227d, y: 0.4917924142252895d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9831926211152059d, y: 0.42222618134395373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504973658152122d, y: 0.27226578720355477d), new NpgsqlTypes.NpgsqlPoint(x: 0.34429806923263695d, y: 0.04735211028276698d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9600920875196453d, y: 0.3922147812926938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9763638718315139d, y: 0.6567373947354214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107303084532762d, y: 0.9889709483515587d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18430626043361864d, y: 0.30856099551677574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876802142309238d, y: 0.9705860028877448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589146667497194d, y: 0.46923916979130564d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8505013668687287d, y: 0.11920284568297612d), new NpgsqlTypes.NpgsqlPoint(x: 0.866800924485896d, y: 0.6222855761137762d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438717587698062d, y: 0.6359242647275433d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08720802982106934d, y: 0.7953811591705198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701422977033026d, y: 0.2636819277977984d), new NpgsqlTypes.NpgsqlPoint(x: 0.24759418587848836d, y: 0.3962042888554146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1391324817441788d, y: 0.20775159001446541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9734643444226287d, y: 0.663626295119664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633428250235267d, y: 0.8643904131365762d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5218630508382411d, y: 0.6335131907082414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155210039887361d, y: 0.9527518828415622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375480195058011d, y: 0.5298911205312734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9077206879930048d, y: 0.0028780883491620335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697884945890396d, y: 0.517752080106722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171738456609232d, y: 0.6300436428986123d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3357643520781358d, y: 0.2557545748432085d), new NpgsqlTypes.NpgsqlPoint(x: 0.43532603254540847d, y: 0.5325963602868669d), new NpgsqlTypes.NpgsqlPoint(x: 0.06683732098943274d, y: 0.2061661905323452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5950278024198776d, y: 0.040601107043038986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2155237840342914d, y: 0.8599937934422034d), new NpgsqlTypes.NpgsqlPoint(x: 0.32905097372786163d, y: 0.07967861662155284d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.411472668552031d, y: 0.8184525548362993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394230906140158d, y: 0.13777836357405338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3683760708783441d, y: 0.34164589245532295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343485593472394d, y: 0.3802114495207237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706199850733609d, y: 0.000555340069158694d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469751397535006d, y: 0.06840077271666534d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05443628171647141d, y: 0.8511831778714511d), new NpgsqlTypes.NpgsqlPoint(x: 0.963668926529963d, y: 0.6212024402434672d), new NpgsqlTypes.NpgsqlPoint(x: 0.08426296760063812d, y: 0.49885056406922945d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9297299204171051d, y: 0.825050163530606d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564891385914593d, y: 0.5219273956129493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315524621766498d, y: 0.194110766614629d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21736049079770248d, y: 0.061258280658959996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008768932555911d, y: 0.4782915849539692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977902287413668d, y: 0.5999724998219405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5062062521813089d, y: 0.44383796259968056d), new NpgsqlTypes.NpgsqlPoint(x: 0.05423089535901571d, y: 0.23976706868865794d), new NpgsqlTypes.NpgsqlPoint(x: 0.37992095093634404d, y: 0.27178557992191665d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2469014627044407d, y: 0.46161024288005903d), new NpgsqlTypes.NpgsqlPoint(x: 0.3022784223386401d, y: 0.023234029663502298d), new NpgsqlTypes.NpgsqlPoint(x: 0.2286794667958285d, y: 0.17051839342721076d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32416335689908027d, y: 0.39631809523672856d), new NpgsqlTypes.NpgsqlPoint(x: 0.40978083968173495d, y: 0.7027859551797111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363002057433347d, y: 0.47580022980105274d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5684815792874849d, y: 0.7394996685404323d), new NpgsqlTypes.NpgsqlPoint(x: 0.22766442277426868d, y: 0.7100050456654511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1967232666864508d, y: 0.6714682353564514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014528516798049451d, y: 0.9390303332544282d), new NpgsqlTypes.NpgsqlPoint(x: 0.13286612872339176d, y: 0.7826190200020552d), new NpgsqlTypes.NpgsqlPoint(x: 0.15232289557006096d, y: 0.8105789277683525d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.600812958655994d, y: 0.11024835790264786d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011309100341981848d, y: 0.6013324003491272d), new NpgsqlTypes.NpgsqlPoint(x: 0.574691548105737d, y: 0.26626594118911395d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9490807525654827d, y: 0.8030430205014891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860687062357457d, y: 0.29461449053319044d), new NpgsqlTypes.NpgsqlPoint(x: 0.15260809714089252d, y: 0.9042485358714273d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5410781332128198d, y: 0.5344383959800306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3304336529598757d, y: 0.5646897549495165d), new NpgsqlTypes.NpgsqlPoint(x: 0.22722556380150138d, y: 0.06296394239411451d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8083727000388475d, y: 0.38435780011482523d), new NpgsqlTypes.NpgsqlPoint(x: 0.46649064138363927d, y: 0.996863928917735d), new NpgsqlTypes.NpgsqlPoint(x: 0.20188913312072165d, y: 0.34242525167315885d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26400698473704654d, y: 0.827966471442742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731446627453684d, y: 0.2703614362394725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418659255854803d, y: 0.8391447780424941d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6052884119143158d, y: 0.04303584636718194d), new NpgsqlTypes.NpgsqlPoint(x: 0.1703936804602616d, y: 0.15733571224847243d), new NpgsqlTypes.NpgsqlPoint(x: 0.42864659030926244d, y: 0.2778409310829236d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6928114810525909d, y: 0.5466835840605548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325303701623401d, y: 0.5383467047758852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166735008110044d, y: 0.07197920331221008d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25397464177630225d, y: 0.5948165166518284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204892057387096d, y: 0.547051724507016d), new NpgsqlTypes.NpgsqlPoint(x: 0.29208061752007086d, y: 0.7300573275125672d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016334183250507506d, y: 0.7672814368709466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906087211351944d, y: 0.18343443125240155d), new NpgsqlTypes.NpgsqlPoint(x: 0.13681527828007933d, y: 0.05821849732587503d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5567863831144039d, y: 0.4442002380926685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677269449628784d, y: 0.21647050190189376d), new NpgsqlTypes.NpgsqlPoint(x: 0.10179689264653857d, y: 0.05585281690123478d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8013696665527111d, y: 0.6075753779858842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8683722331253564d, y: 0.20554999671347596d), new NpgsqlTypes.NpgsqlPoint(x: 0.22989434406971698d, y: 0.4995020340380405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3313427793846251d, y: 0.604625032517216d), new NpgsqlTypes.NpgsqlPoint(x: 0.675799379126579d, y: 0.3627476861473862d), new NpgsqlTypes.NpgsqlPoint(x: 0.04065402071426216d, y: 0.039954660667148034d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9308670450195125d, y: 0.029298770504886495d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220480176721087d, y: 0.5770442674174301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422991837619837d, y: 0.7726655282992868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5084781509837443d, y: 0.2203996306506868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585577837267378d, y: 0.12199206305559074d), new NpgsqlTypes.NpgsqlPoint(x: 0.761876222721916d, y: 0.4803185608349143d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452581454513634d, y: 0.7659582610202592d), new NpgsqlTypes.NpgsqlPoint(x: 0.10791941603069355d, y: 0.021404952319520665d), new NpgsqlTypes.NpgsqlPoint(x: 0.0947651072691702d, y: 0.8627278226341087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31522079864469155d, y: 0.013502950186996876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2441029478143033d, y: 0.6865962171745082d), new NpgsqlTypes.NpgsqlPoint(x: 0.037261869950117155d, y: 0.930587558339471d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3042293215091513d, y: 0.8000475591188483d), new NpgsqlTypes.NpgsqlPoint(x: 0.36802929071148127d, y: 0.34414681705311234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2967586260021129d, y: 0.05221221511970109d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9719591981406199d, y: 0.9862246221855159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136076953815272d, y: 0.997584681772383d), new NpgsqlTypes.NpgsqlPoint(x: 0.30160456026594773d, y: 0.09170043881566747d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13200070478726011d, y: 0.017675443898273135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6232735061160355d, y: 0.33617449970159985d), new NpgsqlTypes.NpgsqlPoint(x: 0.4771001348784909d, y: 0.8906147235852885d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7914220972218001d, y: 0.6247325970147799d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609161687010052d, y: 0.6082351184966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014305275325678d, y: 0.24213869876479144d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20702020758853446d, y: 0.7175537492126778d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974058552339482d, y: 0.8083821478605596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458164743508357d, y: 0.38710449045533823d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441285790841349d, y: 0.45675521004702724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8665937109930095d, y: 0.6281839906509906d), new NpgsqlTypes.NpgsqlPoint(x: 0.30943910190596513d, y: 0.900221357762676d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405803826544468d, y: 0.7933722011643981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543763872360758d, y: 0.174000059076166d), new NpgsqlTypes.NpgsqlPoint(x: 0.09873910632015281d, y: 0.9567066366639433d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2672999584666007d, y: 0.7640374306660496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772875767821565d, y: 0.2628875242223695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209636793913585d, y: 0.08681952422685313d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49248934396559074d, y: 0.5255720297494613d), new NpgsqlTypes.NpgsqlPoint(x: 0.43443558991865316d, y: 0.7800525850342606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301425881578827d, y: 0.6552963009373891d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006102291545847072d, y: 0.17328488957579502d), new NpgsqlTypes.NpgsqlPoint(x: 0.1645346832896718d, y: 0.08477953691821927d), new NpgsqlTypes.NpgsqlPoint(x: 0.12082058714933241d, y: 0.065399267223341d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03091536495281888d, y: 0.5703093791416365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106884822609319d, y: 0.3957556046125894d), new NpgsqlTypes.NpgsqlPoint(x: 0.24175293302231127d, y: 0.7139941659846096d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9294185897248609d, y: 0.5983263305419118d), new NpgsqlTypes.NpgsqlPoint(x: 0.42495466613529376d, y: 0.639110113987404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9421522832698743d, y: 0.01612782658019829d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9902163736498987d, y: 0.992476238536795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539346880426734d, y: 0.38039710281816197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3146441488093662d, y: 0.7820839764601337d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45672687761239794d, y: 0.20640231087363714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443758722312075d, y: 0.572519316223376d), new NpgsqlTypes.NpgsqlPoint(x: 0.27286792694460005d, y: 0.8963471205239344d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.905354419213458d, y: 0.10161152077191737d), new NpgsqlTypes.NpgsqlPoint(x: 0.22336690041504936d, y: 0.6648356177383419d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899406449392064d, y: 0.2455253939994012d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945164561729685d, y: 0.3286851080274267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008358256487419d, y: 0.061236708169157716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9992007430721968d, y: 0.778451252562716d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05107197658800966d, y: 0.7925933721047295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939014189847553d, y: 0.28416194542345186d), new NpgsqlTypes.NpgsqlPoint(x: 0.39885447385354544d, y: 0.3819320342990109d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9795078054806211d, y: 0.5914460366149399d), new NpgsqlTypes.NpgsqlPoint(x: 0.97438135459002d, y: 0.6036658524318909d), new NpgsqlTypes.NpgsqlPoint(x: 0.005596441361520377d, y: 0.04183802354118149d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26384971920921263d, y: 0.9223295920372727d), new NpgsqlTypes.NpgsqlPoint(x: 0.2771781292928006d, y: 0.1963446255004021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6835713818939281d, y: 0.56697048614593d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40239190256690616d, y: 0.11040433422938745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9214425800762039d, y: 0.3828381401951668d), new NpgsqlTypes.NpgsqlPoint(x: 0.19389555748492304d, y: 0.13226436698421218d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8707961813328328d, y: 0.705923490652697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997361789946495d, y: 0.5984073616167916d), new NpgsqlTypes.NpgsqlPoint(x: 0.1579210733544596d, y: 0.9447284912176273d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1288376449359755d, y: 0.958349950843014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078629389707123d, y: 0.4988473227995365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245087785981536d, y: 0.608175390912516d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374816558238393d, y: 0.05807515879328162d), new NpgsqlTypes.NpgsqlPoint(x: 0.12869790257229752d, y: 0.8099398458104573d), new NpgsqlTypes.NpgsqlPoint(x: 0.1932053539734152d, y: 0.725210760931506d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735903012590051d, y: 0.9767026039707056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465874043242336d, y: 0.6383152086765678d), new NpgsqlTypes.NpgsqlPoint(x: 0.553099733268063d, y: 0.8353857168445623d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08051112077973166d, y: 0.04890645131242555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517203224434544d, y: 0.8725211178822829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6432144848553023d, y: 0.5345412134350551d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048421800091908d, y: 0.11739378835576153d), new NpgsqlTypes.NpgsqlPoint(x: 0.35822398622689466d, y: 0.8103419253617734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178498565153661d, y: 0.7513800261599222d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7281488412992769d, y: 0.811381473482248d), new NpgsqlTypes.NpgsqlPoint(x: 0.1752499675126522d, y: 0.6808443938685544d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435456391989356d, y: 0.03513583325963254d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5747386131663956d, y: 0.4586109618308336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612753865491142d, y: 0.5917681990836615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514711438580838d, y: 0.9724641917302147d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9447651940873041d, y: 0.6785720364517873d), new NpgsqlTypes.NpgsqlPoint(x: 0.05552007616384169d, y: 0.3786308918290471d), new NpgsqlTypes.NpgsqlPoint(x: 0.026024539564891813d, y: 0.1596288893331329d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.562413020656015d, y: 0.5012049625362056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301162385207869d, y: 0.6800275596091326d), new NpgsqlTypes.NpgsqlPoint(x: 0.79453035743378d, y: 0.4936167292637965d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8064200606846255d, y: 0.30551681163069255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169485840624202d, y: 0.9534445716207063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4909184408930729d, y: 0.7924861601245459d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.731477185007908d, y: 0.6851661799428268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198052873939756d, y: 0.8313808689808172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732508064474173d, y: 0.5491279161984683d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5889022855540814d, y: 0.15138275177610738d), new NpgsqlTypes.NpgsqlPoint(x: 0.1208471108321828d, y: 0.9744190650535883d), new NpgsqlTypes.NpgsqlPoint(x: 0.48883406956201314d, y: 0.11984165686822534d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5654385584274711d, y: 0.7890554970198325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253900354608959d, y: 0.11863000304360238d), new NpgsqlTypes.NpgsqlPoint(x: 0.12167317483465123d, y: 0.6103843796586246d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034963358304033854d, y: 0.4581370199771132d), new NpgsqlTypes.NpgsqlPoint(x: 0.12799843247022957d, y: 0.8788247028875603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598524645164226d, y: 0.5781550950153308d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018092960298305094d, y: 0.8494379150561401d), new NpgsqlTypes.NpgsqlPoint(x: 0.42931198456184794d, y: 0.8186834058037937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128560400527107d, y: 0.8375780870776817d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0028765635153187308d, y: 0.44687215293259275d), new NpgsqlTypes.NpgsqlPoint(x: 0.005472312231779242d, y: 0.9109783947406435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883139947097829d, y: 0.6905178123160706d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4758502538743027d, y: 0.9499586212888437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046586650465641d, y: 0.3767334683589234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185878908229432d, y: 0.7388198774994311d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9978227099751678d, y: 0.8870149047599613d), new NpgsqlTypes.NpgsqlPoint(x: 0.41772267971773136d, y: 0.1350676797839021d), new NpgsqlTypes.NpgsqlPoint(x: 0.11261990009937228d, y: 0.07221116800231353d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38340746148391647d, y: 0.42074387432728255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998552609727316d, y: 0.8121827999382255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548436435536313d, y: 0.4895501004872249d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8846541460131164d, y: 0.09136223514609221d), new NpgsqlTypes.NpgsqlPoint(x: 0.04256132538309654d, y: 0.8521392867405365d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867252359649739d, y: 0.09521916055098412d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6024847291586054d, y: 0.9272380651714954d), new NpgsqlTypes.NpgsqlPoint(x: 0.34712141999442936d, y: 0.44642781904086437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464464785700443d, y: 0.4619708475369525d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6454490271131681d, y: 0.8795134099449705d), new NpgsqlTypes.NpgsqlPoint(x: 0.553424278826523d, y: 0.17401081874428437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639126042104777d, y: 0.5074595066942611d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5113440467770299d, y: 0.14501903819275574d), new NpgsqlTypes.NpgsqlPoint(x: 0.08733409401657033d, y: 0.7978200412478819d), new NpgsqlTypes.NpgsqlPoint(x: 0.846505984544824d, y: 0.07026728062646792d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4229400097831282d, y: 0.08059611900748731d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836455944916097d, y: 0.8406466956593353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561033302163051d, y: 0.9141221472051717d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13663997991180166d, y: 0.48976688894714104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437322418739075d, y: 0.49641500476934663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282425012213533d, y: 0.8182646550327285d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9850322638346237d, y: 0.09795372045840633d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936558402408151d, y: 0.330716984435655d), new NpgsqlTypes.NpgsqlPoint(x: 0.19831963799939079d, y: 0.41942433988369154d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3297022388498406d, y: 0.08825085061120164d), new NpgsqlTypes.NpgsqlPoint(x: 0.3715713922776219d, y: 0.25220327543621657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449434822179548d, y: 0.9926988151528819d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21431928187480775d, y: 0.08455229287075672d), new NpgsqlTypes.NpgsqlPoint(x: 0.547815400735455d, y: 0.03226103938592806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423594153365495d, y: 0.7301272816090214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9313383180544086d, y: 0.8031761498936152d), new NpgsqlTypes.NpgsqlPoint(x: 0.2030070827508066d, y: 0.790497725050288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363554256117961d, y: 0.5569485405824187d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4549901620115654d, y: 0.7104078302074016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4823863680974221d, y: 0.05677300243166261d), new NpgsqlTypes.NpgsqlPoint(x: 0.321589411825392d, y: 0.23200078224875353d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6891954382062631d, y: 0.09925821263618351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418118354720631d, y: 0.1934074395092945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707157209661693d, y: 0.8963338554119245d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5015676342485843d, y: 0.3320582934529148d), new NpgsqlTypes.NpgsqlPoint(x: 0.587164631405488d, y: 0.3291358138657806d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921616447976488d, y: 0.3265510768533234d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44995262626166477d, y: 0.3268802694576459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371912710780957d, y: 0.30180089550188693d), new NpgsqlTypes.NpgsqlPoint(x: 0.2635925828181276d, y: 0.9042023677841502d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07921112051115164d, y: 0.6219494474895577d), new NpgsqlTypes.NpgsqlPoint(x: 0.15358574703365535d, y: 0.39116296144885887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4040336658662085d, y: 0.4230456876582933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7897709473248015d, y: 0.3167819880340593d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532055848577685d, y: 0.7587852067258588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152776040383997d, y: 0.31916036310574936d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08324684454294429d, y: 0.08529137962531874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536922519473492d, y: 0.2671005110981033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626235690891382d, y: 0.2114741564700764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5478754195050205d, y: 0.8460705188907663d), new NpgsqlTypes.NpgsqlPoint(x: 0.587056761284609d, y: 0.29647331262140975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04219778770157734d, y: 0.3247061943793432d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023129642003995143d, y: 0.7503438133638254d), new NpgsqlTypes.NpgsqlPoint(x: 0.27098716106276544d, y: 0.2618892688435953d), new NpgsqlTypes.NpgsqlPoint(x: 0.30050191158060124d, y: 0.17094004713415323d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4622951441382903d, y: 0.8735682193141109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034959862815599d, y: 0.20546178697513828d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924498228357883d, y: 0.5552029296847112d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8348739542049893d, y: 0.556177008784216d), new NpgsqlTypes.NpgsqlPoint(x: 0.527591866718894d, y: 0.9565879974634871d), new NpgsqlTypes.NpgsqlPoint(x: 0.2906128013789776d, y: 0.3051551230301335d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43079003915865133d, y: 0.3278728160329083d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696731589819763d, y: 0.052270237705281386d), new NpgsqlTypes.NpgsqlPoint(x: 0.18887374985547944d, y: 0.6798671639278955d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3976401580258955d, y: 0.9487028966305471d), new NpgsqlTypes.NpgsqlPoint(x: 0.10288850089880364d, y: 0.7649421834150791d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326026177145726d, y: 0.46021172570085467d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6708828437976184d, y: 0.7756052857285796d), new NpgsqlTypes.NpgsqlPoint(x: 0.24802869778458014d, y: 0.7963960892559471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320429419648534d, y: 0.5516111266099081d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8842793550993291d, y: 0.007963064104653417d), new NpgsqlTypes.NpgsqlPoint(x: 0.20885750120308078d, y: 0.8356763656614155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353221948755622d, y: 0.9685991981314118d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8596429029670593d, y: 0.9756435088144737d), new NpgsqlTypes.NpgsqlPoint(x: 0.3042634707521117d, y: 0.054278819976358084d), new NpgsqlTypes.NpgsqlPoint(x: 0.023226721050387145d, y: 0.6046648277187776d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8815255479191445d, y: 0.8738565190177234d), new NpgsqlTypes.NpgsqlPoint(x: 0.22598995741067662d, y: 0.07347465646937124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483234115199755d, y: 0.9027583636576172d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29328703670307865d, y: 0.43018253996748257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310998189519607d, y: 0.565844549347856d), new NpgsqlTypes.NpgsqlPoint(x: 0.360941858852882d, y: 0.4175787436570111d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8413183035634143d, y: 0.647075342573363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379930562023044d, y: 0.4733807930023992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151953191370443d, y: 0.7484723036816149d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5628122972848536d, y: 0.6062485944636415d), new NpgsqlTypes.NpgsqlPoint(x: 0.042810117987107876d, y: 0.030100102869154544d), new NpgsqlTypes.NpgsqlPoint(x: 0.37010780929128295d, y: 0.1136999737918103d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20435761279598375d, y: 0.15800912507627474d), new NpgsqlTypes.NpgsqlPoint(x: 0.19498708510856855d, y: 0.6865329052145904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820595330129419d, y: 0.16963720856248954d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.84541452407932d, y: 0.8207556302027634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6247275795489309d, y: 0.6799619398077785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7501445135196788d, y: 0.8392363112128228d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43561442995186606d, y: 0.318764244094494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354904385358118d, y: 0.5904191045094961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103345421100462d, y: 0.005338126830020329d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4548108780602319d, y: 0.37144818842387595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4303353539427833d, y: 0.8944532603998079d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000664632691041d, y: 0.9086955710358678d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28054080403388537d, y: 0.2863799231728652d), new NpgsqlTypes.NpgsqlPoint(x: 0.698160259373674d, y: 0.03261593528361806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2430336205132526d, y: 0.47854373421325536d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37086960920559375d, y: 0.33489624621828773d), new NpgsqlTypes.NpgsqlPoint(x: 0.22197509103888835d, y: 0.35371390780083056d), new NpgsqlTypes.NpgsqlPoint(x: 0.06674374502161873d, y: 0.7914323702639955d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5406332817932998d, y: 0.14121018688904707d), new NpgsqlTypes.NpgsqlPoint(x: 0.1665483087016122d, y: 0.42016999477814965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818974411489627d, y: 0.9001335273792035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3274850451147526d, y: 0.390928094048105d), new NpgsqlTypes.NpgsqlPoint(x: 0.13207560407844976d, y: 0.5813680872124523d), new NpgsqlTypes.NpgsqlPoint(x: 0.44947674861602827d, y: 0.9136188283450771d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.85109125722022d, y: 0.37999612358748347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977305901393742d, y: 0.996116998435217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727071826948273d, y: 0.17957246114698544d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7841315852530283d, y: 0.2352444115326804d), new NpgsqlTypes.NpgsqlPoint(x: 0.013295570409970647d, y: 0.9995053740381481d), new NpgsqlTypes.NpgsqlPoint(x: 0.11272042965662998d, y: 0.7441793716146957d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057996472334487015d, y: 0.48565312198625477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916980638678617d, y: 0.1423149751485533d), new NpgsqlTypes.NpgsqlPoint(x: 0.471149644006971d, y: 0.6340863860334462d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03210836644958015d, y: 0.6904782881962706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4650599671106811d, y: 0.5240017822166879d), new NpgsqlTypes.NpgsqlPoint(x: 0.1073109301588473d, y: 0.749273164609919d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857854890042724d, y: 0.11018273783037646d), new NpgsqlTypes.NpgsqlPoint(x: 0.42297357319079154d, y: 0.03474571658640779d), new NpgsqlTypes.NpgsqlPoint(x: 0.27049440074945286d, y: 0.13399608816458508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9841820118343549d, y: 0.4840378504706361d), new NpgsqlTypes.NpgsqlPoint(x: 0.899267592989074d, y: 0.7349082843511591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250076281264814d, y: 0.1878553458003006d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43695847973708934d, y: 0.8773732656368444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121088706425924d, y: 0.12713186025472623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718182217855133d, y: 0.4266509305675217d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679032370388763d, y: 0.16428037788144578d), new NpgsqlTypes.NpgsqlPoint(x: 0.909392627081703d, y: 0.5822668968966616d), new NpgsqlTypes.NpgsqlPoint(x: 0.10343520482565427d, y: 0.09274151011295595d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.681784304064454d, y: 0.37814902531445593d), new NpgsqlTypes.NpgsqlPoint(x: 0.1856609332952851d, y: 0.1337136613281238d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465060430098623d, y: 0.4229585948175736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04796694837319404d, y: 0.8832391896983023d), new NpgsqlTypes.NpgsqlPoint(x: 0.336312996523244d, y: 0.19500684820633607d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945018778823033d, y: 0.21938736714348772d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9779407399187083d, y: 0.07041383598193718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433715711198601d, y: 0.3243396834584067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840741945681209d, y: 0.5242794771697523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3037890152130268d, y: 0.4487007386665045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422545248522066d, y: 0.18686834159259746d), new NpgsqlTypes.NpgsqlPoint(x: 0.11124215508806101d, y: 0.5360573651277041d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45467489190504917d, y: 0.8735831920939143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436888667325224d, y: 0.23865460391086413d), new NpgsqlTypes.NpgsqlPoint(x: 0.312368255489782d, y: 0.1318425898610356d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6882602222041297d, y: 0.8233840870303119d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948863149189831d, y: 0.960331580116611d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547183772792328d, y: 0.7507045038093365d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7662979562171783d, y: 0.6228481559556039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085364836535192d, y: 0.8741107905748772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9074140094063193d, y: 0.3168322944972881d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347994237623906d, y: 0.5320525448276157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833228685485591d, y: 0.5646097704357138d), new NpgsqlTypes.NpgsqlPoint(x: 0.7640290723398289d, y: 0.8150113793308501d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3571651995837367d, y: 0.39066668130821747d), new NpgsqlTypes.NpgsqlPoint(x: 0.37872250344934744d, y: 0.5114518528387948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687398595328307d, y: 0.6654188264721531d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09569157721035393d, y: 0.10729055881547511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2320563914357271d, y: 0.410861206585842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440144779429227d, y: 0.08381471826748477d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15418262145773376d, y: 0.4402563450650183d), new NpgsqlTypes.NpgsqlPoint(x: 0.10349138629530608d, y: 0.6365374820895282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7064035563534566d, y: 0.08182797835584099d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08537912643752976d, y: 0.6559501446189536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010389901161749d, y: 0.540480670153105d), new NpgsqlTypes.NpgsqlPoint(x: 0.12453713242366748d, y: 0.8647426413767278d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1386201332296224d, y: 0.10580279481640753d), new NpgsqlTypes.NpgsqlPoint(x: 0.15108150810251364d, y: 0.25606592595577427d), new NpgsqlTypes.NpgsqlPoint(x: 0.23417202310943397d, y: 0.35361239373810827d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042345080399947d, y: 0.16104148883201475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123748056103347d, y: 0.43401565656498353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5460835688818425d, y: 0.9972786970168216d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4702157439577834d, y: 0.20584858226825142d), new NpgsqlTypes.NpgsqlPoint(x: 0.09554515042310263d, y: 0.3672866626678858d), new NpgsqlTypes.NpgsqlPoint(x: 0.914991207738795d, y: 0.6399098329299d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16816977406406786d, y: 0.6251885053738144d), new NpgsqlTypes.NpgsqlPoint(x: 0.023470691326904936d, y: 0.1893540437638751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774887793349206d, y: 0.5013765107242623d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5985720511995939d, y: 0.20615241366098036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384058363324339d, y: 0.5635593914858416d), new NpgsqlTypes.NpgsqlPoint(x: 0.21659323060948443d, y: 0.4771029466882589d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464240140292022d, y: 0.04712962091576278d), new NpgsqlTypes.NpgsqlPoint(x: 0.19257838404576577d, y: 0.287619566267612d), new NpgsqlTypes.NpgsqlPoint(x: 0.14265605586676033d, y: 0.30373241920015137d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8960650057197199d, y: 0.21492642662762707d), new NpgsqlTypes.NpgsqlPoint(x: 0.20494120810689653d, y: 0.0802060215593422d), new NpgsqlTypes.NpgsqlPoint(x: 0.07670414411849857d, y: 0.31376005291117237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4312940809363053d, y: 0.3999928418959914d), new NpgsqlTypes.NpgsqlPoint(x: 0.491238873969034d, y: 0.08912175023549773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673713564863382d, y: 0.7407560628442039d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44668169128786406d, y: 0.7711766896125742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4499661298423917d, y: 0.9424356867697982d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808619281034403d, y: 0.3113048566901585d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9808637488093258d, y: 0.24498512207966472d), new NpgsqlTypes.NpgsqlPoint(x: 0.15981463302691212d, y: 0.3202744305664711d), new NpgsqlTypes.NpgsqlPoint(x: 0.25232384633157634d, y: 0.7875784477383219d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3527678456790264d, y: 0.6438006785479667d), new NpgsqlTypes.NpgsqlPoint(x: 0.11872071611903456d, y: 0.9491225145068378d), new NpgsqlTypes.NpgsqlPoint(x: 0.24151165892826543d, y: 0.49781254580424883d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4097744030542312d, y: 0.27912588740380995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6161107822894953d, y: 0.4830058606873472d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296154095490118d, y: 0.2390151691088067d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9561087771861685d, y: 0.5670619776897317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903716393190788d, y: 0.8673555115744438d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273973470869513d, y: 0.07913380552144245d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34765006183322156d, y: 0.38886724228478686d), new NpgsqlTypes.NpgsqlPoint(x: 0.34086121430895266d, y: 0.6661736952026045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946312553296711d, y: 0.3731805716371107d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.888861654117583d, y: 0.6946749412633493d), new NpgsqlTypes.NpgsqlPoint(x: 0.08939788892589506d, y: 0.03949065727166745d), new NpgsqlTypes.NpgsqlPoint(x: 0.33438664881085745d, y: 0.18155359155752837d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359228985332756d, y: 0.5853824823043127d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241899166754466d, y: 0.5135670186411789d), new NpgsqlTypes.NpgsqlPoint(x: 0.09697806720974456d, y: 0.7579741120372261d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338454790207753d, y: 0.05556717981542314d), new NpgsqlTypes.NpgsqlPoint(x: 0.1003774992719556d, y: 0.22617564004005164d), new NpgsqlTypes.NpgsqlPoint(x: 0.848426549481243d, y: 0.0447807162152799d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7479075708411607d, y: 0.41153668737557925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449608577862362d, y: 0.7734151161162423d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948557352668236d, y: 0.9654804955667643d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49409688883735037d, y: 0.11880654982498173d), new NpgsqlTypes.NpgsqlPoint(x: 0.18358081949797378d, y: 0.3112282463920214d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827864054313881d, y: 0.23267241338821532d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6869378144827685d, y: 0.1632651218050849d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018559565881175d, y: 0.20671012396488653d), new NpgsqlTypes.NpgsqlPoint(x: 0.14731655771138819d, y: 0.8220289006265551d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4305557047561642d, y: 0.19899746542548025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129011880583483d, y: 0.4698138465841011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891832302330743d, y: 0.031115046699974003d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.516770436934802d, y: 0.8499588791481707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160186655577049d, y: 0.5571343583859812d), new NpgsqlTypes.NpgsqlPoint(x: 0.48268225052033953d, y: 0.3965513841458639d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3458229138733715d, y: 0.2413765640692792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923464967091848d, y: 0.49566778619613316d), new NpgsqlTypes.NpgsqlPoint(x: 0.41811793739816083d, y: 0.9600614455128539d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537709910457783d, y: 0.3567621010957942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3959648624634954d, y: 0.9609892857317949d), new NpgsqlTypes.NpgsqlPoint(x: 0.2967026585309116d, y: 0.17906756978640948d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11315930230412541d, y: 0.09754894627742161d), new NpgsqlTypes.NpgsqlPoint(x: 0.20065519903803986d, y: 0.7998517916588764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722047122300578d, y: 0.0924966374722681d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3339314207769357d, y: 0.3020656527154615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078357550770464d, y: 0.17515828165905134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445205068526317d, y: 0.9668671775397369d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6559890527016763d, y: 0.35671691113851633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023018072731555d, y: 0.893361676371283d), new NpgsqlTypes.NpgsqlPoint(x: 0.4580855324239046d, y: 0.18256038132410035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7431376906432939d, y: 0.4942107061224835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378541505034014d, y: 0.9350205548980599d), new NpgsqlTypes.NpgsqlPoint(x: 0.08446391809235188d, y: 0.30896291406572085d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8304192145879308d, y: 0.8582427670445518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999351139120229d, y: 0.2906597167063314d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096912548563114d, y: 0.17819046524916005d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7813193453376204d, y: 0.3346118480529572d), new NpgsqlTypes.NpgsqlPoint(x: 0.937767681243945d, y: 0.4507165430224729d), new NpgsqlTypes.NpgsqlPoint(x: 0.768571762179029d, y: 0.39718779426107886d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7314790551103633d, y: 0.4273879408730178d), new NpgsqlTypes.NpgsqlPoint(x: 0.45153615289068716d, y: 0.935988869453574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454868348508423d, y: 0.8153758969143509d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5951903458961085d, y: 0.14994606558496315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919253925210961d, y: 0.887018650810065d), new NpgsqlTypes.NpgsqlPoint(x: 0.11730154328722431d, y: 0.8909614399549557d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28735475288915147d, y: 0.9385253934774981d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069282608606156d, y: 0.8575056675814092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215670427142626d, y: 0.7039630264789881d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12620263012923383d, y: 0.4772570175258136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819347118864924d, y: 0.15395434995828094d), new NpgsqlTypes.NpgsqlPoint(x: 0.3132255914113805d, y: 0.11195138798539439d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08380442324597093d, y: 0.25591288871434903d), new NpgsqlTypes.NpgsqlPoint(x: 0.46643266661418314d, y: 0.5141959858115012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5432702023071915d, y: 0.004530950438265013d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11428241780344428d, y: 0.07557393280767366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064996429061438d, y: 0.007013351937573353d), new NpgsqlTypes.NpgsqlPoint(x: 0.0324706120285041d, y: 0.16163253909018427d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6824389975495379d, y: 0.015379588619049644d), new NpgsqlTypes.NpgsqlPoint(x: 0.122614520862517d, y: 0.38093376355434483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534318290120403d, y: 0.9862416312662224d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19531663584266146d, y: 0.41058356712660615d), new NpgsqlTypes.NpgsqlPoint(x: 0.08163920580784956d, y: 0.8891168056350554d), new NpgsqlTypes.NpgsqlPoint(x: 0.4726585311254604d, y: 0.8018839219326803d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1746316167078218d, y: 0.0050542267709570154d), new NpgsqlTypes.NpgsqlPoint(x: 0.762096525778447d, y: 0.20734348279531034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8937567612482396d, y: 0.4653166011205947d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3663472878955303d, y: 0.575952373448187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689406268808388d, y: 0.8383251834553572d), new NpgsqlTypes.NpgsqlPoint(x: 0.541344453479081d, y: 0.2041725574459513d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9613786340644455d, y: 0.3574694593421006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358795903555161d, y: 0.001601828312193021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367321850110277d, y: 0.5434314803694783d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6765240305898146d, y: 0.9914629817108646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079830155659037d, y: 0.687568075396627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4413177984423521d, y: 0.4186082186333152d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23987141716265514d, y: 0.6697304270614718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8282159478565776d, y: 0.4686024018904693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471253339974942d, y: 0.004425507282186714d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21369725636002923d, y: 0.6405266842007602d), new NpgsqlTypes.NpgsqlPoint(x: 0.762643884229016d, y: 0.007076471580527155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8811562680767628d, y: 0.7141102995838005d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03994635569400806d, y: 0.904817588043172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887813618232675d, y: 0.3124530807878325d), new NpgsqlTypes.NpgsqlPoint(x: 0.30806221422892854d, y: 0.7949290933701935d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6632772023750424d, y: 0.5786805973591292d), new NpgsqlTypes.NpgsqlPoint(x: 0.64366852061692d, y: 0.8425631802205017d), new NpgsqlTypes.NpgsqlPoint(x: 0.04334822152491957d, y: 0.8665291165202782d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31478307792628113d, y: 0.7603581643349023d), new NpgsqlTypes.NpgsqlPoint(x: 0.917176667593814d, y: 0.6085441069373629d), new NpgsqlTypes.NpgsqlPoint(x: 0.24988456402921888d, y: 0.9171653470738044d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9784611515726535d, y: 0.23745180760179152d), new NpgsqlTypes.NpgsqlPoint(x: 0.0988866513356591d, y: 0.022298958385811196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6169110139737184d, y: 0.5200340938501152d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039233524625000515d, y: 0.6948440230670806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558801121612822d, y: 0.16954242738518954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708074629786354d, y: 0.7091961452730605d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6967899676637762d, y: 0.10215090014172012d), new NpgsqlTypes.NpgsqlPoint(x: 0.34861034057968276d, y: 0.19375807758910768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875826634226793d, y: 0.6838566557197374d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9933748874278209d, y: 0.37666746420414965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634356164047896d, y: 0.3862298797683448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471976872537634d, y: 0.03915657078073065d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8731761335155587d, y: 0.4007326702089332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833580595837661d, y: 0.8966900217757954d), new NpgsqlTypes.NpgsqlPoint(x: 0.04905855077750321d, y: 0.6910069771500637d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8491730711932947d, y: 0.87210576715096d), new NpgsqlTypes.NpgsqlPoint(x: 0.23802834596967948d, y: 0.4730278501827657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033030364624427d, y: 0.17268103114302613d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38341992129349545d, y: 0.36358841387933216d), new NpgsqlTypes.NpgsqlPoint(x: 0.16241225847590468d, y: 0.6608467443540071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808769354089607d, y: 0.04148028084792976d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4826672792062152d, y: 0.6186520419651149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4922403269796949d, y: 0.4467204248859743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134935495137745d, y: 0.4280260031584898d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2058993039666478d, y: 0.7510388973405938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168527473906678d, y: 0.972789634546482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6754100356268944d, y: 0.4411007323056141d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33748777116887885d, y: 0.6707219390613782d), new NpgsqlTypes.NpgsqlPoint(x: 0.3921175628176745d, y: 0.7938075349759328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870904317466532d, y: 0.5279304631674349d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7254760520106467d, y: 0.5581541564808213d), new NpgsqlTypes.NpgsqlPoint(x: 0.42811103765343295d, y: 0.5580236930918357d), new NpgsqlTypes.NpgsqlPoint(x: 0.30929989696570104d, y: 0.8430980867415492d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.713469806467815d, y: 0.3935005874738855d), new NpgsqlTypes.NpgsqlPoint(x: 0.151694265943216d, y: 0.7370671467277755d), new NpgsqlTypes.NpgsqlPoint(x: 0.4542977869740823d, y: 0.9171972137702482d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07854999261947537d, y: 0.8853592243452514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550386287294963d, y: 0.7430428769419308d), new NpgsqlTypes.NpgsqlPoint(x: 0.06747083306012958d, y: 0.9587415728760476d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5808400889878755d, y: 0.40086659704231253d), new NpgsqlTypes.NpgsqlPoint(x: 0.282248013396585d, y: 0.5513318359640904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5812302887167926d, y: 0.8533051501669291d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8807541209837094d, y: 0.3964048850643136d), new NpgsqlTypes.NpgsqlPoint(x: 0.6602834576465537d, y: 0.04268087028176204d), new NpgsqlTypes.NpgsqlPoint(x: 0.40104660779096224d, y: 0.23663014238323377d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7105338213596372d, y: 0.8177619593151704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900246162964969d, y: 0.3670198747562352d), new NpgsqlTypes.NpgsqlPoint(x: 0.08687212530878108d, y: 0.5967452689959916d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9683381281379899d, y: 0.44198412435706835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9069780175040721d, y: 0.9196203774228148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729756980460757d, y: 0.8094647583734006d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4221918953259842d, y: 0.048871301598711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937103469041098d, y: 0.30972761847155905d), new NpgsqlTypes.NpgsqlPoint(x: 0.03293110236138508d, y: 0.3955059891072267d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10050656250937995d, y: 0.4827959907271898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4269011692570217d, y: 0.45852906634170565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908630923183797d, y: 0.4210149929026594d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9794780954694953d, y: 0.6386150189252071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526695658937419d, y: 0.44999970661033206d), new NpgsqlTypes.NpgsqlPoint(x: 0.013484682424533823d, y: 0.5561889133054322d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42239147288452816d, y: 0.4056737532390947d), new NpgsqlTypes.NpgsqlPoint(x: 0.39729261826772067d, y: 0.15106337379056245d), new NpgsqlTypes.NpgsqlPoint(x: 0.44882130111110785d, y: 0.8706298616401866d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6432892372248694d, y: 0.055043868213444536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5372442432588452d, y: 0.6552235065004015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213943754784218d, y: 0.5934548296387375d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1084443158061622d, y: 0.651013148623084d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788928288982401d, y: 0.04293894638213169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7480378706891808d, y: 0.6813992425582369d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42756706777335074d, y: 0.8559976729131777d), new NpgsqlTypes.NpgsqlPoint(x: 0.1431812411513479d, y: 0.026077778849956212d), new NpgsqlTypes.NpgsqlPoint(x: 0.046042244975462165d, y: 0.9813646374763412d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11902356321813046d, y: 0.7783334991485354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6593644978224185d, y: 0.44714523943740125d), new NpgsqlTypes.NpgsqlPoint(x: 0.11926916459841086d, y: 0.3682082784348728d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7597616031308793d, y: 0.7574090459023247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863060493104086d, y: 0.8217438416394943d), new NpgsqlTypes.NpgsqlPoint(x: 0.17039917871725774d, y: 0.6372527974086628d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01818125513604374d, y: 0.3686709777249092d), new NpgsqlTypes.NpgsqlPoint(x: 0.05787663082236727d, y: 0.32334286563485903d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081509289086911d, y: 0.7875234743197199d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06363810357824051d, y: 0.9570586503951705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270658320767868d, y: 0.8844916319957308d), new NpgsqlTypes.NpgsqlPoint(x: 0.41862982578976105d, y: 0.16677844009868503d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8850859508709643d, y: 0.8563146078610291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965158499258393d, y: 0.757729414107871d), new NpgsqlTypes.NpgsqlPoint(x: 0.055670294626514405d, y: 0.8355503997861605d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32385467094815945d, y: 0.5704576206817955d), new NpgsqlTypes.NpgsqlPoint(x: 0.06581101670746503d, y: 0.4208289664622754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967607926438062d, y: 0.6215165721146393d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2552675770109193d, y: 0.01188642594497702d), new NpgsqlTypes.NpgsqlPoint(x: 0.926670602909834d, y: 0.2581356552915064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128985181701997d, y: 0.15927966594393073d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5979147183093028d, y: 0.4971920349927704d), new NpgsqlTypes.NpgsqlPoint(x: 0.04679080684798975d, y: 0.9285459985544737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8862162373301112d, y: 0.38545662963440264d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.638542451101567d, y: 0.4287839112144719d), new NpgsqlTypes.NpgsqlPoint(x: 0.03673995655090889d, y: 0.6702773018884424d), new NpgsqlTypes.NpgsqlPoint(x: 0.043877166833724d, y: 0.9372495864400606d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39184717807769576d, y: 0.15123393902811944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488107437951933d, y: 0.19362464029336535d), new NpgsqlTypes.NpgsqlPoint(x: 0.28891173681963067d, y: 0.6521088463224105d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09240370864933667d, y: 0.8382056986646214d), new NpgsqlTypes.NpgsqlPoint(x: 0.23064223841048503d, y: 0.1592610923497757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3398648798711936d, y: 0.15531815336057886d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7605704945993202d, y: 0.2612411688682934d), new NpgsqlTypes.NpgsqlPoint(x: 0.22234367172359348d, y: 0.8644206446910733d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063223067333051d, y: 0.8450673559330755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4210125134958935d, y: 0.6714512447907126d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319864006518181d, y: 0.8401584282833541d), new NpgsqlTypes.NpgsqlPoint(x: 0.007604736358057251d, y: 0.6280039222592743d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42193797771368946d, y: 0.5631866728463798d), new NpgsqlTypes.NpgsqlPoint(x: 0.3565175944225255d, y: 0.8012945196728772d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281470110250453d, y: 0.5759074959784012d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35297010022558684d, y: 0.9371662671288383d), new NpgsqlTypes.NpgsqlPoint(x: 0.1686541016490648d, y: 0.9410884126764868d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654187368582419d, y: 0.48279529300565094d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05008247102995378d, y: 0.47800397342877354d), new NpgsqlTypes.NpgsqlPoint(x: 0.23072718854238294d, y: 0.033472697878066615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8307317985094653d, y: 0.48496822491293223d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3899822482081915d, y: 0.8720308382893667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004111175008391d, y: 0.8690369252815777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847826701898237d, y: 0.47706924654118144d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6384354785693227d, y: 0.18743832403608018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166409863780847d, y: 0.04681007502907686d), new NpgsqlTypes.NpgsqlPoint(x: 0.1710527803940265d, y: 0.14407316057173525d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004532000352031829d, y: 0.599253571163701d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799593561000713d, y: 0.7566706507387869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211959249009316d, y: 0.4952640511914368d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14510277028772212d, y: 0.32442658523671286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703046530121098d, y: 0.8672878660998111d), new NpgsqlTypes.NpgsqlPoint(x: 0.44457898544724495d, y: 0.08690813765702443d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753490130976255d, y: 0.750564980276224d), new NpgsqlTypes.NpgsqlPoint(x: 0.30522092269950396d, y: 0.1465960259401159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799337966514707d, y: 0.9821304613102192d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.786932590582277d, y: 0.8267592355705499d), new NpgsqlTypes.NpgsqlPoint(x: 0.447477674004889d, y: 0.7426764990865317d), new NpgsqlTypes.NpgsqlPoint(x: 0.0862821634997547d, y: 0.3958279537604905d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49555212060153475d, y: 0.9651496888539749d), new NpgsqlTypes.NpgsqlPoint(x: 0.4119189245660765d, y: 0.3307085125313979d), new NpgsqlTypes.NpgsqlPoint(x: 0.37449017920020344d, y: 0.6373937422653153d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4898794127786511d, y: 0.33371838403850485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598482278194004d, y: 0.5509066265906665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536130956809372d, y: 0.2066759331675252d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8494322485168277d, y: 0.3004133216923971d), new NpgsqlTypes.NpgsqlPoint(x: 0.260443161953523d, y: 0.2822508631330447d), new NpgsqlTypes.NpgsqlPoint(x: 0.11054489432921688d, y: 0.6810376743480824d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8595525169868595d, y: 0.36740081095258703d), new NpgsqlTypes.NpgsqlPoint(x: 0.06065102678339018d, y: 0.6525541359529606d), new NpgsqlTypes.NpgsqlPoint(x: 0.1467399547188165d, y: 0.5234357201533215d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7562887313329937d, y: 0.16673249734739382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564189188247397d, y: 0.04387695029299754d), new NpgsqlTypes.NpgsqlPoint(x: 0.35531117953800706d, y: 0.4743022856493154d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047970463170557864d, y: 0.7184380123690115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017784515956349d, y: 0.7224402426611202d), new NpgsqlTypes.NpgsqlPoint(x: 0.1493724028987875d, y: 0.09710799437219209d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5779386758289269d, y: 0.6452340765358691d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969362806971273d, y: 0.847573767687224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7074352014954818d, y: 0.3864998606957184d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22256256602599778d, y: 0.9540196137063846d), new NpgsqlTypes.NpgsqlPoint(x: 0.33826601474785534d, y: 0.31517410944571644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458459986717217d, y: 0.49530986495246687d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.103629442852887d, y: 0.38578692441353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951707315821962d, y: 0.3439973576781541d), new NpgsqlTypes.NpgsqlPoint(x: 0.045560543650494556d, y: 0.21241113658024235d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8712909427787983d, y: 0.08441400728552129d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771421525961226d, y: 0.8094688573126512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732497120312257d, y: 0.49616310524752094d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5102052335427449d, y: 0.7726026945378905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770908780015898d, y: 0.9347592537053038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5087832045451223d, y: 0.02031537811891193d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10343537755046905d, y: 0.2717499904957754d), new NpgsqlTypes.NpgsqlPoint(x: 0.919024741474405d, y: 0.9036443676714604d), new NpgsqlTypes.NpgsqlPoint(x: 0.041146136584107595d, y: 0.6199303764575755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2018831918469164d, y: 0.5311521026258655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4294006719060518d, y: 0.23820253586161366d), new NpgsqlTypes.NpgsqlPoint(x: 0.10971606455153271d, y: 0.21084010924626817d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755191050974533d, y: 0.3590939438683415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148470911095735d, y: 0.9464064939723772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531952304457613d, y: 0.5957193591662466d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2919517587613828d, y: 0.8325904137494422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5951112855253223d, y: 0.9787851461796817d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618970284674913d, y: 0.3875091849657133d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27123912389959104d, y: 0.7230828756617146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798785025123801d, y: 0.29202375184332685d), new NpgsqlTypes.NpgsqlPoint(x: 0.05836341207310913d, y: 0.3773995868325358d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34926814357000624d, y: 0.7934874798380426d), new NpgsqlTypes.NpgsqlPoint(x: 0.008675513588630168d, y: 0.8310328343256209d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221836081875503d, y: 0.87991724129591d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22584048586543526d, y: 0.6767728491772544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896825277085028d, y: 0.5254602074068192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667077666503189d, y: 0.1196127708772774d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0383394463308544d, y: 0.26945997717016434d), new NpgsqlTypes.NpgsqlPoint(x: 0.0951853934220217d, y: 0.18253264512353284d), new NpgsqlTypes.NpgsqlPoint(x: 0.31746459647409764d, y: 0.2936650341274689d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19608401766620553d, y: 0.05157859232678619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609982655170217d, y: 0.1867159101918846d), new NpgsqlTypes.NpgsqlPoint(x: 0.4120695875212378d, y: 0.557810154236276d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011591377647537593d, y: 0.3125258833721263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051413975717569d, y: 0.4190986501240459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271961166438907d, y: 0.7965174487377482d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1891491500504886d, y: 0.2864761147230349d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415741315921416d, y: 0.5989584214143973d), new NpgsqlTypes.NpgsqlPoint(x: 0.0716463304381616d, y: 0.14657919823579557d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9436772684794987d, y: 0.5864215944251187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2760636226714981d, y: 0.5913270696669549d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766319101828316d, y: 0.44822639863189273d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6964565695886855d, y: 0.9541810433502987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5284258992017351d, y: 0.8763841090428754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569514743237139d, y: 0.18394674904942776d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3378828363741444d, y: 0.1893260811402946d), new NpgsqlTypes.NpgsqlPoint(x: 0.16602910238517554d, y: 0.33028054452509936d), new NpgsqlTypes.NpgsqlPoint(x: 0.34491718223406176d, y: 0.46348422329651306d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9905030022682124d, y: 0.9114808282801239d), new NpgsqlTypes.NpgsqlPoint(x: 0.130381866536871d, y: 0.2651278931710247d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332236026755505d, y: 0.8059310250898535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2609954993619421d, y: 0.5529533093781864d), new NpgsqlTypes.NpgsqlPoint(x: 0.2157821934193982d, y: 0.6701226356566018d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225173927038113d, y: 0.5250275992406707d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7344021871047455d, y: 0.5553611789639801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300069278941936d, y: 0.6048665255974806d), new NpgsqlTypes.NpgsqlPoint(x: 0.14185813993919727d, y: 0.052137773492294426d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6157212500446966d, y: 0.4562312279405254d), new NpgsqlTypes.NpgsqlPoint(x: 0.36379629432757965d, y: 0.14233476929681033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7555835188744447d, y: 0.6637250126045724d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7191114757736865d, y: 0.6042008963542786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140980886803242d, y: 0.7490093290869032d), new NpgsqlTypes.NpgsqlPoint(x: 0.05105859189596784d, y: 0.754580015944457d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5996429581069985d, y: 0.7805127461730942d), new NpgsqlTypes.NpgsqlPoint(x: 0.2484423502065627d, y: 0.09022396213071238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432334240662341d, y: 0.36014700877278216d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8417041816758927d, y: 0.4336379330482313d), new NpgsqlTypes.NpgsqlPoint(x: 0.054740836120605985d, y: 0.09303870688431126d), new NpgsqlTypes.NpgsqlPoint(x: 0.1424327765670983d, y: 0.45724758426527645d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20207330060614392d, y: 0.8761457603167988d), new NpgsqlTypes.NpgsqlPoint(x: 0.45597402801279063d, y: 0.6272806335067571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7846618398191437d, y: 0.21859166814932418d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8917550652161415d, y: 0.767923531508657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873390182203832d, y: 0.8030822198335892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301807765223367d, y: 0.09411835999571039d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45860732946388827d, y: 0.5893761007736946d), new NpgsqlTypes.NpgsqlPoint(x: 0.13572559504862614d, y: 0.9867688308307505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3992184528355439d, y: 0.09784141063607688d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9507613281016438d, y: 0.7759990610115108d), new NpgsqlTypes.NpgsqlPoint(x: 0.967079633378436d, y: 0.9476314456094864d), new NpgsqlTypes.NpgsqlPoint(x: 0.40236012275736877d, y: 0.43755068497854566d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4596263091182682d, y: 0.3955962182659458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655667443480772d, y: 0.9483159138848762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458124664936292d, y: 0.11311967827828062d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11186162369414243d, y: 0.3056408297667962d), new NpgsqlTypes.NpgsqlPoint(x: 0.12091365933415965d, y: 0.31238549980445696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200233192515282d, y: 0.7403795465563521d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5179129628398783d, y: 0.2920089112955452d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610568900526805d, y: 0.9754216016822954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526878254434434d, y: 0.8506943873193163d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06781775461630757d, y: 0.4678008499802385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026409442138681d, y: 0.7665353270179602d), new NpgsqlTypes.NpgsqlPoint(x: 0.48137988636762297d, y: 0.11287989034826984d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7039244063905501d, y: 0.9485798090323029d), new NpgsqlTypes.NpgsqlPoint(x: 0.4273735676000163d, y: 0.04432800287019678d), new NpgsqlTypes.NpgsqlPoint(x: 0.0671721102639945d, y: 0.765487539315958d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07931934360965553d, y: 0.5614221980650773d), new NpgsqlTypes.NpgsqlPoint(x: 0.22079847587115764d, y: 0.5492754813839602d), new NpgsqlTypes.NpgsqlPoint(x: 0.36893158908455326d, y: 0.09013213603447368d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18885338817202557d, y: 0.9439131577944025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777786293512378d, y: 0.13434452603179103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095867572756895d, y: 0.7313615489720642d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7886057945682605d, y: 0.3929347637860724d), new NpgsqlTypes.NpgsqlPoint(x: 0.10403706432729887d, y: 0.3923727110186198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356309436655696d, y: 0.783879865025905d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9336587514351874d, y: 0.8914547469779461d), new NpgsqlTypes.NpgsqlPoint(x: 0.17022092489871954d, y: 0.44885156373531976d), new NpgsqlTypes.NpgsqlPoint(x: 0.35701493550356467d, y: 0.49130678213148904d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06648980841030228d, y: 0.815388819079818d), new NpgsqlTypes.NpgsqlPoint(x: 0.3134208876597965d, y: 0.10728461974008241d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372761286970688d, y: 0.255177251163173d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30960706314573794d, y: 0.6203071534930861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648592921482387d, y: 0.6777849504443157d), new NpgsqlTypes.NpgsqlPoint(x: 0.19026146978595737d, y: 0.39708073403863053d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08974676119630365d, y: 0.14130059313348264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485785954055613d, y: 0.2716587924574111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7167633740123345d, y: 0.9450726316831815d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6837145835591042d, y: 0.6572518505947504d), new NpgsqlTypes.NpgsqlPoint(x: 0.07205488105706548d, y: 0.971538291701948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386769633344373d, y: 0.591231034984347d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9351469240409259d, y: 0.2938303104631237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009499508248988d, y: 0.06564504963836071d), new NpgsqlTypes.NpgsqlPoint(x: 0.020230335389386234d, y: 0.8559419499926587d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6551477448876278d, y: 0.7537943451088842d), new NpgsqlTypes.NpgsqlPoint(x: 0.2861855880059103d, y: 0.17949930881947818d), new NpgsqlTypes.NpgsqlPoint(x: 0.27210401791051886d, y: 0.6503607048804764d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8855834326129444d, y: 0.520177582724849d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194912016534253d, y: 0.1340695628167321d), new NpgsqlTypes.NpgsqlPoint(x: 0.24017726686071184d, y: 0.6380439799791529d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9186592795229097d, y: 0.09918707557035567d), new NpgsqlTypes.NpgsqlPoint(x: 0.32303176808516376d, y: 0.7543878741644178d), new NpgsqlTypes.NpgsqlPoint(x: 0.798407340187193d, y: 0.19267138031217657d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957357552941d, y: 0.9791989435589608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827634076561144d, y: 0.5062486034395959d), new NpgsqlTypes.NpgsqlPoint(x: 0.612614699651476d, y: 0.8470025667087911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45618926025845574d, y: 0.02522150021767533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591374446613041d, y: 0.5367616915109099d), new NpgsqlTypes.NpgsqlPoint(x: 0.3692119610634189d, y: 0.4331637498624985d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.505732487277746d, y: 0.15969172643067153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7010519130126577d, y: 0.5514195587335419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948412010674154d, y: 0.6494475423196386d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896594308217774d, y: 0.160487044887191d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194591273993522d, y: 0.34803273970182347d), new NpgsqlTypes.NpgsqlPoint(x: 0.488584944808208d, y: 0.1309555160030531d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21479324929306698d, y: 0.4473162837412725d), new NpgsqlTypes.NpgsqlPoint(x: 0.3011528089848372d, y: 0.5809757144648363d), new NpgsqlTypes.NpgsqlPoint(x: 0.04981268203333167d, y: 0.8835233544879207d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006905129927832765d, y: 0.017343562769581156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883398560194817d, y: 0.6207330186486073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738186355699776d, y: 0.6546730297575373d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023431569679269404d, y: 0.3485468353411977d), new NpgsqlTypes.NpgsqlPoint(x: 0.42710803855834456d, y: 0.5543834286797077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8748193739478178d, y: 0.1645659398520487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4906665848119035d, y: 0.532639011697813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4627991752224374d, y: 0.4062595781080103d), new NpgsqlTypes.NpgsqlPoint(x: 0.4557432272757327d, y: 0.6340742827199584d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8640225377413462d, y: 0.22255576726759885d), new NpgsqlTypes.NpgsqlPoint(x: 0.966174533822999d, y: 0.6639311648166617d), new NpgsqlTypes.NpgsqlPoint(x: 0.41929982735803417d, y: 0.6139407252281339d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08405863034877714d, y: 0.6009967330151321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422892847383368d, y: 0.06899374005365744d), new NpgsqlTypes.NpgsqlPoint(x: 0.09412966872109174d, y: 0.14926128327450705d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16494737864660936d, y: 0.62002843846615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287707212152839d, y: 0.268426411475585d), new NpgsqlTypes.NpgsqlPoint(x: 0.11458114510095185d, y: 0.5612141377519487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025993981239113673d, y: 0.24162752393404785d), new NpgsqlTypes.NpgsqlPoint(x: 0.08614478643976775d, y: 0.794895858345799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378021836197553d, y: 0.3794984680488609d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.485037792279883d, y: 0.9531950507241326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9834866689691761d, y: 0.48942609194612985d), new NpgsqlTypes.NpgsqlPoint(x: 0.024730556108824575d, y: 0.06575051692114586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07381130329947128d, y: 0.19977705685110914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5876282465407274d, y: 0.21934599680316624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7960663069618603d, y: 0.9545231331000892d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8348022643705519d, y: 0.19803613699057443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359881390661807d, y: 0.24014929452039568d), new NpgsqlTypes.NpgsqlPoint(x: 0.01783874753027126d, y: 0.8571020135270521d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598243370431561d, y: 0.5983497628300903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423327773716036d, y: 0.7757060791267544d), new NpgsqlTypes.NpgsqlPoint(x: 0.09053851188870632d, y: 0.050876598904661674d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039348290608654d, y: 0.8090833145836558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184819072444206d, y: 0.5679006220770829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655952355960814d, y: 0.11255211588340774d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9342007834467633d, y: 0.26367168393571594d), new NpgsqlTypes.NpgsqlPoint(x: 0.023966404046020906d, y: 0.7093996503641783d), new NpgsqlTypes.NpgsqlPoint(x: 0.09353993587331966d, y: 0.28050824036499733d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5842104288104213d, y: 0.7245375000135599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464023090945739d, y: 0.06527831356115177d), new NpgsqlTypes.NpgsqlPoint(x: 0.699869055947833d, y: 0.9214069248978007d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494047708951508d, y: 0.04912845317602588d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270519436885923d, y: 0.5425795889439593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391625799206116d, y: 0.37833646908839624d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2826820511714302d, y: 0.02179667079359382d), new NpgsqlTypes.NpgsqlPoint(x: 0.23485343197833464d, y: 0.9808455657065523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174776754281971d, y: 0.6254700549299675d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292707129394671d, y: 0.7500395220165155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945044712528181d, y: 0.7445767523314545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076414705840831d, y: 0.8088072518171857d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27717647983449656d, y: 0.14619450191753225d), new NpgsqlTypes.NpgsqlPoint(x: 0.852235739792947d, y: 0.6446377866335313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897275758785278d, y: 0.6466385792791343d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653741394249727d, y: 0.8612278221739871d), new NpgsqlTypes.NpgsqlPoint(x: 0.3355225310458563d, y: 0.9463108428671131d), new NpgsqlTypes.NpgsqlPoint(x: 0.006031597282672885d, y: 0.4386911354511782d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045398931051038094d, y: 0.20569047910428628d), new NpgsqlTypes.NpgsqlPoint(x: 0.34494817090463425d, y: 0.966272541240448d), new NpgsqlTypes.NpgsqlPoint(x: 0.02710120063352084d, y: 0.5090793326450929d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7338026692236751d, y: 0.2665953250598183d), new NpgsqlTypes.NpgsqlPoint(x: 0.4262947839661013d, y: 0.9193655027016289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278115643792636d, y: 0.27455720006145934d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405803826544468d, y: 0.7933722011643981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543763872360758d, y: 0.174000059076166d), new NpgsqlTypes.NpgsqlPoint(x: 0.09873910632015281d, y: 0.9567066366639433d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2672999584666007d, y: 0.7640374306660496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772875767821565d, y: 0.2628875242223695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209636793913585d, y: 0.08681952422685313d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49248934396559074d, y: 0.5255720297494613d), new NpgsqlTypes.NpgsqlPoint(x: 0.43443558991865316d, y: 0.7800525850342606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301425881578827d, y: 0.6552963009373891d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006102291545847072d, y: 0.17328488957579502d), new NpgsqlTypes.NpgsqlPoint(x: 0.1645346832896718d, y: 0.08477953691821927d), new NpgsqlTypes.NpgsqlPoint(x: 0.12082058714933241d, y: 0.065399267223341d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374816558238393d, y: 0.05807515879328162d), new NpgsqlTypes.NpgsqlPoint(x: 0.12869790257229752d, y: 0.8099398458104573d), new NpgsqlTypes.NpgsqlPoint(x: 0.1932053539734152d, y: 0.725210760931506d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735903012590051d, y: 0.9767026039707056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465874043242336d, y: 0.6383152086765678d), new NpgsqlTypes.NpgsqlPoint(x: 0.553099733268063d, y: 0.8353857168445623d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08051112077973166d, y: 0.04890645131242555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517203224434544d, y: 0.8725211178822829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6432144848553023d, y: 0.5345412134350551d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048421800091908d, y: 0.11739378835576153d), new NpgsqlTypes.NpgsqlPoint(x: 0.35822398622689466d, y: 0.8103419253617734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178498565153661d, y: 0.7513800261599222d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9850322638346237d, y: 0.09795372045840633d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936558402408151d, y: 0.330716984435655d), new NpgsqlTypes.NpgsqlPoint(x: 0.19831963799939079d, y: 0.41942433988369154d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3297022388498406d, y: 0.08825085061120164d), new NpgsqlTypes.NpgsqlPoint(x: 0.3715713922776219d, y: 0.25220327543621657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449434822179548d, y: 0.9926988151528819d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21431928187480775d, y: 0.08455229287075672d), new NpgsqlTypes.NpgsqlPoint(x: 0.547815400735455d, y: 0.03226103938592806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423594153365495d, y: 0.7301272816090214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9313383180544086d, y: 0.8031761498936152d), new NpgsqlTypes.NpgsqlPoint(x: 0.2030070827508066d, y: 0.790497725050288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363554256117961d, y: 0.5569485405824187d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07921112051115164d, y: 0.6219494474895577d), new NpgsqlTypes.NpgsqlPoint(x: 0.15358574703365535d, y: 0.39116296144885887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4040336658662085d, y: 0.4230456876582933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7897709473248015d, y: 0.3167819880340593d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532055848577685d, y: 0.7587852067258588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152776040383997d, y: 0.31916036310574936d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08324684454294429d, y: 0.08529137962531874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536922519473492d, y: 0.2671005110981033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626235690891382d, y: 0.2114741564700764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5478754195050205d, y: 0.8460705188907663d), new NpgsqlTypes.NpgsqlPoint(x: 0.587056761284609d, y: 0.29647331262140975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04219778770157734d, y: 0.3247061943793432d)), }, }));
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 9;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 104, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 115, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 32, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 21, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 73, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

