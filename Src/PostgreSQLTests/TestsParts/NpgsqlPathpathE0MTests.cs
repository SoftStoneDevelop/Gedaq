

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513772532259611d, y: 0.8247255283611563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33422218001526194d, y: 0.9111387715993512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968273007230785d, y: 0.1195800221322948d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7905071303314888d, y: 0.03170047535348208d), new NpgsqlTypes.NpgsqlPoint(x: 0.115926696008822d, y: 0.524492117584528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108014851686854d, y: 0.5163192553805229d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41945970241322184d, y: 0.4260319300454407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500317085166255d, y: 0.7505067247098264d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527510751120165d, y: 0.9794205032580249d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693549699282893d, y: 0.8784943458629086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961253049309455d, y: 0.41109951052231175d), new NpgsqlTypes.NpgsqlPoint(x: 0.28328439437490016d, y: 0.841438599842637d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7679278110264203d, y: 0.8471300666802132d), new NpgsqlTypes.NpgsqlPoint(x: 0.30238179523402164d, y: 0.4059711107209971d), new NpgsqlTypes.NpgsqlPoint(x: 0.17330761229388914d, y: 0.6614842707776546d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4343104596079662d, y: 0.8601535180623243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786464958579343d, y: 0.5017776471872911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596072935089407d, y: 0.23116629884867135d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7500672356845702d, y: 0.8566450276711617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113806518356893d, y: 0.8972455814324483d), new NpgsqlTypes.NpgsqlPoint(x: 0.2996469832589911d, y: 0.40164530836000634d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03209023786693077d, y: 0.21351859828567565d), new NpgsqlTypes.NpgsqlPoint(x: 0.11594149417618538d, y: 0.7448794264656008d), new NpgsqlTypes.NpgsqlPoint(x: 0.044006112715168744d, y: 0.6163147784437446d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.251686333222614d, y: 0.2430263985269816d), new NpgsqlTypes.NpgsqlPoint(x: 0.27067659496994023d, y: 0.19418382044918692d), new NpgsqlTypes.NpgsqlPoint(x: 0.37382284096291063d, y: 0.2833828647808936d)),
},
            new NpgsqlPathpathE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09997172012840094d, y: 0.7226801738884814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901865847374705d, y: 0.15870381976125714d), new NpgsqlTypes.NpgsqlPoint(x: 0.005628630641524968d, y: 0.2952898274571498d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6580843041338879d, y: 0.2923971820503066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877682486150285d, y: 0.7602091186698758d), new NpgsqlTypes.NpgsqlPoint(x: 0.38767906204720337d, y: 0.8908177455478493d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357465886762503d, y: 0.8938802391993116d), new NpgsqlTypes.NpgsqlPoint(x: 0.23978004620845716d, y: 0.15021701339889704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878940704368907d, y: 0.859087069668959d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9140454963064957d, y: 0.41950552592766943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199045016476264d, y: 0.4233126327711516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830932815235331d, y: 0.9817878315678522d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046393915523753826d, y: 0.7599052351557525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117617243319938d, y: 0.9277710319939598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578468609159969d, y: 0.3691382255536725d)),
},
            new NpgsqlPathpathE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.92932544835964d, y: 0.741503289433398d), new NpgsqlTypes.NpgsqlPoint(x: 0.79336260345632d, y: 0.07196610468825937d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240675609946494d, y: 0.46491967409808144d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247906368491329d, y: 0.02445543975659592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628447052055414d, y: 0.9604297945850865d), new NpgsqlTypes.NpgsqlPoint(x: 0.33779283120458203d, y: 0.3328088031910884d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4714741552471665d, y: 0.03284892744903967d), new NpgsqlTypes.NpgsqlPoint(x: 0.004352875747683171d, y: 0.006162813160335068d), new NpgsqlTypes.NpgsqlPoint(x: 0.035720726159377714d, y: 0.028239961973875016d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507455330336268d, y: 0.48434337003523575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880054435535545d, y: 0.6378050492562962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413701102472297d, y: 0.5690695479013761d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.850224633969103d, y: 0.5629941514629572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440150451857308d, y: 0.4861546365763928d), new NpgsqlTypes.NpgsqlPoint(x: 0.0953413882532923d, y: 0.47269743473759707d)),
},
            new NpgsqlPathpathE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6997498543125621d, y: 0.02523231172833129d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765696714381539d, y: 0.6170881526246498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14443937112134408d, y: 0.20673034059478224d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09037540864131499d, y: 0.7909007793506684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396853525095558d, y: 0.7851170130767215d), new NpgsqlTypes.NpgsqlPoint(x: 0.040663425043960144d, y: 0.5950436544095179d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556975367295012d, y: 0.46367219707767404d), new NpgsqlTypes.NpgsqlPoint(x: 0.13738174496912692d, y: 0.41197426096115386d), new NpgsqlTypes.NpgsqlPoint(x: 0.25184900077776196d, y: 0.5897037738262013d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9083614694631913d, y: 0.9675051574910009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285309332834257d, y: 0.7104474752657924d), new NpgsqlTypes.NpgsqlPoint(x: 0.46249040506238637d, y: 0.24087453196914466d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251869740157486d, y: 0.6746456548224997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577886857468377d, y: 0.4861931556776745d), new NpgsqlTypes.NpgsqlPoint(x: 0.765631189406284d, y: 0.3073248080802242d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222601593111494d, y: 0.762534306184155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777597838557733d, y: 0.26416745918948825d), new NpgsqlTypes.NpgsqlPoint(x: 0.05387165884988265d, y: 0.03618100580462047d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316386277108425d, y: 0.9061404472239771d), new NpgsqlTypes.NpgsqlPoint(x: 0.22068984571129713d, y: 0.18984141265116505d), new NpgsqlTypes.NpgsqlPoint(x: 0.23798704497581646d, y: 0.2133123880003739d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4718381359116405d, y: 0.8405427087476305d), new NpgsqlTypes.NpgsqlPoint(x: 0.05115366628398843d, y: 0.34853257382855574d), new NpgsqlTypes.NpgsqlPoint(x: 0.06889152113472907d, y: 0.23965803946292985d)),
},
            new NpgsqlPathpathE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4943190067433566d, y: 0.4282073517084407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714710400713162d, y: 0.6550970621253471d), new NpgsqlTypes.NpgsqlPoint(x: 0.2934293057260702d, y: 0.04184687335595916d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17857203620896078d, y: 0.11492601268062974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033467592153546d, y: 0.7683159967137864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33478740282634345d, y: 0.958596831799868d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2516797306283265d, y: 0.7437020936330752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105864631011681d, y: 0.2774403717460533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768611169690497d, y: 0.707519576251096d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3173418433308235d, y: 0.22023453775700697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03133032162329363d, y: 0.6161820562781302d), new NpgsqlTypes.NpgsqlPoint(x: 0.711214539651206d, y: 0.649588406940786d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4743199458493159d, y: 0.1427304104097108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674518843083387d, y: 0.25109312241235504d), new NpgsqlTypes.NpgsqlPoint(x: 0.23878180453210018d, y: 0.178039388220805d)),
},
            new NpgsqlPathpathE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155989320548888d, y: 0.9899443193813162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417157861568557d, y: 0.8893416793687295d), new NpgsqlTypes.NpgsqlPoint(x: 0.71014860245887d, y: 0.520483201257004d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17444126822291783d, y: 0.5517478643357274d), new NpgsqlTypes.NpgsqlPoint(x: 0.24700609408388874d, y: 0.3915373111403103d), new NpgsqlTypes.NpgsqlPoint(x: 0.801935945253918d, y: 0.9228710963138943d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07736151862088458d, y: 0.19290458807439692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991393173850841d, y: 0.4991195020792075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894624594220941d, y: 0.17462875964026525d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431240785385163d, y: 0.2370352522649224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1068237966864326d, y: 0.14164956551091945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572506767579282d, y: 0.5306642698932913d)),
},
            new NpgsqlPathpathE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603431379996435d, y: 0.6043347587510378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458580954095044d, y: 0.11003903561334616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741850410416633d, y: 0.03329317541626864d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3085548812493726d, y: 0.9520032544877657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2260536027281046d, y: 0.8387510512325795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641331552874563d, y: 0.36898710519710143d)),
},
            new NpgsqlPathpathE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29577301760348185d, y: 0.8411793913158334d), new NpgsqlTypes.NpgsqlPoint(x: 0.146660798222483d, y: 0.5223395684687939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141223823136912d, y: 0.19900561061554445d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156512329428131d, y: 0.8010498965879901d), new NpgsqlTypes.NpgsqlPoint(x: 0.38503786318548283d, y: 0.4879662923437881d), new NpgsqlTypes.NpgsqlPoint(x: 0.07536007590123173d, y: 0.20402160625543087d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8285288096791942d, y: 0.94330919012118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1289998901672843d, y: 0.8831964107741007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888245818178547d, y: 0.5849788519970528d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146783112495864d, y: 0.8523823387356496d), new NpgsqlTypes.NpgsqlPoint(x: 0.22454946000594234d, y: 0.16062931293806904d), new NpgsqlTypes.NpgsqlPoint(x: 0.43488082968469777d, y: 0.32663034551614534d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546104306962917d, y: 0.33152622366142237d), new NpgsqlTypes.NpgsqlPoint(x: 0.44274923906635133d, y: 0.5799602595504867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253344018405733d, y: 0.12087555164482056d)),
},
            new NpgsqlPathpathE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5801716971329496d, y: 0.05851677766043217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4699161950341727d, y: 0.8530542521304116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322824217493971d, y: 0.8926558961566256d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.878321125562511d, y: 0.6238611978790242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973903628675989d, y: 0.41870516962162696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7381840604917316d, y: 0.2568333922274356d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43758920570899684d, y: 0.3041354356201791d), new NpgsqlTypes.NpgsqlPoint(x: 0.06011134199864798d, y: 0.5312393317758544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766384344446705d, y: 0.9774239189785761d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807596002141875d, y: 0.455217944299379d), new NpgsqlTypes.NpgsqlPoint(x: 0.2749547749912341d, y: 0.3705093018145508d), new NpgsqlTypes.NpgsqlPoint(x: 0.1202244179805636d, y: 0.8664323697411513d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7653535449282505d, y: 0.35108886986108967d), new NpgsqlTypes.NpgsqlPoint(x: 0.43968891037129443d, y: 0.5628981436522561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618005460436231d, y: 0.31599494183817367d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19648668778375644d, y: 0.4701586919791563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613248415005333d, y: 0.16128575878639562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021696213389326d, y: 0.6286746567837522d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20288229061606644d, y: 0.09920867530057165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307372396935793d, y: 0.7453289702880251d), new NpgsqlTypes.NpgsqlPoint(x: 0.48660561570009153d, y: 0.838960345212939d)),
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5836155740834207d, y: 0.4807475735593255d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696518356265072d, y: 0.5276090238994352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370275708592934d, y: 0.9075311078292776d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4678870584852798d, y: 0.6497023336004861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09061085362612709d, y: 0.3945894910006972d), new NpgsqlTypes.NpgsqlPoint(x: 0.05076802723133578d, y: 0.37721637755152604d)),
},
            new NpgsqlPathpathE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5177311142181433d, y: 0.0017386448883414118d), new NpgsqlTypes.NpgsqlPoint(x: 0.20402493770863572d, y: 0.18115241137919347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2210873149765804d, y: 0.40636464798508887d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8280573460564806d, y: 0.44033753900691075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4979765562583117d, y: 0.2425799634014797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085182538261225d, y: 0.8442633959032321d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805409919763102d, y: 0.05647087845881105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355059905154858d, y: 0.6454410882960312d), new NpgsqlTypes.NpgsqlPoint(x: 0.08854596405157733d, y: 0.8568438743550372d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3338328574893229d, y: 0.9567159100872905d), new NpgsqlTypes.NpgsqlPoint(x: 0.06862864547717962d, y: 0.3932685614179392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4420010692744252d, y: 0.9764903381443762d)),
},
            new NpgsqlPathpathE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18119679460063476d, y: 0.7684071645432907d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608611780249315d, y: 0.08514294789632781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7865766042822314d, y: 0.0033699903639615725d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3734588020592988d, y: 0.4010204434314465d), new NpgsqlTypes.NpgsqlPoint(x: 0.71058005553871d, y: 0.7547323387654916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140094808570886d, y: 0.054690398801105156d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28013150759902117d, y: 0.6301653786128063d), new NpgsqlTypes.NpgsqlPoint(x: 0.02306188072680415d, y: 0.2277129636365639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487059438281487d, y: 0.3118875828914818d)),
},
            new NpgsqlPathpathE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9340054385058197d, y: 0.06494480210220088d), new NpgsqlTypes.NpgsqlPoint(x: 0.35041762909929197d, y: 0.8778928107867793d), new NpgsqlTypes.NpgsqlPoint(x: 0.095950768234488d, y: 0.5796172653263443d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9584289778185062d, y: 0.7205806503214913d), new NpgsqlTypes.NpgsqlPoint(x: 0.279653540832945d, y: 0.7468011345453782d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908614347697217d, y: 0.8395267229799903d)),
},
            new NpgsqlPathpathE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7456533907120548d, y: 0.7075593131060649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353419343363742d, y: 0.7135155472168435d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042405468466913d, y: 0.316337768989399d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8010595307423414d, y: 0.47631605693790313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461911990616898d, y: 0.7152738064060522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416484138840784d, y: 0.44360832978528486d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892836871725272d, y: 0.28152942638802525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049101017377967d, y: 0.4596620534699749d), new NpgsqlTypes.NpgsqlPoint(x: 0.18415731878663455d, y: 0.78800064341476d)),
},
            new NpgsqlPathpathE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375409528874758d, y: 0.592448920609478d), new NpgsqlTypes.NpgsqlPoint(x: 0.30331109427893255d, y: 0.8123838046312155d), new NpgsqlTypes.NpgsqlPoint(x: 0.38214259720673893d, y: 0.15367549594516716d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7147328496701945d, y: 0.8216105486561814d), new NpgsqlTypes.NpgsqlPoint(x: 0.33055544318440067d, y: 0.6462024304789087d), new NpgsqlTypes.NpgsqlPoint(x: 0.10350858682904496d, y: 0.24484296206302947d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2422500010131814d, y: 0.5347871108421978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866933594193589d, y: 0.9111991360221556d), new NpgsqlTypes.NpgsqlPoint(x: 0.651920252368762d, y: 0.9766338741871345d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15723417760560876d, y: 0.8198152455960099d), new NpgsqlTypes.NpgsqlPoint(x: 0.29526314904673256d, y: 0.5659818456139356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218146043203974d, y: 0.8897662545960652d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27197737870200134d, y: 0.7158779032666067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881607436510028d, y: 0.32989704552701704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470341725609406d, y: 0.015286918840621944d)),
},
            new NpgsqlPathpathE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006351341175337d, y: 0.569776448518139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547096620433424d, y: 0.866073871603513d), new NpgsqlTypes.NpgsqlPoint(x: 0.19944983612645106d, y: 0.5202865377842748d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633549624873847d, y: 0.8467877678971643d), new NpgsqlTypes.NpgsqlPoint(x: 0.07504601506827446d, y: 0.09434940743410669d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826566548937993d, y: 0.039125794042585094d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5843838304547053d, y: 0.9415958562941581d), new NpgsqlTypes.NpgsqlPoint(x: 0.23407900615777055d, y: 0.8365534230205008d), new NpgsqlTypes.NpgsqlPoint(x: 0.11452364670663451d, y: 0.6736109605889744d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505565622703877d, y: 0.10999650102770608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537196717402193d, y: 0.052215292980998584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787166675079558d, y: 0.10126694117579693d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7621835779830696d, y: 0.525022349701305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502944867248786d, y: 0.9300909677517206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3846750933316869d, y: 0.18090952429882523d)),
},
            new NpgsqlPathpathE0M
{
    Id = 173,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657472523346597d, y: 0.3276934325669937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474421712394037d, y: 0.7877435686596168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191103415536514d, y: 0.6999622076926896d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131439509262831d, y: 0.4988775570694519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457772812265639d, y: 0.9433752718693585d), new NpgsqlTypes.NpgsqlPoint(x: 0.13151975696822593d, y: 0.63595509275345d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45859063871186123d, y: 0.03614572558945872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891284229874158d, y: 0.936801609188821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313212603754807d, y: 0.13168268455182086d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506847339932541d, y: 0.2429061436014821d), new NpgsqlTypes.NpgsqlPoint(x: 0.22365026946206346d, y: 0.2970079477478068d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423541543918473d, y: 0.7592355249658896d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046393915523753826d, y: 0.7599052351557525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117617243319938d, y: 0.9277710319939598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578468609159969d, y: 0.3691382255536725d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.850224633969103d, y: 0.5629941514629572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440150451857308d, y: 0.4861546365763928d), new NpgsqlTypes.NpgsqlPoint(x: 0.0953413882532923d, y: 0.47269743473759707d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4718381359116405d, y: 0.8405427087476305d), new NpgsqlTypes.NpgsqlPoint(x: 0.05115366628398843d, y: 0.34853257382855574d), new NpgsqlTypes.NpgsqlPoint(x: 0.06889152113472907d, y: 0.23965803946292985d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr2.Value = 113;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 63, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 25, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 57, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 168))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 40, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513772532259611d, y: 0.8247255283611563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33422218001526194d, y: 0.9111387715993512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968273007230785d, y: 0.1195800221322948d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7905071303314888d, y: 0.03170047535348208d), new NpgsqlTypes.NpgsqlPoint(x: 0.115926696008822d, y: 0.524492117584528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108014851686854d, y: 0.5163192553805229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41945970241322184d, y: 0.4260319300454407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500317085166255d, y: 0.7505067247098264d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527510751120165d, y: 0.9794205032580249d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693549699282893d, y: 0.8784943458629086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961253049309455d, y: 0.41109951052231175d), new NpgsqlTypes.NpgsqlPoint(x: 0.28328439437490016d, y: 0.841438599842637d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7679278110264203d, y: 0.8471300666802132d), new NpgsqlTypes.NpgsqlPoint(x: 0.30238179523402164d, y: 0.4059711107209971d), new NpgsqlTypes.NpgsqlPoint(x: 0.17330761229388914d, y: 0.6614842707776546d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4343104596079662d, y: 0.8601535180623243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786464958579343d, y: 0.5017776471872911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596072935089407d, y: 0.23116629884867135d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7500672356845702d, y: 0.8566450276711617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113806518356893d, y: 0.8972455814324483d), new NpgsqlTypes.NpgsqlPoint(x: 0.2996469832589911d, y: 0.40164530836000634d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03209023786693077d, y: 0.21351859828567565d), new NpgsqlTypes.NpgsqlPoint(x: 0.11594149417618538d, y: 0.7448794264656008d), new NpgsqlTypes.NpgsqlPoint(x: 0.044006112715168744d, y: 0.6163147784437446d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.251686333222614d, y: 0.2430263985269816d), new NpgsqlTypes.NpgsqlPoint(x: 0.27067659496994023d, y: 0.19418382044918692d), new NpgsqlTypes.NpgsqlPoint(x: 0.37382284096291063d, y: 0.2833828647808936d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09997172012840094d, y: 0.7226801738884814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901865847374705d, y: 0.15870381976125714d), new NpgsqlTypes.NpgsqlPoint(x: 0.005628630641524968d, y: 0.2952898274571498d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6580843041338879d, y: 0.2923971820503066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877682486150285d, y: 0.7602091186698758d), new NpgsqlTypes.NpgsqlPoint(x: 0.38767906204720337d, y: 0.8908177455478493d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357465886762503d, y: 0.8938802391993116d), new NpgsqlTypes.NpgsqlPoint(x: 0.23978004620845716d, y: 0.15021701339889704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878940704368907d, y: 0.859087069668959d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9140454963064957d, y: 0.41950552592766943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199045016476264d, y: 0.4233126327711516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830932815235331d, y: 0.9817878315678522d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046393915523753826d, y: 0.7599052351557525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117617243319938d, y: 0.9277710319939598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578468609159969d, y: 0.3691382255536725d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.92932544835964d, y: 0.741503289433398d), new NpgsqlTypes.NpgsqlPoint(x: 0.79336260345632d, y: 0.07196610468825937d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240675609946494d, y: 0.46491967409808144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247906368491329d, y: 0.02445543975659592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628447052055414d, y: 0.9604297945850865d), new NpgsqlTypes.NpgsqlPoint(x: 0.33779283120458203d, y: 0.3328088031910884d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4714741552471665d, y: 0.03284892744903967d), new NpgsqlTypes.NpgsqlPoint(x: 0.004352875747683171d, y: 0.006162813160335068d), new NpgsqlTypes.NpgsqlPoint(x: 0.035720726159377714d, y: 0.028239961973875016d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507455330336268d, y: 0.48434337003523575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880054435535545d, y: 0.6378050492562962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413701102472297d, y: 0.5690695479013761d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.850224633969103d, y: 0.5629941514629572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440150451857308d, y: 0.4861546365763928d), new NpgsqlTypes.NpgsqlPoint(x: 0.0953413882532923d, y: 0.47269743473759707d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6997498543125621d, y: 0.02523231172833129d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765696714381539d, y: 0.6170881526246498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14443937112134408d, y: 0.20673034059478224d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09037540864131499d, y: 0.7909007793506684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396853525095558d, y: 0.7851170130767215d), new NpgsqlTypes.NpgsqlPoint(x: 0.040663425043960144d, y: 0.5950436544095179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556975367295012d, y: 0.46367219707767404d), new NpgsqlTypes.NpgsqlPoint(x: 0.13738174496912692d, y: 0.41197426096115386d), new NpgsqlTypes.NpgsqlPoint(x: 0.25184900077776196d, y: 0.5897037738262013d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9083614694631913d, y: 0.9675051574910009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285309332834257d, y: 0.7104474752657924d), new NpgsqlTypes.NpgsqlPoint(x: 0.46249040506238637d, y: 0.24087453196914466d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251869740157486d, y: 0.6746456548224997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577886857468377d, y: 0.4861931556776745d), new NpgsqlTypes.NpgsqlPoint(x: 0.765631189406284d, y: 0.3073248080802242d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222601593111494d, y: 0.762534306184155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777597838557733d, y: 0.26416745918948825d), new NpgsqlTypes.NpgsqlPoint(x: 0.05387165884988265d, y: 0.03618100580462047d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316386277108425d, y: 0.9061404472239771d), new NpgsqlTypes.NpgsqlPoint(x: 0.22068984571129713d, y: 0.18984141265116505d), new NpgsqlTypes.NpgsqlPoint(x: 0.23798704497581646d, y: 0.2133123880003739d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4718381359116405d, y: 0.8405427087476305d), new NpgsqlTypes.NpgsqlPoint(x: 0.05115366628398843d, y: 0.34853257382855574d), new NpgsqlTypes.NpgsqlPoint(x: 0.06889152113472907d, y: 0.23965803946292985d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4943190067433566d, y: 0.4282073517084407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714710400713162d, y: 0.6550970621253471d), new NpgsqlTypes.NpgsqlPoint(x: 0.2934293057260702d, y: 0.04184687335595916d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17857203620896078d, y: 0.11492601268062974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033467592153546d, y: 0.7683159967137864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33478740282634345d, y: 0.958596831799868d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2516797306283265d, y: 0.7437020936330752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105864631011681d, y: 0.2774403717460533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768611169690497d, y: 0.707519576251096d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3173418433308235d, y: 0.22023453775700697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03133032162329363d, y: 0.6161820562781302d), new NpgsqlTypes.NpgsqlPoint(x: 0.711214539651206d, y: 0.649588406940786d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4743199458493159d, y: 0.1427304104097108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674518843083387d, y: 0.25109312241235504d), new NpgsqlTypes.NpgsqlPoint(x: 0.23878180453210018d, y: 0.178039388220805d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155989320548888d, y: 0.9899443193813162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417157861568557d, y: 0.8893416793687295d), new NpgsqlTypes.NpgsqlPoint(x: 0.71014860245887d, y: 0.520483201257004d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17444126822291783d, y: 0.5517478643357274d), new NpgsqlTypes.NpgsqlPoint(x: 0.24700609408388874d, y: 0.3915373111403103d), new NpgsqlTypes.NpgsqlPoint(x: 0.801935945253918d, y: 0.9228710963138943d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07736151862088458d, y: 0.19290458807439692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991393173850841d, y: 0.4991195020792075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894624594220941d, y: 0.17462875964026525d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431240785385163d, y: 0.2370352522649224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1068237966864326d, y: 0.14164956551091945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572506767579282d, y: 0.5306642698932913d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603431379996435d, y: 0.6043347587510378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458580954095044d, y: 0.11003903561334616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741850410416633d, y: 0.03329317541626864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3085548812493726d, y: 0.9520032544877657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2260536027281046d, y: 0.8387510512325795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641331552874563d, y: 0.36898710519710143d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29577301760348185d, y: 0.8411793913158334d), new NpgsqlTypes.NpgsqlPoint(x: 0.146660798222483d, y: 0.5223395684687939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141223823136912d, y: 0.19900561061554445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156512329428131d, y: 0.8010498965879901d), new NpgsqlTypes.NpgsqlPoint(x: 0.38503786318548283d, y: 0.4879662923437881d), new NpgsqlTypes.NpgsqlPoint(x: 0.07536007590123173d, y: 0.20402160625543087d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8285288096791942d, y: 0.94330919012118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1289998901672843d, y: 0.8831964107741007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888245818178547d, y: 0.5849788519970528d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146783112495864d, y: 0.8523823387356496d), new NpgsqlTypes.NpgsqlPoint(x: 0.22454946000594234d, y: 0.16062931293806904d), new NpgsqlTypes.NpgsqlPoint(x: 0.43488082968469777d, y: 0.32663034551614534d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546104306962917d, y: 0.33152622366142237d), new NpgsqlTypes.NpgsqlPoint(x: 0.44274923906635133d, y: 0.5799602595504867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253344018405733d, y: 0.12087555164482056d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5801716971329496d, y: 0.05851677766043217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4699161950341727d, y: 0.8530542521304116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322824217493971d, y: 0.8926558961566256d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.878321125562511d, y: 0.6238611978790242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973903628675989d, y: 0.41870516962162696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7381840604917316d, y: 0.2568333922274356d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43758920570899684d, y: 0.3041354356201791d), new NpgsqlTypes.NpgsqlPoint(x: 0.06011134199864798d, y: 0.5312393317758544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766384344446705d, y: 0.9774239189785761d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807596002141875d, y: 0.455217944299379d), new NpgsqlTypes.NpgsqlPoint(x: 0.2749547749912341d, y: 0.3705093018145508d), new NpgsqlTypes.NpgsqlPoint(x: 0.1202244179805636d, y: 0.8664323697411513d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7653535449282505d, y: 0.35108886986108967d), new NpgsqlTypes.NpgsqlPoint(x: 0.43968891037129443d, y: 0.5628981436522561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618005460436231d, y: 0.31599494183817367d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19648668778375644d, y: 0.4701586919791563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613248415005333d, y: 0.16128575878639562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021696213389326d, y: 0.6286746567837522d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20288229061606644d, y: 0.09920867530057165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307372396935793d, y: 0.7453289702880251d), new NpgsqlTypes.NpgsqlPoint(x: 0.48660561570009153d, y: 0.838960345212939d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5836155740834207d, y: 0.4807475735593255d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696518356265072d, y: 0.5276090238994352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370275708592934d, y: 0.9075311078292776d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4678870584852798d, y: 0.6497023336004861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09061085362612709d, y: 0.3945894910006972d), new NpgsqlTypes.NpgsqlPoint(x: 0.05076802723133578d, y: 0.37721637755152604d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5177311142181433d, y: 0.0017386448883414118d), new NpgsqlTypes.NpgsqlPoint(x: 0.20402493770863572d, y: 0.18115241137919347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2210873149765804d, y: 0.40636464798508887d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8280573460564806d, y: 0.44033753900691075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4979765562583117d, y: 0.2425799634014797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085182538261225d, y: 0.8442633959032321d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805409919763102d, y: 0.05647087845881105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355059905154858d, y: 0.6454410882960312d), new NpgsqlTypes.NpgsqlPoint(x: 0.08854596405157733d, y: 0.8568438743550372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3338328574893229d, y: 0.9567159100872905d), new NpgsqlTypes.NpgsqlPoint(x: 0.06862864547717962d, y: 0.3932685614179392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4420010692744252d, y: 0.9764903381443762d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18119679460063476d, y: 0.7684071645432907d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608611780249315d, y: 0.08514294789632781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7865766042822314d, y: 0.0033699903639615725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3734588020592988d, y: 0.4010204434314465d), new NpgsqlTypes.NpgsqlPoint(x: 0.71058005553871d, y: 0.7547323387654916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140094808570886d, y: 0.054690398801105156d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28013150759902117d, y: 0.6301653786128063d), new NpgsqlTypes.NpgsqlPoint(x: 0.02306188072680415d, y: 0.2277129636365639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487059438281487d, y: 0.3118875828914818d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9340054385058197d, y: 0.06494480210220088d), new NpgsqlTypes.NpgsqlPoint(x: 0.35041762909929197d, y: 0.8778928107867793d), new NpgsqlTypes.NpgsqlPoint(x: 0.095950768234488d, y: 0.5796172653263443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9584289778185062d, y: 0.7205806503214913d), new NpgsqlTypes.NpgsqlPoint(x: 0.279653540832945d, y: 0.7468011345453782d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908614347697217d, y: 0.8395267229799903d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7456533907120548d, y: 0.7075593131060649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353419343363742d, y: 0.7135155472168435d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042405468466913d, y: 0.316337768989399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8010595307423414d, y: 0.47631605693790313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461911990616898d, y: 0.7152738064060522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416484138840784d, y: 0.44360832978528486d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892836871725272d, y: 0.28152942638802525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049101017377967d, y: 0.4596620534699749d), new NpgsqlTypes.NpgsqlPoint(x: 0.18415731878663455d, y: 0.78800064341476d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375409528874758d, y: 0.592448920609478d), new NpgsqlTypes.NpgsqlPoint(x: 0.30331109427893255d, y: 0.8123838046312155d), new NpgsqlTypes.NpgsqlPoint(x: 0.38214259720673893d, y: 0.15367549594516716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7147328496701945d, y: 0.8216105486561814d), new NpgsqlTypes.NpgsqlPoint(x: 0.33055544318440067d, y: 0.6462024304789087d), new NpgsqlTypes.NpgsqlPoint(x: 0.10350858682904496d, y: 0.24484296206302947d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2422500010131814d, y: 0.5347871108421978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866933594193589d, y: 0.9111991360221556d), new NpgsqlTypes.NpgsqlPoint(x: 0.651920252368762d, y: 0.9766338741871345d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15723417760560876d, y: 0.8198152455960099d), new NpgsqlTypes.NpgsqlPoint(x: 0.29526314904673256d, y: 0.5659818456139356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218146043203974d, y: 0.8897662545960652d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27197737870200134d, y: 0.7158779032666067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881607436510028d, y: 0.32989704552701704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470341725609406d, y: 0.015286918840621944d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006351341175337d, y: 0.569776448518139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547096620433424d, y: 0.866073871603513d), new NpgsqlTypes.NpgsqlPoint(x: 0.19944983612645106d, y: 0.5202865377842748d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633549624873847d, y: 0.8467877678971643d), new NpgsqlTypes.NpgsqlPoint(x: 0.07504601506827446d, y: 0.09434940743410669d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826566548937993d, y: 0.039125794042585094d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5843838304547053d, y: 0.9415958562941581d), new NpgsqlTypes.NpgsqlPoint(x: 0.23407900615777055d, y: 0.8365534230205008d), new NpgsqlTypes.NpgsqlPoint(x: 0.11452364670663451d, y: 0.6736109605889744d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505565622703877d, y: 0.10999650102770608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537196717402193d, y: 0.052215292980998584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787166675079558d, y: 0.10126694117579693d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7621835779830696d, y: 0.525022349701305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502944867248786d, y: 0.9300909677517206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3846750933316869d, y: 0.18090952429882523d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657472523346597d, y: 0.3276934325669937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474421712394037d, y: 0.7877435686596168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191103415536514d, y: 0.6999622076926896d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131439509262831d, y: 0.4988775570694519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457772812265639d, y: 0.9433752718693585d), new NpgsqlTypes.NpgsqlPoint(x: 0.13151975696822593d, y: 0.63595509275345d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45859063871186123d, y: 0.03614572558945872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891284229874158d, y: 0.936801609188821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313212603754807d, y: 0.13168268455182086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506847339932541d, y: 0.2429061436014821d), new NpgsqlTypes.NpgsqlPoint(x: 0.22365026946206346d, y: 0.2970079477478068d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423541543918473d, y: 0.7592355249658896d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513772532259611d, y: 0.8247255283611563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33422218001526194d, y: 0.9111387715993512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968273007230785d, y: 0.1195800221322948d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7905071303314888d, y: 0.03170047535348208d), new NpgsqlTypes.NpgsqlPoint(x: 0.115926696008822d, y: 0.524492117584528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108014851686854d, y: 0.5163192553805229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41945970241322184d, y: 0.4260319300454407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500317085166255d, y: 0.7505067247098264d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527510751120165d, y: 0.9794205032580249d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693549699282893d, y: 0.8784943458629086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961253049309455d, y: 0.41109951052231175d), new NpgsqlTypes.NpgsqlPoint(x: 0.28328439437490016d, y: 0.841438599842637d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7679278110264203d, y: 0.8471300666802132d), new NpgsqlTypes.NpgsqlPoint(x: 0.30238179523402164d, y: 0.4059711107209971d), new NpgsqlTypes.NpgsqlPoint(x: 0.17330761229388914d, y: 0.6614842707776546d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4343104596079662d, y: 0.8601535180623243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786464958579343d, y: 0.5017776471872911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596072935089407d, y: 0.23116629884867135d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7500672356845702d, y: 0.8566450276711617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113806518356893d, y: 0.8972455814324483d), new NpgsqlTypes.NpgsqlPoint(x: 0.2996469832589911d, y: 0.40164530836000634d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03209023786693077d, y: 0.21351859828567565d), new NpgsqlTypes.NpgsqlPoint(x: 0.11594149417618538d, y: 0.7448794264656008d), new NpgsqlTypes.NpgsqlPoint(x: 0.044006112715168744d, y: 0.6163147784437446d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.251686333222614d, y: 0.2430263985269816d), new NpgsqlTypes.NpgsqlPoint(x: 0.27067659496994023d, y: 0.19418382044918692d), new NpgsqlTypes.NpgsqlPoint(x: 0.37382284096291063d, y: 0.2833828647808936d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09997172012840094d, y: 0.7226801738884814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901865847374705d, y: 0.15870381976125714d), new NpgsqlTypes.NpgsqlPoint(x: 0.005628630641524968d, y: 0.2952898274571498d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6580843041338879d, y: 0.2923971820503066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877682486150285d, y: 0.7602091186698758d), new NpgsqlTypes.NpgsqlPoint(x: 0.38767906204720337d, y: 0.8908177455478493d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357465886762503d, y: 0.8938802391993116d), new NpgsqlTypes.NpgsqlPoint(x: 0.23978004620845716d, y: 0.15021701339889704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878940704368907d, y: 0.859087069668959d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9140454963064957d, y: 0.41950552592766943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199045016476264d, y: 0.4233126327711516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830932815235331d, y: 0.9817878315678522d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046393915523753826d, y: 0.7599052351557525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117617243319938d, y: 0.9277710319939598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578468609159969d, y: 0.3691382255536725d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.92932544835964d, y: 0.741503289433398d), new NpgsqlTypes.NpgsqlPoint(x: 0.79336260345632d, y: 0.07196610468825937d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240675609946494d, y: 0.46491967409808144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247906368491329d, y: 0.02445543975659592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628447052055414d, y: 0.9604297945850865d), new NpgsqlTypes.NpgsqlPoint(x: 0.33779283120458203d, y: 0.3328088031910884d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4714741552471665d, y: 0.03284892744903967d), new NpgsqlTypes.NpgsqlPoint(x: 0.004352875747683171d, y: 0.006162813160335068d), new NpgsqlTypes.NpgsqlPoint(x: 0.035720726159377714d, y: 0.028239961973875016d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507455330336268d, y: 0.48434337003523575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880054435535545d, y: 0.6378050492562962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413701102472297d, y: 0.5690695479013761d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.850224633969103d, y: 0.5629941514629572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440150451857308d, y: 0.4861546365763928d), new NpgsqlTypes.NpgsqlPoint(x: 0.0953413882532923d, y: 0.47269743473759707d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6997498543125621d, y: 0.02523231172833129d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765696714381539d, y: 0.6170881526246498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14443937112134408d, y: 0.20673034059478224d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09037540864131499d, y: 0.7909007793506684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396853525095558d, y: 0.7851170130767215d), new NpgsqlTypes.NpgsqlPoint(x: 0.040663425043960144d, y: 0.5950436544095179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556975367295012d, y: 0.46367219707767404d), new NpgsqlTypes.NpgsqlPoint(x: 0.13738174496912692d, y: 0.41197426096115386d), new NpgsqlTypes.NpgsqlPoint(x: 0.25184900077776196d, y: 0.5897037738262013d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9083614694631913d, y: 0.9675051574910009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285309332834257d, y: 0.7104474752657924d), new NpgsqlTypes.NpgsqlPoint(x: 0.46249040506238637d, y: 0.24087453196914466d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251869740157486d, y: 0.6746456548224997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577886857468377d, y: 0.4861931556776745d), new NpgsqlTypes.NpgsqlPoint(x: 0.765631189406284d, y: 0.3073248080802242d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222601593111494d, y: 0.762534306184155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777597838557733d, y: 0.26416745918948825d), new NpgsqlTypes.NpgsqlPoint(x: 0.05387165884988265d, y: 0.03618100580462047d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316386277108425d, y: 0.9061404472239771d), new NpgsqlTypes.NpgsqlPoint(x: 0.22068984571129713d, y: 0.18984141265116505d), new NpgsqlTypes.NpgsqlPoint(x: 0.23798704497581646d, y: 0.2133123880003739d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4718381359116405d, y: 0.8405427087476305d), new NpgsqlTypes.NpgsqlPoint(x: 0.05115366628398843d, y: 0.34853257382855574d), new NpgsqlTypes.NpgsqlPoint(x: 0.06889152113472907d, y: 0.23965803946292985d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4943190067433566d, y: 0.4282073517084407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714710400713162d, y: 0.6550970621253471d), new NpgsqlTypes.NpgsqlPoint(x: 0.2934293057260702d, y: 0.04184687335595916d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17857203620896078d, y: 0.11492601268062974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033467592153546d, y: 0.7683159967137864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33478740282634345d, y: 0.958596831799868d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2516797306283265d, y: 0.7437020936330752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105864631011681d, y: 0.2774403717460533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768611169690497d, y: 0.707519576251096d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3173418433308235d, y: 0.22023453775700697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03133032162329363d, y: 0.6161820562781302d), new NpgsqlTypes.NpgsqlPoint(x: 0.711214539651206d, y: 0.649588406940786d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4743199458493159d, y: 0.1427304104097108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674518843083387d, y: 0.25109312241235504d), new NpgsqlTypes.NpgsqlPoint(x: 0.23878180453210018d, y: 0.178039388220805d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155989320548888d, y: 0.9899443193813162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417157861568557d, y: 0.8893416793687295d), new NpgsqlTypes.NpgsqlPoint(x: 0.71014860245887d, y: 0.520483201257004d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17444126822291783d, y: 0.5517478643357274d), new NpgsqlTypes.NpgsqlPoint(x: 0.24700609408388874d, y: 0.3915373111403103d), new NpgsqlTypes.NpgsqlPoint(x: 0.801935945253918d, y: 0.9228710963138943d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07736151862088458d, y: 0.19290458807439692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991393173850841d, y: 0.4991195020792075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894624594220941d, y: 0.17462875964026525d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431240785385163d, y: 0.2370352522649224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1068237966864326d, y: 0.14164956551091945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572506767579282d, y: 0.5306642698932913d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603431379996435d, y: 0.6043347587510378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458580954095044d, y: 0.11003903561334616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741850410416633d, y: 0.03329317541626864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3085548812493726d, y: 0.9520032544877657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2260536027281046d, y: 0.8387510512325795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641331552874563d, y: 0.36898710519710143d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29577301760348185d, y: 0.8411793913158334d), new NpgsqlTypes.NpgsqlPoint(x: 0.146660798222483d, y: 0.5223395684687939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141223823136912d, y: 0.19900561061554445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156512329428131d, y: 0.8010498965879901d), new NpgsqlTypes.NpgsqlPoint(x: 0.38503786318548283d, y: 0.4879662923437881d), new NpgsqlTypes.NpgsqlPoint(x: 0.07536007590123173d, y: 0.20402160625543087d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8285288096791942d, y: 0.94330919012118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1289998901672843d, y: 0.8831964107741007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888245818178547d, y: 0.5849788519970528d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146783112495864d, y: 0.8523823387356496d), new NpgsqlTypes.NpgsqlPoint(x: 0.22454946000594234d, y: 0.16062931293806904d), new NpgsqlTypes.NpgsqlPoint(x: 0.43488082968469777d, y: 0.32663034551614534d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546104306962917d, y: 0.33152622366142237d), new NpgsqlTypes.NpgsqlPoint(x: 0.44274923906635133d, y: 0.5799602595504867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253344018405733d, y: 0.12087555164482056d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5801716971329496d, y: 0.05851677766043217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4699161950341727d, y: 0.8530542521304116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322824217493971d, y: 0.8926558961566256d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.878321125562511d, y: 0.6238611978790242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973903628675989d, y: 0.41870516962162696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7381840604917316d, y: 0.2568333922274356d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43758920570899684d, y: 0.3041354356201791d), new NpgsqlTypes.NpgsqlPoint(x: 0.06011134199864798d, y: 0.5312393317758544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766384344446705d, y: 0.9774239189785761d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807596002141875d, y: 0.455217944299379d), new NpgsqlTypes.NpgsqlPoint(x: 0.2749547749912341d, y: 0.3705093018145508d), new NpgsqlTypes.NpgsqlPoint(x: 0.1202244179805636d, y: 0.8664323697411513d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7653535449282505d, y: 0.35108886986108967d), new NpgsqlTypes.NpgsqlPoint(x: 0.43968891037129443d, y: 0.5628981436522561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618005460436231d, y: 0.31599494183817367d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19648668778375644d, y: 0.4701586919791563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613248415005333d, y: 0.16128575878639562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021696213389326d, y: 0.6286746567837522d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20288229061606644d, y: 0.09920867530057165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307372396935793d, y: 0.7453289702880251d), new NpgsqlTypes.NpgsqlPoint(x: 0.48660561570009153d, y: 0.838960345212939d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5836155740834207d, y: 0.4807475735593255d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696518356265072d, y: 0.5276090238994352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370275708592934d, y: 0.9075311078292776d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4678870584852798d, y: 0.6497023336004861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09061085362612709d, y: 0.3945894910006972d), new NpgsqlTypes.NpgsqlPoint(x: 0.05076802723133578d, y: 0.37721637755152604d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5177311142181433d, y: 0.0017386448883414118d), new NpgsqlTypes.NpgsqlPoint(x: 0.20402493770863572d, y: 0.18115241137919347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2210873149765804d, y: 0.40636464798508887d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8280573460564806d, y: 0.44033753900691075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4979765562583117d, y: 0.2425799634014797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085182538261225d, y: 0.8442633959032321d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805409919763102d, y: 0.05647087845881105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355059905154858d, y: 0.6454410882960312d), new NpgsqlTypes.NpgsqlPoint(x: 0.08854596405157733d, y: 0.8568438743550372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3338328574893229d, y: 0.9567159100872905d), new NpgsqlTypes.NpgsqlPoint(x: 0.06862864547717962d, y: 0.3932685614179392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4420010692744252d, y: 0.9764903381443762d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18119679460063476d, y: 0.7684071645432907d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608611780249315d, y: 0.08514294789632781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7865766042822314d, y: 0.0033699903639615725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3734588020592988d, y: 0.4010204434314465d), new NpgsqlTypes.NpgsqlPoint(x: 0.71058005553871d, y: 0.7547323387654916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140094808570886d, y: 0.054690398801105156d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28013150759902117d, y: 0.6301653786128063d), new NpgsqlTypes.NpgsqlPoint(x: 0.02306188072680415d, y: 0.2277129636365639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487059438281487d, y: 0.3118875828914818d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9340054385058197d, y: 0.06494480210220088d), new NpgsqlTypes.NpgsqlPoint(x: 0.35041762909929197d, y: 0.8778928107867793d), new NpgsqlTypes.NpgsqlPoint(x: 0.095950768234488d, y: 0.5796172653263443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9584289778185062d, y: 0.7205806503214913d), new NpgsqlTypes.NpgsqlPoint(x: 0.279653540832945d, y: 0.7468011345453782d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908614347697217d, y: 0.8395267229799903d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7456533907120548d, y: 0.7075593131060649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353419343363742d, y: 0.7135155472168435d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042405468466913d, y: 0.316337768989399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8010595307423414d, y: 0.47631605693790313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461911990616898d, y: 0.7152738064060522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416484138840784d, y: 0.44360832978528486d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892836871725272d, y: 0.28152942638802525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049101017377967d, y: 0.4596620534699749d), new NpgsqlTypes.NpgsqlPoint(x: 0.18415731878663455d, y: 0.78800064341476d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375409528874758d, y: 0.592448920609478d), new NpgsqlTypes.NpgsqlPoint(x: 0.30331109427893255d, y: 0.8123838046312155d), new NpgsqlTypes.NpgsqlPoint(x: 0.38214259720673893d, y: 0.15367549594516716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7147328496701945d, y: 0.8216105486561814d), new NpgsqlTypes.NpgsqlPoint(x: 0.33055544318440067d, y: 0.6462024304789087d), new NpgsqlTypes.NpgsqlPoint(x: 0.10350858682904496d, y: 0.24484296206302947d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2422500010131814d, y: 0.5347871108421978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866933594193589d, y: 0.9111991360221556d), new NpgsqlTypes.NpgsqlPoint(x: 0.651920252368762d, y: 0.9766338741871345d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15723417760560876d, y: 0.8198152455960099d), new NpgsqlTypes.NpgsqlPoint(x: 0.29526314904673256d, y: 0.5659818456139356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218146043203974d, y: 0.8897662545960652d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27197737870200134d, y: 0.7158779032666067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881607436510028d, y: 0.32989704552701704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470341725609406d, y: 0.015286918840621944d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006351341175337d, y: 0.569776448518139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547096620433424d, y: 0.866073871603513d), new NpgsqlTypes.NpgsqlPoint(x: 0.19944983612645106d, y: 0.5202865377842748d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633549624873847d, y: 0.8467877678971643d), new NpgsqlTypes.NpgsqlPoint(x: 0.07504601506827446d, y: 0.09434940743410669d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826566548937993d, y: 0.039125794042585094d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5843838304547053d, y: 0.9415958562941581d), new NpgsqlTypes.NpgsqlPoint(x: 0.23407900615777055d, y: 0.8365534230205008d), new NpgsqlTypes.NpgsqlPoint(x: 0.11452364670663451d, y: 0.6736109605889744d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505565622703877d, y: 0.10999650102770608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537196717402193d, y: 0.052215292980998584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787166675079558d, y: 0.10126694117579693d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7621835779830696d, y: 0.525022349701305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502944867248786d, y: 0.9300909677517206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3846750933316869d, y: 0.18090952429882523d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8657472523346597d, y: 0.3276934325669937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474421712394037d, y: 0.7877435686596168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191103415536514d, y: 0.6999622076926896d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131439509262831d, y: 0.4988775570694519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457772812265639d, y: 0.9433752718693585d), new NpgsqlTypes.NpgsqlPoint(x: 0.13151975696822593d, y: 0.63595509275345d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45859063871186123d, y: 0.03614572558945872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891284229874158d, y: 0.936801609188821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313212603754807d, y: 0.13168268455182086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506847339932541d, y: 0.2429061436014821d), new NpgsqlTypes.NpgsqlPoint(x: 0.22365026946206346d, y: 0.2970079477478068d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423541543918473d, y: 0.7592355249658896d)))));

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

