

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47212630884676476d, y: 0.40556485495758143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4263781381580378d, y: 0.39687474584948124d), new NpgsqlTypes.NpgsqlPoint(x: 0.08232738270547624d, y: 0.0415715204533883d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033952409629244285d, y: 0.6606230129027204d), new NpgsqlTypes.NpgsqlPoint(x: 0.19027465198553428d, y: 0.637872804080773d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323465855570223d, y: 0.7591527286998185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9201865785061135d, y: 0.33919475955040645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760865343999161d, y: 0.1601717324621197d), new NpgsqlTypes.NpgsqlPoint(x: 0.13501176742037435d, y: 0.9357720202251842d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22088348052428974d, y: 0.7983871664061174d), new NpgsqlTypes.NpgsqlPoint(x: 0.15993175679439975d, y: 0.8482161846146572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615459000946265d, y: 0.900681754864903d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5661372452553346d, y: 0.45392517552170375d), new NpgsqlTypes.NpgsqlPoint(x: 0.007045769918036293d, y: 0.11913570631940795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719864860832616d, y: 0.6184175190278022d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4274177624163351d, y: 0.03395618463994887d), new NpgsqlTypes.NpgsqlPoint(x: 0.0332545220988093d, y: 0.820655795735444d), new NpgsqlTypes.NpgsqlPoint(x: 0.07338285017076929d, y: 0.9879169186487651d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1462063472539299d, y: 0.6051716505509588d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088719642666622d, y: 0.5454268478575824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432182677060591d, y: 0.9854383773189891d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055050971125195414d, y: 0.6345939006494363d), new NpgsqlTypes.NpgsqlPoint(x: 0.31363709717377564d, y: 0.11440730492863349d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692930671151311d, y: 0.7302178940057957d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8961852699689357d, y: 0.20819463479970435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313469409527989d, y: 0.29913355181235557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137822770385238d, y: 0.8187903125217401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.748620434873194d, y: 0.4068167512027714d), new NpgsqlTypes.NpgsqlPoint(x: 0.7577894672882565d, y: 0.7136165306312184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160393364385216d, y: 0.803586262390048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9689693073911056d, y: 0.40038656702196884d), new NpgsqlTypes.NpgsqlPoint(x: 0.420620485466367d, y: 0.09863843474739087d), new NpgsqlTypes.NpgsqlPoint(x: 0.03847032239098569d, y: 0.5698657831664798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4489296418757164d, y: 0.45028761773162107d), new NpgsqlTypes.NpgsqlPoint(x: 0.06432280310995875d, y: 0.107870058001036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9336254668626457d, y: 0.9173810357202276d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.503860135871164d, y: 0.6632536144563942d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842893083251107d, y: 0.4849623691251055d), new NpgsqlTypes.NpgsqlPoint(x: 0.03448334103637818d, y: 0.6179285665294829d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9339437781564844d, y: 0.2827866964245366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770001371231124d, y: 0.011405085251983915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940125887980185d, y: 0.8484854570638117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23279062025446595d, y: 0.4195353059313772d), new NpgsqlTypes.NpgsqlPoint(x: 0.45503057613026965d, y: 0.6981916373142153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275426403997155d, y: 0.5185935730705946d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6761443190392894d, y: 0.44267544758156496d), new NpgsqlTypes.NpgsqlPoint(x: 0.10879614596397091d, y: 0.2864686003900415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081864996849774d, y: 0.05217329336372434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5725848977449789d, y: 0.978420537134406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613926512334267d, y: 0.8739851358818946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775315953249362d, y: 0.35865791791065793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16500725257362558d, y: 0.20258094910228153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3072657011507517d, y: 0.10081162039559344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833571643405979d, y: 0.20482127425243923d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9739415757936236d, y: 0.3131455935834839d), new NpgsqlTypes.NpgsqlPoint(x: 0.29952184743061705d, y: 0.7235121874046813d), new NpgsqlTypes.NpgsqlPoint(x: 0.12051673623579218d, y: 0.2628287229264241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.565786145224314d, y: 0.42517245994989505d), new NpgsqlTypes.NpgsqlPoint(x: 0.16858263756418135d, y: 0.7990273512045972d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241933153887573d, y: 0.8212672867489235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027554764375169905d, y: 0.987951676042867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698924737285267d, y: 0.5220657111017721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990813152415917d, y: 0.18256402503007818d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7301693216195477d, y: 0.6083401535720943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190643008310366d, y: 0.5904144637250615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5610067488305919d, y: 0.40393683994741625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.222543158383271d, y: 0.01317899512279641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164485878177752d, y: 0.41890151465682646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379404581058073d, y: 0.38518253465389485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8905029342184377d, y: 0.41382900845247017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3369549379186515d, y: 0.3010371967106097d), new NpgsqlTypes.NpgsqlPoint(x: 0.69438024952366d, y: 0.8657497272578198d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10612387815503277d, y: 0.2890459484188823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1745675183888209d, y: 0.4524866537250781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117439989424796d, y: 0.10170550336791073d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9534391352815839d, y: 0.560689082892341d), new NpgsqlTypes.NpgsqlPoint(x: 0.0274082979168756d, y: 0.8315444383546876d), new NpgsqlTypes.NpgsqlPoint(x: 0.13379655627147113d, y: 0.05158602354829844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6802618327513217d, y: 0.8539957925029545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8734957882919914d, y: 0.10469692829112542d), new NpgsqlTypes.NpgsqlPoint(x: 0.21803505814694524d, y: 0.6536068761664517d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6300676231716493d, y: 0.7043220517432833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513415733918893d, y: 0.4014670282540391d), new NpgsqlTypes.NpgsqlPoint(x: 0.43827811125714367d, y: 0.5986045002682305d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690244984267571d, y: 0.7927340079450975d), new NpgsqlTypes.NpgsqlPoint(x: 0.18023216176277002d, y: 0.626950715419369d), new NpgsqlTypes.NpgsqlPoint(x: 0.10695942677995174d, y: 0.35394142825461394d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8151696581488985d, y: 0.8218507984326568d), new NpgsqlTypes.NpgsqlPoint(x: 0.13299285698181884d, y: 0.802883536826048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707561469162726d, y: 0.8787047568649861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31265024881956616d, y: 0.6420177099558352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360087004552069d, y: 0.4550786019865928d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088237744393616d, y: 0.31174660329137893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14920021739340972d, y: 0.3227186484706722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2536458825448712d, y: 0.9708452803255865d), new NpgsqlTypes.NpgsqlPoint(x: 0.37484731438544594d, y: 0.036840684358368514d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09126660718249757d, y: 0.749997191817426d), new NpgsqlTypes.NpgsqlPoint(x: 0.04945061762831293d, y: 0.8038128184730938d), new NpgsqlTypes.NpgsqlPoint(x: 0.23290118921138958d, y: 0.05014711536846106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47217662766144664d, y: 0.8847482448287316d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999862808759357d, y: 0.8365937446464055d), new NpgsqlTypes.NpgsqlPoint(x: 0.14730617474401364d, y: 0.04599894649236147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9293777493611105d, y: 0.23063975804916337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750384441003561d, y: 0.16936165327138797d), new NpgsqlTypes.NpgsqlPoint(x: 0.14239287396583156d, y: 0.500561390356433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6841260251158083d, y: 0.6283727387755508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013315634307019d, y: 0.8625366372866278d), new NpgsqlTypes.NpgsqlPoint(x: 0.1545301807813576d, y: 0.7068696680935679d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22838317498276806d, y: 0.19482791167481317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239753637182064d, y: 0.9837569893632775d), new NpgsqlTypes.NpgsqlPoint(x: 0.22198941970420893d, y: 0.29708340662315547d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46580792093066314d, y: 0.275333588117438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768326530497963d, y: 0.4345069803647067d), new NpgsqlTypes.NpgsqlPoint(x: 0.956189654157951d, y: 0.2101765274246742d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2482852236730374d, y: 0.34375609067807844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7498210967746728d, y: 0.23868164928838975d), new NpgsqlTypes.NpgsqlPoint(x: 0.18499352546156778d, y: 0.9285982112736578d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030400619295529174d, y: 0.840711439566121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327316292915839d, y: 0.9927306612975344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6599560269901181d, y: 0.5043547321458028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06375726015037675d, y: 0.61293625460898d), new NpgsqlTypes.NpgsqlPoint(x: 0.26816223679339046d, y: 0.8973821915745603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261840624724412d, y: 0.15714396838984768d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9954794301657347d, y: 0.8833091133160658d), new NpgsqlTypes.NpgsqlPoint(x: 0.06027142318613243d, y: 0.6929005598358827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880788364961796d, y: 0.3980022409159476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10780288189807508d, y: 0.016953117712117938d), new NpgsqlTypes.NpgsqlPoint(x: 0.01631165638587795d, y: 0.9138933318278138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306727503732d, y: 0.24679344784612844d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899015186600951d, y: 0.9506972424536132d), new NpgsqlTypes.NpgsqlPoint(x: 0.23573406582023648d, y: 0.19262727317871853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020509442995967d, y: 0.7340399678548056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3699356865520169d, y: 0.09553314213262754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427812598496748d, y: 0.23436856769196124d), new NpgsqlTypes.NpgsqlPoint(x: 0.05630962011007501d, y: 0.004455884592297177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8916625100244926d, y: 0.7279625536371475d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178830960640005d, y: 0.6286193271385864d), new NpgsqlTypes.NpgsqlPoint(x: 0.649510267275303d, y: 0.3452542367225804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5818465208715897d, y: 0.4193153008168994d), new NpgsqlTypes.NpgsqlPoint(x: 0.19766951799382015d, y: 0.3103150484004389d), new NpgsqlTypes.NpgsqlPoint(x: 0.8406760950355218d, y: 0.3330560269108833d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3367036421651144d, y: 0.28089763978693794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787962858006093d, y: 0.3928165260980716d), new NpgsqlTypes.NpgsqlPoint(x: 0.24533591221711637d, y: 0.3173800560130199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7717993821092056d, y: 0.3307295103105802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300131367261723d, y: 0.8917410014535309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608687456408246d, y: 0.36917727419295576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21321652770823019d, y: 0.4601457044358608d), new NpgsqlTypes.NpgsqlPoint(x: 0.49477403027505396d, y: 0.8288249812987142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019012292120267d, y: 0.5488693267057132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48310869123970346d, y: 0.9277676128550233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285289896904666d, y: 0.7381304950828212d), new NpgsqlTypes.NpgsqlPoint(x: 0.23776965360476576d, y: 0.41085761127120635d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0931629809941551d, y: 0.6934970125341338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337981166744129d, y: 0.9627188229790378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3295501530984607d, y: 0.36371967227250535d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08066439212467569d, y: 0.44240830389656105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9824633772444671d, y: 0.018297463892020582d), new NpgsqlTypes.NpgsqlPoint(x: 0.19526561337970982d, y: 0.8409268919418939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8234650957948036d, y: 0.6864621650406496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225800484178942d, y: 0.5766592908159682d), new NpgsqlTypes.NpgsqlPoint(x: 0.20128800695242355d, y: 0.7165634646946043d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22122405031493575d, y: 0.6367798726652348d), new NpgsqlTypes.NpgsqlPoint(x: 0.772318821341588d, y: 0.9281023805300149d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331244656335787d, y: 0.11242347919092543d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10853484009114389d, y: 0.15268572783538858d), new NpgsqlTypes.NpgsqlPoint(x: 0.703306733347348d, y: 0.24709064562206617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414451529663328d, y: 0.9561711780666142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5450667162573237d, y: 0.08732985412780614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576033793779061d, y: 0.599787498049424d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133633982518037d, y: 0.3186058545400893d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2029757575152149d, y: 0.018670680994929745d), new NpgsqlTypes.NpgsqlPoint(x: 0.2594079571313851d, y: 0.9077745559615421d), new NpgsqlTypes.NpgsqlPoint(x: 0.22375336683084812d, y: 0.06469829536635929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16305711974791348d, y: 0.8432320256353013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064145115181259d, y: 0.5307444690713832d), new NpgsqlTypes.NpgsqlPoint(x: 0.33339296605969015d, y: 0.3614603278821815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3212840591962699d, y: 0.3714155951255992d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134933927049686d, y: 0.29749979430396d), new NpgsqlTypes.NpgsqlPoint(x: 0.28744789698568185d, y: 0.5621661851360689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29808380184297656d, y: 0.9170522958014704d), new NpgsqlTypes.NpgsqlPoint(x: 0.04115140886925972d, y: 0.8187880361056993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033197542356255d, y: 0.879940123878557d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.493848859347365d, y: 0.40570571035344916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521584730218641d, y: 0.18066335045029902d), new NpgsqlTypes.NpgsqlPoint(x: 0.665327556872869d, y: 0.044501169152185494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48281946190921676d, y: 0.9239898772947883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001703043262283d, y: 0.12688868049022162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138200724539808d, y: 0.8421935156533233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7374306381945425d, y: 0.41766722380631216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636000774928814d, y: 0.15427106324532347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082731918938678d, y: 0.5244533949041318d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8434793273919539d, y: 0.8229020819041972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114555782056093d, y: 0.3280941509364518d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875557359600732d, y: 0.04615170823781667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46712289383187533d, y: 0.03620753466996285d), new NpgsqlTypes.NpgsqlPoint(x: 0.09864353153267413d, y: 0.6279204554431962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4719577854837339d, y: 0.4791774283781798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7235674891659368d, y: 0.977856018912719d), new NpgsqlTypes.NpgsqlPoint(x: 0.44078074890991825d, y: 0.21506432152076038d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909448694674399d, y: 0.8280439642087762d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09838698086082664d, y: 0.8421252364673161d), new NpgsqlTypes.NpgsqlPoint(x: 0.1650769623197338d, y: 0.4794949305612941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6574965211918957d, y: 0.5053435504221591d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838714864483901d, y: 0.958105280307494d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455930428355867d, y: 0.2205354739339549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537966955117855d, y: 0.7916829709888855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6727911477067542d, y: 0.330076945670954d), new NpgsqlTypes.NpgsqlPoint(x: 0.08464272156255881d, y: 0.11015686546098957d), new NpgsqlTypes.NpgsqlPoint(x: 0.025660809298257536d, y: 0.6262926237744147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991155583287068d, y: 0.8734101124459633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928620898759105d, y: 0.3085368548636579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373801786086813d, y: 0.17322994583997509d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451400655438537d, y: 0.20160937888997232d), new NpgsqlTypes.NpgsqlPoint(x: 0.169328585755258d, y: 0.12744851990929607d), new NpgsqlTypes.NpgsqlPoint(x: 0.21816124297798944d, y: 0.3008588328807622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5315121588838256d, y: 0.9408037345757151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5263892271444583d, y: 0.15054874280846098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553466698366734d, y: 0.762141924018966d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5205437527979996d, y: 0.7630955556238677d), new NpgsqlTypes.NpgsqlPoint(x: 0.33335580623313643d, y: 0.5789469202595677d), new NpgsqlTypes.NpgsqlPoint(x: 0.22957246533262587d, y: 0.1334048026124387d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1596957797068459d, y: 0.29740130341079296d), new NpgsqlTypes.NpgsqlPoint(x: 0.19623680100693597d, y: 0.8908714523252095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950293550778944d, y: 0.2230539052708833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7085313723185012d, y: 0.7394884806952523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746310952477128d, y: 0.9570086446966362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803634799581305d, y: 0.5391928730907277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1279562094577804d, y: 0.17486630584349105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670010904626968d, y: 0.6730683624190211d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608402781292685d, y: 0.8923593974300902d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7791427808531799d, y: 0.0766061432214169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323142900318503d, y: 0.8162121407536165d), new NpgsqlTypes.NpgsqlPoint(x: 0.06663799255136216d, y: 0.11898471612926587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1328161683915895d, y: 0.9449215516907193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207142119445745d, y: 0.747274784470955d), new NpgsqlTypes.NpgsqlPoint(x: 0.25314072041195945d, y: 0.8437294575014486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10323316578954467d, y: 0.4046705250666366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507078980935036d, y: 0.9295734880451612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048575573373302d, y: 0.3308207339641476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.921379812557074d, y: 0.780024467398112d), new NpgsqlTypes.NpgsqlPoint(x: 0.955663542989522d, y: 0.6593831203176653d), new NpgsqlTypes.NpgsqlPoint(x: 0.25994248603736103d, y: 0.6546907496921915d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012692844654060731d, y: 0.9899252984507712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851767926586236d, y: 0.17265420190421876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5135599498867771d, y: 0.48732873489450645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5304281220971017d, y: 0.19828157476873998d), new NpgsqlTypes.NpgsqlPoint(x: 0.33570607266518526d, y: 0.9809140976334175d), new NpgsqlTypes.NpgsqlPoint(x: 0.45024723240112097d, y: 0.8020398393023642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26536297775108453d, y: 0.5687719595770934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472031251704597d, y: 0.9278737994069685d), new NpgsqlTypes.NpgsqlPoint(x: 0.35777429547862005d, y: 0.45754748674708756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14376123246816663d, y: 0.5604214293838542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651180334688085d, y: 0.338577133606084d), new NpgsqlTypes.NpgsqlPoint(x: 0.4733000221924101d, y: 0.1262749342455569d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012544343039401218d, y: 0.6675478712314703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132713400094417d, y: 0.6424672555316214d), new NpgsqlTypes.NpgsqlPoint(x: 0.46011256033705894d, y: 0.31872083787061745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27123524354631656d, y: 0.342217851531356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286265478140657d, y: 0.9729680135702927d), new NpgsqlTypes.NpgsqlPoint(x: 0.4686220277190726d, y: 0.0687806981691208d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21169339627455985d, y: 0.1730168128092685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6555606166332766d, y: 0.630817048805894d), new NpgsqlTypes.NpgsqlPoint(x: 0.40754916945121755d, y: 0.5043682301333853d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4358192357672429d, y: 0.7062709242090368d), new NpgsqlTypes.NpgsqlPoint(x: 0.702899067868925d, y: 0.5432676449509549d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250909740516889d, y: 0.4746374741639735d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2281441447205621d, y: 0.39930844595882553d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679127594569874d, y: 0.00744167293336373d), new NpgsqlTypes.NpgsqlPoint(x: 0.48591123066449105d, y: 0.7879516322025787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6585449046884162d, y: 0.93836591638724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4157248151503028d, y: 0.5953682610675912d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542643964077359d, y: 0.7572720894764267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043499723607514196d, y: 0.06315124749505974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515053755244599d, y: 0.7591812291537124d), new NpgsqlTypes.NpgsqlPoint(x: 0.0044341753845121845d, y: 0.7629191885850165d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3298724169889149d, y: 0.5709372455114607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266899096034569d, y: 0.8466244105259872d), new NpgsqlTypes.NpgsqlPoint(x: 0.07414984423665205d, y: 0.9960530097091989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3876252128284483d, y: 0.7801397848205623d), new NpgsqlTypes.NpgsqlPoint(x: 0.969535072341605d, y: 0.6272504435049191d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413265715322323d, y: 0.29996950136992895d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4225493864101362d, y: 0.7376967542765094d), new NpgsqlTypes.NpgsqlPoint(x: 0.1710881274248467d, y: 0.6382726887872768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210536960820313d, y: 0.5460654644050242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12395445589582432d, y: 0.15743450890202892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5467695721260277d, y: 0.9013601988411365d), new NpgsqlTypes.NpgsqlPoint(x: 0.15193609094142668d, y: 0.6939348527457796d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5983236076794796d, y: 0.10325370157834768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765715534991978d, y: 0.45735003677628516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08419656924052932d, y: 0.32690478703248915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1461423579409391d, y: 0.7042813270613932d), new NpgsqlTypes.NpgsqlPoint(x: 0.45082175195595653d, y: 0.17511730074127296d), new NpgsqlTypes.NpgsqlPoint(x: 0.1872003529343924d, y: 0.17185751521104964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224325587069658d, y: 0.08503361610661075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221276801680047d, y: 0.06338937897957764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930494546452515d, y: 0.9290244611615611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8235846763762323d, y: 0.7915046719891847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4561346341776936d, y: 0.25205228077813724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596341417872067d, y: 0.3593091139540622d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5649737471960303d, y: 0.29224985944412674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547893557865354d, y: 0.3700831765702002d), new NpgsqlTypes.NpgsqlPoint(x: 0.422624755441409d, y: 0.42167515405954825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06860280659545526d, y: 0.9182629505328676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766574110505443d, y: 0.8526152095357078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3053401421070967d, y: 0.09739045104822264d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5719505601070397d, y: 0.6920760618927128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563263210700433d, y: 0.7776302370052824d), new NpgsqlTypes.NpgsqlPoint(x: 0.004966517712970853d, y: 0.35250485790508723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7983636168592763d, y: 0.323991309213441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7311108314688771d, y: 0.6764636496163305d), new NpgsqlTypes.NpgsqlPoint(x: 0.037300177488443276d, y: 0.7668337605667914d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7038368851313455d, y: 0.38426958559010627d), new NpgsqlTypes.NpgsqlPoint(x: 0.522636916884214d, y: 0.3074614145915284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774951962175138d, y: 0.8148967568073769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1746920621015069d, y: 0.2717200544615088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1573519363771414d, y: 0.9941911375191204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261162621806246d, y: 0.22862978820217694d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09645939944790727d, y: 0.306985644841516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843671919100861d, y: 0.1791117382901274d), new NpgsqlTypes.NpgsqlPoint(x: 0.35909148258070533d, y: 0.4262147202187061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6874318915144411d, y: 0.2951457204381479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283846113111055d, y: 0.9104335823387579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763639213520231d, y: 0.09563649137120978d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7787069656246444d, y: 0.40113999920884347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825226069353457d, y: 0.6247250421305403d), new NpgsqlTypes.NpgsqlPoint(x: 0.15527495258969737d, y: 0.9517804293132619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6946616199041238d, y: 0.5605945624306212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566849524126952d, y: 0.8476271983679758d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014049817645677143d, y: 0.3217629639537469d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22029529292706052d, y: 0.6383691719126562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394629137375907d, y: 0.3262558830885338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9736283314395542d, y: 0.46656822977862145d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4437658685341991d, y: 0.6739533822950721d), new NpgsqlTypes.NpgsqlPoint(x: 0.16195778442315167d, y: 0.34543933955926964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628645676566215d, y: 0.9007181529528213d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011663569183262168d, y: 0.9035409511145496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710059061028894d, y: 0.7065614458098225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635319275954187d, y: 0.3681409574870512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9999740745243086d, y: 0.18859122513986604d), new NpgsqlTypes.NpgsqlPoint(x: 0.14883200643407968d, y: 0.4907218007741292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272295414549167d, y: 0.7798089586325962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7814221086146061d, y: 0.9436170515403515d), new NpgsqlTypes.NpgsqlPoint(x: 0.08297672557549796d, y: 0.7104145263198471d), new NpgsqlTypes.NpgsqlPoint(x: 0.23929235577014007d, y: 0.442497133418301d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39053496481169525d, y: 0.4233242678851693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8376586527556669d, y: 0.5886724568382674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1842784066921469d, y: 0.6448139717857418d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5009694886527891d, y: 0.3116751950818295d), new NpgsqlTypes.NpgsqlPoint(x: 0.47936802142700685d, y: 0.8519945509500442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070501300132481d, y: 0.14619546519373794d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3117477897303559d, y: 0.3429449690773122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326472597781268d, y: 0.3310381104426784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776044636238852d, y: 0.02056867954756536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30333322825598064d, y: 0.0534497957250627d), new NpgsqlTypes.NpgsqlPoint(x: 0.29433639057911287d, y: 0.9222978482786761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116417154206601d, y: 0.6177953459430119d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.286833856090018d, y: 0.6982000405300048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006823074158657d, y: 0.7116197130865303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3703609163271461d, y: 0.782221252904085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3864470943514997d, y: 0.1964207123655035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587659392865226d, y: 0.23526945420407852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218091550976381d, y: 0.5656631529400604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532383607300834d, y: 0.8608245899263561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091011134846135d, y: 0.8043082202774813d), new NpgsqlTypes.NpgsqlPoint(x: 0.017921169970220308d, y: 0.11582068236929965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6741102940759178d, y: 0.045910314533301855d), new NpgsqlTypes.NpgsqlPoint(x: 0.15449701428104523d, y: 0.13527836958451855d), new NpgsqlTypes.NpgsqlPoint(x: 0.27515166466208507d, y: 0.17618972370481356d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088907707504785d, y: 0.22752870568647843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570235258753732d, y: 0.4473543661512954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4021650161773379d, y: 0.5212719544322719d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41982445065119633d, y: 0.9781253817367501d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621502641299815d, y: 0.7296002126349167d), new NpgsqlTypes.NpgsqlPoint(x: 0.4929413460242694d, y: 0.2862462276502513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025116105901693442d, y: 0.2198068637526609d), new NpgsqlTypes.NpgsqlPoint(x: 0.07210095929826732d, y: 0.3416505144932883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284514644860378d, y: 0.7956156084874714d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.278425640078943d, y: 0.5887740619857009d), new NpgsqlTypes.NpgsqlPoint(x: 0.1871134484636907d, y: 0.5359248368625315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044701520824606d, y: 0.8814666314232675d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40320375357224003d, y: 0.19214526849798963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942151799198963d, y: 0.5991456599383047d), new NpgsqlTypes.NpgsqlPoint(x: 0.21978768977466556d, y: 0.023438121687063718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553630668685361d, y: 0.9588329784912029d), new NpgsqlTypes.NpgsqlPoint(x: 0.24483680356342763d, y: 0.4345169870986413d), new NpgsqlTypes.NpgsqlPoint(x: 0.20933696853638262d, y: 0.9483206328661012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31366233026643586d, y: 0.04280702045177709d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664135605313329d, y: 0.07748079292777121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930031619908754d, y: 0.55499477418146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83533985512396d, y: 0.279770645366179d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868224089470658d, y: 0.41309113953879584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684453318564456d, y: 0.6891455451310804d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4012723310292956d, y: 0.0449891037067075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4779548652547827d, y: 0.26117965901154805d), new NpgsqlTypes.NpgsqlPoint(x: 0.25041090948443623d, y: 0.25027476829129147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27766302895785067d, y: 0.16893563794662225d), new NpgsqlTypes.NpgsqlPoint(x: 0.428344286802849d, y: 0.6575768607382905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439223276195102d, y: 0.5673816152337415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8986313567440303d, y: 0.7010748556998158d), new NpgsqlTypes.NpgsqlPoint(x: 0.11186819044087792d, y: 0.9796553006866054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6593203685665489d, y: 0.17839120338067394d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165922109738192d, y: 0.28490952785825974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719352873361984d, y: 0.5509379821815354d), new NpgsqlTypes.NpgsqlPoint(x: 0.1639581845429462d, y: 0.8068767933855256d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2717065861138923d, y: 0.1439939204879721d), new NpgsqlTypes.NpgsqlPoint(x: 0.3623166491655164d, y: 0.1466091693255791d), new NpgsqlTypes.NpgsqlPoint(x: 0.24372049524908002d, y: 0.6823974663027478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515174598491581d, y: 0.8518147827865293d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007469316990573d, y: 0.78223831585079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852708677510397d, y: 0.226434996053834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6499818697197528d, y: 0.049636502768135915d), new NpgsqlTypes.NpgsqlPoint(x: 0.45900206832327084d, y: 0.15285509020372678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172988741441495d, y: 0.09176614492682456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7649915646096175d, y: 0.42451324127881496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4370280024937049d, y: 0.08617911964909852d), new NpgsqlTypes.NpgsqlPoint(x: 0.23070406564230872d, y: 0.9015280727454257d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8405639433130726d, y: 0.09865208851009633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588831609627132d, y: 0.26704074222496677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353179567982583d, y: 0.1431248533737055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41889819148723484d, y: 0.8493109915838506d), new NpgsqlTypes.NpgsqlPoint(x: 0.08670603244720909d, y: 0.1948127182954006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565835440993973d, y: 0.12184244160129076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8417487652030575d, y: 0.13926637706088052d), new NpgsqlTypes.NpgsqlPoint(x: 0.48350005607163504d, y: 0.4991701379280973d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488641497165038d, y: 0.4905436025372907d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8779955378118303d, y: 0.7459526039037664d), new NpgsqlTypes.NpgsqlPoint(x: 0.99998590593953d, y: 0.22074837716634355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8688381271610317d, y: 0.12695682079241633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5553708208903148d, y: 0.6103008051249175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8894820292788455d, y: 0.17114519200621425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181281444928843d, y: 0.2837141596842433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2829732388319429d, y: 0.6626388907985082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713281474383983d, y: 0.04474510015511002d), new NpgsqlTypes.NpgsqlPoint(x: 0.48996196143970117d, y: 0.004213596282620746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05747819382275621d, y: 0.8278819611362259d), new NpgsqlTypes.NpgsqlPoint(x: 0.2557765763395743d, y: 0.9950889332184871d), new NpgsqlTypes.NpgsqlPoint(x: 0.37927669249694895d, y: 0.04851440631602144d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3008058543750671d, y: 0.4179427119981036d), new NpgsqlTypes.NpgsqlPoint(x: 0.27379578294617113d, y: 0.8836551992938235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3862516484879439d, y: 0.8580368261577147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9403816919235684d, y: 0.03532873206182974d), new NpgsqlTypes.NpgsqlPoint(x: 0.48064245940526107d, y: 0.9305690022736426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927500107050814d, y: 0.05164857289392921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17981493965221762d, y: 0.9547590133897234d), new NpgsqlTypes.NpgsqlPoint(x: 0.323365373644557d, y: 0.2729943720365795d), new NpgsqlTypes.NpgsqlPoint(x: 0.412327094885821d, y: 0.2069489101502614d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6261542535446697d, y: 0.4027042353910345d), new NpgsqlTypes.NpgsqlPoint(x: 0.050076491594316486d, y: 0.6353925404987267d), new NpgsqlTypes.NpgsqlPoint(x: 0.24754608636956d, y: 0.5216313935233685d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2428781119284329d, y: 0.4285364265747933d), new NpgsqlTypes.NpgsqlPoint(x: 0.3748678780832909d, y: 0.5466163079584888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9066539126180656d, y: 0.6932761332199971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.607736428909169d, y: 0.02306910679336316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288222505893924d, y: 0.5938593654124872d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397927806441336d, y: 0.43671302651427213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23924671660931474d, y: 0.21038210282040115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221158285627022d, y: 0.7111385146496443d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940461634802686d, y: 0.6036463353956186d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357784351270959d, y: 0.9147869198457217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361890724185408d, y: 0.5667079677404576d), new NpgsqlTypes.NpgsqlPoint(x: 0.586216517714302d, y: 0.29304039309903207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5431562542175621d, y: 0.6998415863045628d), new NpgsqlTypes.NpgsqlPoint(x: 0.2247078555920592d, y: 0.2824682764695474d), new NpgsqlTypes.NpgsqlPoint(x: 0.951330233284046d, y: 0.4642513166935739d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3939504145394722d, y: 0.018867110972666024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3328008920631361d, y: 0.2943409820091183d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820914869318576d, y: 0.8329341504403363d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.408885967811944d, y: 0.6721978727736142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331834717945256d, y: 0.9189576958467855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961540465568204d, y: 0.43704015753631664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19283654956406382d, y: 0.8605806098129539d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673234945405028d, y: 0.0214835404829935d), new NpgsqlTypes.NpgsqlPoint(x: 0.231578596663786d, y: 0.7449399353680167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17469997483198108d, y: 0.5921463300430526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042486411537547d, y: 0.1379638866247891d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980037640687883d, y: 0.8022346800936193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18079107012186435d, y: 0.8719455207277752d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182581279302968d, y: 0.14320825275557914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4758891376734038d, y: 0.07629763774292553d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011508973538695177d, y: 0.6775001266478949d), new NpgsqlTypes.NpgsqlPoint(x: 0.32740914811641064d, y: 0.1307929717403935d), new NpgsqlTypes.NpgsqlPoint(x: 0.39076087244718927d, y: 0.38657941378760163d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03668914697378334d, y: 0.6407972106215377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162528684851708d, y: 0.6391599617473669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647602772612969d, y: 0.22629296849704827d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8230889327231036d, y: 0.4387678653194559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799934061639911d, y: 0.9151718281585385d), new NpgsqlTypes.NpgsqlPoint(x: 0.13733474276226432d, y: 0.9284286672411457d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040771526043081985d, y: 0.8375682527950182d), new NpgsqlTypes.NpgsqlPoint(x: 0.45508722766862486d, y: 0.8193623062634987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400714724481776d, y: 0.18469882439809793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0702146036245519d, y: 0.4298077557787269d), new NpgsqlTypes.NpgsqlPoint(x: 0.26799882008284504d, y: 0.3314841235098388d), new NpgsqlTypes.NpgsqlPoint(x: 0.1388061934770447d, y: 0.8301534447233029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3022021442383306d, y: 0.7062619364743808d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126153902692419d, y: 0.7425505418832229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793484439497937d, y: 0.8731224855551835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10695881659788264d, y: 0.10416583165605198d), new NpgsqlTypes.NpgsqlPoint(x: 0.2810703515970373d, y: 0.7685227781057883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428178003803876d, y: 0.2086875513791755d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03730586595885865d, y: 0.5298255566776686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057275678653512d, y: 0.9470412339631094d), new NpgsqlTypes.NpgsqlPoint(x: 0.2810757077332766d, y: 0.4100474697543689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06604456730889263d, y: 0.7653722095714566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7650077018377485d, y: 0.8875381151155365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366824320043738d, y: 0.4684343622817455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5645159559586737d, y: 0.7040270862167958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560996044868424d, y: 0.5169076952671827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573662001859199d, y: 0.18236427940641475d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2533992323439539d, y: 0.8228501626638087d), new NpgsqlTypes.NpgsqlPoint(x: 0.06174863561645583d, y: 0.10846434914003289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105073397976013d, y: 0.9750499657653079d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20272683984541962d, y: 0.30470174122587856d), new NpgsqlTypes.NpgsqlPoint(x: 0.953827911332371d, y: 0.49437335254092685d), new NpgsqlTypes.NpgsqlPoint(x: 0.31274501872637217d, y: 0.27768079421130554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8892901078430812d, y: 0.013421526439336029d), new NpgsqlTypes.NpgsqlPoint(x: 0.04390111222347137d, y: 0.6052501109576626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978732944927064d, y: 0.9575059020920116d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6647964385419326d, y: 0.6878242007018522d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437473259685655d, y: 0.9432536106195999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687079515992513d, y: 0.8258002164305229d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6160079320602007d, y: 0.823672924947857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130369770486706d, y: 0.050637011561982304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5119079059920488d, y: 0.8506679112236147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9959343660706552d, y: 0.5336750675691736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6200556669359029d, y: 0.9841492221494443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7480710716902929d, y: 0.9390961629596306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07556888085975311d, y: 0.08647256298477246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7762279256599094d, y: 0.6888104098786012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1847224272099881d, y: 0.568243674208302d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5983513165035649d, y: 0.40226924482719173d), new NpgsqlTypes.NpgsqlPoint(x: 0.48559617167709d, y: 0.3042260258849041d), new NpgsqlTypes.NpgsqlPoint(x: 0.29949801430283673d, y: 0.03755108453345657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688923376630939d, y: 0.7425472601638998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833312870283467d, y: 0.21319451432204528d), new NpgsqlTypes.NpgsqlPoint(x: 0.08608233928646947d, y: 0.1005883268284209d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48821009910230906d, y: 0.2798861497284826d), new NpgsqlTypes.NpgsqlPoint(x: 0.04270755298579687d, y: 0.39020289271751607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970704503416724d, y: 0.404215638460226d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8384356445151823d, y: 0.8489737260587435d), new NpgsqlTypes.NpgsqlPoint(x: 0.20738517288360292d, y: 0.502448591508198d), new NpgsqlTypes.NpgsqlPoint(x: 0.3778590898195131d, y: 0.6140480432983112d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9449666886756765d, y: 0.19101029829343164d), new NpgsqlTypes.NpgsqlPoint(x: 0.47880738013863244d, y: 0.09839630076675243d), new NpgsqlTypes.NpgsqlPoint(x: 0.36027743484668495d, y: 0.8051667470446725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8211461125236585d, y: 0.26100885966787724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026335744944058d, y: 0.02792318104736602d), new NpgsqlTypes.NpgsqlPoint(x: 0.07401592812229574d, y: 0.6026784293746297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28078704184403136d, y: 0.09214832388047611d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748618248708391d, y: 0.17966886495084577d), new NpgsqlTypes.NpgsqlPoint(x: 0.37713448252890014d, y: 0.008800254656750273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08680912418960096d, y: 0.9010957751895106d), new NpgsqlTypes.NpgsqlPoint(x: 0.16763542105975704d, y: 0.3750745566472383d), new NpgsqlTypes.NpgsqlPoint(x: 0.18937936288135415d, y: 0.9305835624648712d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9222900464492145d, y: 0.17816603485897775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614973510106995d, y: 0.7336704007652602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4828153151457232d, y: 0.5283117858179629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5126016255247883d, y: 0.454589706318107d), new NpgsqlTypes.NpgsqlPoint(x: 0.19829030076913146d, y: 0.27333788610449095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881139238811717d, y: 0.14775903993777328d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3373407523190888d, y: 0.5578041827350758d), new NpgsqlTypes.NpgsqlPoint(x: 0.13766582333837596d, y: 0.7594213856742926d), new NpgsqlTypes.NpgsqlPoint(x: 0.007579065166887777d, y: 0.557217080110442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477497468541314d, y: 0.16309910137544736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9869373461542184d, y: 0.28081198906771065d), new NpgsqlTypes.NpgsqlPoint(x: 0.0574251029027113d, y: 0.43173719295824264d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44373760548589114d, y: 0.419882761399721d), new NpgsqlTypes.NpgsqlPoint(x: 0.04822852324825444d, y: 0.7329948047495956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699178569638834d, y: 0.09139475289203491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.637188719606827d, y: 0.6962578791422951d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961817248031956d, y: 0.21946048231087867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539847638886774d, y: 0.5903356093578865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03226329439512088d, y: 0.8313375672331916d), new NpgsqlTypes.NpgsqlPoint(x: 0.32802910867757795d, y: 0.055083834992090575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417682480674372d, y: 0.7515108798298422d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534305153291163d, y: 0.2004866125786069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6316528083863984d, y: 0.8785716251191652d), new NpgsqlTypes.NpgsqlPoint(x: 0.44198533271050955d, y: 0.09947019769509713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2643722768830241d, y: 0.28396475696940593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459080322177392d, y: 0.09439223799464302d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523602020939543d, y: 0.14315797349788084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5221191409781369d, y: 0.3103720840694135d), new NpgsqlTypes.NpgsqlPoint(x: 0.16663705584752442d, y: 0.42868464964680353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203481886676713d, y: 0.3481454293405719d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7768238907532949d, y: 0.6637277727113542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907860806508952d, y: 0.1855317800572528d), new NpgsqlTypes.NpgsqlPoint(x: 0.07482898882498257d, y: 0.8688322668444042d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787705012614123d, y: 0.9733352145720157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586379503808192d, y: 0.6671591687136064d), new NpgsqlTypes.NpgsqlPoint(x: 0.48582737076862503d, y: 0.9882925655509126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9711006635098347d, y: 0.4841636518724941d), new NpgsqlTypes.NpgsqlPoint(x: 0.503181534356789d, y: 0.37828596184219165d), new NpgsqlTypes.NpgsqlPoint(x: 0.399100629200016d, y: 0.9857042336107616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3048087903322667d, y: 0.34329784696955523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214390396810795d, y: 0.0005933479470516811d), new NpgsqlTypes.NpgsqlPoint(x: 0.060965580594597446d, y: 0.4549732401990543d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3480616929203918d, y: 0.8190735974449594d), new NpgsqlTypes.NpgsqlPoint(x: 0.32122578525590817d, y: 0.24172171368199513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229351527170608d, y: 0.6597315435094134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2813773358814904d, y: 0.46807728286005035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047584878454094d, y: 0.25173688536037264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8908306159778773d, y: 0.45402627091159664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30814454247078815d, y: 0.5006765475228165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664038780541511d, y: 0.07599767900276944d), new NpgsqlTypes.NpgsqlPoint(x: 0.19867904812883141d, y: 0.033570492392154816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858902998265479d, y: 0.5643185296929311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681175944306243d, y: 0.17442389654215107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240544428213765d, y: 0.6766922956498489d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38100243703865644d, y: 0.4288722244988288d), new NpgsqlTypes.NpgsqlPoint(x: 0.521585428389628d, y: 0.21674477892503807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560960087292374d, y: 0.6174282152565393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5017426912213802d, y: 0.8439102271922485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523892552072948d, y: 0.3274353771152494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6076732960870267d, y: 0.6034026836575803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10351711833411648d, y: 0.9765494741018234d), new NpgsqlTypes.NpgsqlPoint(x: 0.644232100308029d, y: 0.07509988856069749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817169607564999d, y: 0.3419253396123376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4723414917265534d, y: 0.6564743089920089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411608474725627d, y: 0.9577551874412658d), new NpgsqlTypes.NpgsqlPoint(x: 0.39145217035062085d, y: 0.028084813739688297d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010506871788309557d, y: 0.33929867115091394d), new NpgsqlTypes.NpgsqlPoint(x: 0.24684168871022727d, y: 0.9755334680308491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6496376850669218d, y: 0.11829069624721422d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01880358716273345d, y: 0.5388962672816552d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348433647794825d, y: 0.7414461271533865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2040652382265704d, y: 0.5516464177774558d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7566084652112275d, y: 0.7406063686976909d), new NpgsqlTypes.NpgsqlPoint(x: 0.5579694829976695d, y: 0.3938181383388555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8342971880989358d, y: 0.7382592877326883d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20626051681429258d, y: 0.6056450972871599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178840608554454d, y: 0.7609103757694825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841221289174024d, y: 0.203455437546057d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33637058628976557d, y: 0.10923226854904844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920644872028754d, y: 0.9093485231720316d), new NpgsqlTypes.NpgsqlPoint(x: 0.825814778940457d, y: 0.7669029697602553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04455431337823379d, y: 0.21573297305205774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706780763958718d, y: 0.957743339408148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479863674653378d, y: 0.18816527318238263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06190290891887518d, y: 0.7746640175436443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8447543411855727d, y: 0.20875129577189888d), new NpgsqlTypes.NpgsqlPoint(x: 0.14884507540255076d, y: 0.8914152335777804d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8417443143911363d, y: 0.29303951766995406d), new NpgsqlTypes.NpgsqlPoint(x: 0.34884427426201337d, y: 0.12251881672158083d), new NpgsqlTypes.NpgsqlPoint(x: 0.45185356840595536d, y: 0.8065803628771414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6337698355509015d, y: 0.4942997969260201d), new NpgsqlTypes.NpgsqlPoint(x: 0.19642459864126405d, y: 0.49349900066342456d), new NpgsqlTypes.NpgsqlPoint(x: 0.10226149729121381d, y: 0.5723218302590769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04547181808127976d, y: 0.14671478991231923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552501112060249d, y: 0.5819409521539737d), new NpgsqlTypes.NpgsqlPoint(x: 0.33787843599070744d, y: 0.8982813307883133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8188881141649599d, y: 0.8529183334269843d), new NpgsqlTypes.NpgsqlPoint(x: 0.24878474208066192d, y: 0.9125413422402167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256042398445028d, y: 0.17478359394224552d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6268414578982126d, y: 0.5364181994899666d), new NpgsqlTypes.NpgsqlPoint(x: 0.842638847156756d, y: 0.94420776840393d), new NpgsqlTypes.NpgsqlPoint(x: 0.42427335218741635d, y: 0.17339659316646594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7561438035501319d, y: 0.3730347205210429d), new NpgsqlTypes.NpgsqlPoint(x: 0.48518899963593987d, y: 0.47676588255212693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520485074904642d, y: 0.24054268407820167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508388281845295d, y: 0.03222614936755508d), new NpgsqlTypes.NpgsqlPoint(x: 0.2007782724294066d, y: 0.7125028263714964d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543829373673154d, y: 0.052912492005462664d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23301204773167916d, y: 0.807872016784657d), new NpgsqlTypes.NpgsqlPoint(x: 0.025042349683571552d, y: 0.27363826924780743d), new NpgsqlTypes.NpgsqlPoint(x: 0.16211748901536194d, y: 0.9438477365454192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5538775794081673d, y: 0.3544819185896698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378124173177401d, y: 0.9030240526742568d), new NpgsqlTypes.NpgsqlPoint(x: 0.08609050586732803d, y: 0.1743447014731725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8155504733264503d, y: 0.11230188581047607d), new NpgsqlTypes.NpgsqlPoint(x: 0.48679095278812246d, y: 0.16618219094991882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218770951252884d, y: 0.7747791510893351d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5497005487456956d, y: 0.8060350648436222d), new NpgsqlTypes.NpgsqlPoint(x: 0.2736078883857356d, y: 0.2543144217597927d), new NpgsqlTypes.NpgsqlPoint(x: 0.724240896138454d, y: 0.10948084074345177d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15426388622702036d, y: 0.6764859773641712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6754866983734551d, y: 0.5435807437637089d), new NpgsqlTypes.NpgsqlPoint(x: 0.6264053389803838d, y: 0.6476142231817079d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9071409430415678d, y: 0.3703675573333971d), new NpgsqlTypes.NpgsqlPoint(x: 0.4300524291469602d, y: 0.5809719983795336d), new NpgsqlTypes.NpgsqlPoint(x: 0.40443551682762946d, y: 0.5196333605562179d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7361788175767287d, y: 0.614094300567638d), new NpgsqlTypes.NpgsqlPoint(x: 0.951222301959676d, y: 0.9047221699156139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865992400606613d, y: 0.380858667660273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020742423410225586d, y: 0.0037127126769493923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988413286673774d, y: 0.42238675961782657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308446914013788d, y: 0.9238212005130068d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10598713691756967d, y: 0.24768638178772207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524622402968299d, y: 0.47108414301905044d), new NpgsqlTypes.NpgsqlPoint(x: 0.0064611740896769465d, y: 0.5469570772450612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7869963169004673d, y: 0.8521833714604703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739084958174045d, y: 0.32810319014956024d), new NpgsqlTypes.NpgsqlPoint(x: 0.32416904147774317d, y: 0.752629889258859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35383650874028216d, y: 0.43326881468070577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108471945317629d, y: 0.6649324717592457d), new NpgsqlTypes.NpgsqlPoint(x: 0.1425738065431098d, y: 0.7603664388618996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7901234729534496d, y: 0.5626335485421446d), new NpgsqlTypes.NpgsqlPoint(x: 0.387881346478664d, y: 0.8228581589797819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122133579463363d, y: 0.7476242979929848d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8067872042479631d, y: 0.48283186062938843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379414724762302d, y: 0.7342673131978242d), new NpgsqlTypes.NpgsqlPoint(x: 0.2993785321435867d, y: 0.00025734839043300983d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5465725639266317d, y: 0.7672170873483299d), new NpgsqlTypes.NpgsqlPoint(x: 0.49214788688287947d, y: 0.8959724775151932d), new NpgsqlTypes.NpgsqlPoint(x: 0.11137446061677292d, y: 0.015899183803989025d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7132119904024138d, y: 0.34696070076796715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290026747549771d, y: 0.1441061696667746d), new NpgsqlTypes.NpgsqlPoint(x: 0.11655957853454701d, y: 0.4057062566034978d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7114571544886366d, y: 0.8239308528311767d), new NpgsqlTypes.NpgsqlPoint(x: 0.07073591445861194d, y: 0.11207734305860695d), new NpgsqlTypes.NpgsqlPoint(x: 0.32215256232255385d, y: 0.5537611100728026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4032294217766975d, y: 0.25472622204593054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311349566344316d, y: 0.11458113841387763d), new NpgsqlTypes.NpgsqlPoint(x: 0.25365194656448975d, y: 0.9370838670265973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9847605874382683d, y: 0.9925640935697932d), new NpgsqlTypes.NpgsqlPoint(x: 0.44470199119201326d, y: 0.19792997763502318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095937138167493d, y: 0.9602194555356134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16205934995897409d, y: 0.8262119206190732d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632427776557508d, y: 0.9089928178059956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623657115125364d, y: 0.08766591413780389d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14790669140176083d, y: 0.12469543226324398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5698214509289756d, y: 0.4205555884271267d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011491517620153546d, y: 0.93081884301974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8068565366152187d, y: 0.45333418446003115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897422603024455d, y: 0.9804514814520209d), new NpgsqlTypes.NpgsqlPoint(x: 0.1421949915294497d, y: 0.6368144575672213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8439244471108258d, y: 0.50969929297671d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993371872195919d, y: 0.1640141850839273d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250315325825686d, y: 0.9342604182946129d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5548231177382664d, y: 0.5456993544991664d), new NpgsqlTypes.NpgsqlPoint(x: 0.45988594074724454d, y: 0.5720323472197874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2511343883899173d, y: 0.6258510809579666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.52243474004453d, y: 0.40993300571660485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946996583963516d, y: 0.29700060283560925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4395264111874293d, y: 0.7671326137949795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1439491074054916d, y: 0.16099120690692348d), new NpgsqlTypes.NpgsqlPoint(x: 0.4199759745231615d, y: 0.8805501486604757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112479563826451d, y: 0.33353952785626917d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8736630236940022d, y: 0.0031158584730446304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929483760137502d, y: 0.4168863493017223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8060097361992491d, y: 0.6120390364486732d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11522133952740332d, y: 0.48467782927649017d), new NpgsqlTypes.NpgsqlPoint(x: 0.48615069586939974d, y: 0.22647581094886948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769993684810056d, y: 0.033805750041947746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8855222634950273d, y: 0.11738528995912201d), new NpgsqlTypes.NpgsqlPoint(x: 0.40457098649914713d, y: 0.9074594386686876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022880642553828d, y: 0.11812189858867483d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7784581178270299d, y: 0.8661821311118318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6951354283204504d, y: 0.9816505506477268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430512496475271d, y: 0.4169050362721063d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8497738476432672d, y: 0.2333005962400001d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310702751080116d, y: 0.7459158743679359d), new NpgsqlTypes.NpgsqlPoint(x: 0.824304023595824d, y: 0.5018239991664503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21499245103905462d, y: 0.7044244007191207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225980218078568d, y: 0.8524702444479295d), new NpgsqlTypes.NpgsqlPoint(x: 0.43842806095014564d, y: 0.7575937718721932d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3592985788584603d, y: 0.44667660570307355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772183895993954d, y: 0.05736864499232819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994401309652984d, y: 0.6558105788122143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7165295450465392d, y: 0.6134009131779884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759981333928124d, y: 0.5416265822472138d), new NpgsqlTypes.NpgsqlPoint(x: 0.34895340509774d, y: 0.75899980823639d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0761206522210005d, y: 0.5426976998422957d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694099686497071d, y: 0.8013346441673962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709309358262195d, y: 0.715269686239795d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32844500899607687d, y: 0.15544123098234008d), new NpgsqlTypes.NpgsqlPoint(x: 0.630120602259197d, y: 0.42519521315949615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240040677546479d, y: 0.02015785752104504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08793983664453808d, y: 0.6904167439623113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583847416225259d, y: 0.0963533410595695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194391897109419d, y: 0.5293426875164308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10860085356109017d, y: 0.14858416608597946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631968946785429d, y: 0.9140462842392775d), new NpgsqlTypes.NpgsqlPoint(x: 0.23524594797009357d, y: 0.3872965509016165d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9379607331542568d, y: 0.5402336409815209d), new NpgsqlTypes.NpgsqlPoint(x: 0.11837116042109963d, y: 0.25948156421691804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063231141304045d, y: 0.7130685918049946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8246599135986775d, y: 0.7192421842151598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399278291722801d, y: 0.6321670257933554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19879596764535956d, y: 0.510618403599294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39823633912778045d, y: 0.38760068455196783d), new NpgsqlTypes.NpgsqlPoint(x: 0.8900989156071962d, y: 0.6531131395733729d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915879020580128d, y: 0.183834679167874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7845093469794755d, y: 0.2605957782079831d), new NpgsqlTypes.NpgsqlPoint(x: 0.18938183599602332d, y: 0.7889467072104122d), new NpgsqlTypes.NpgsqlPoint(x: 0.36935444974189136d, y: 0.3864065884895904d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6587775107878797d, y: 0.9507028405161233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444123821881129d, y: 0.010948035157104852d), new NpgsqlTypes.NpgsqlPoint(x: 0.17850395935782115d, y: 0.6825525573438329d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7081239206746135d, y: 0.4830426916132178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518902212790558d, y: 0.23303935840534484d), new NpgsqlTypes.NpgsqlPoint(x: 0.645432712852321d, y: 0.8544920056784099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29860468289721187d, y: 0.16424173780748186d), new NpgsqlTypes.NpgsqlPoint(x: 0.46606930089421283d, y: 0.24496194295531326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255490099600025d, y: 0.6542111914287699d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8913554736078382d, y: 0.7946664059954008d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264875907258059d, y: 0.4898337537464118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6527177295075424d, y: 0.006376154483490271d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7797462009534115d, y: 0.00960904064793855d), new NpgsqlTypes.NpgsqlPoint(x: 0.24555871489235714d, y: 0.7519108202984237d), new NpgsqlTypes.NpgsqlPoint(x: 0.572627211034128d, y: 0.9069313098730553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8538441392459797d, y: 0.06538108579510427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940056145250892d, y: 0.811576115339489d), new NpgsqlTypes.NpgsqlPoint(x: 0.839795969929228d, y: 0.11198760911424355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6721548631551646d, y: 0.315388246565963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063539223349713d, y: 0.4984192868290598d), new NpgsqlTypes.NpgsqlPoint(x: 0.18822873177072652d, y: 0.7565527000021005d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17438024546123243d, y: 0.23074431129448303d), new NpgsqlTypes.NpgsqlPoint(x: 0.973087594533522d, y: 0.8612733269447416d), new NpgsqlTypes.NpgsqlPoint(x: 0.044356402159905106d, y: 0.9478651030138074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7539871744984072d, y: 0.48315314622420935d), new NpgsqlTypes.NpgsqlPoint(x: 0.587704516747035d, y: 0.3145628000651446d), new NpgsqlTypes.NpgsqlPoint(x: 0.15792836877820415d, y: 0.21918263397671567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8461493272226882d, y: 0.6871643871323732d), new NpgsqlTypes.NpgsqlPoint(x: 0.020090740868017987d, y: 0.7355358612545628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9862881576480629d, y: 0.8625160670645526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9963574944076897d, y: 0.6841210358448704d), new NpgsqlTypes.NpgsqlPoint(x: 0.27254910467012505d, y: 0.01896777293952867d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159726186174224d, y: 0.5140663372956911d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7221678858123963d, y: 0.8967062100858416d), new NpgsqlTypes.NpgsqlPoint(x: 0.3117280161139694d, y: 0.0706298902214556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259607273156417d, y: 0.903602858068958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36683622370576296d, y: 0.1683821585147569d), new NpgsqlTypes.NpgsqlPoint(x: 0.12400234887397787d, y: 0.5453948084100506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417794616017984d, y: 0.6681623893848142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3144146993846605d, y: 0.673069791785078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819289856181542d, y: 0.16507681400996022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922080772968338d, y: 0.20076818965943577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48427590747949334d, y: 0.7845331786765565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557941772276104d, y: 0.8070659173552406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112386374616681d, y: 0.9724068707171832d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8151696581488985d, y: 0.8218507984326568d), new NpgsqlTypes.NpgsqlPoint(x: 0.13299285698181884d, y: 0.802883536826048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707561469162726d, y: 0.8787047568649861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31265024881956616d, y: 0.6420177099558352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360087004552069d, y: 0.4550786019865928d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088237744393616d, y: 0.31174660329137893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14920021739340972d, y: 0.3227186484706722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2536458825448712d, y: 0.9708452803255865d), new NpgsqlTypes.NpgsqlPoint(x: 0.37484731438544594d, y: 0.036840684358368514d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3367036421651144d, y: 0.28089763978693794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787962858006093d, y: 0.3928165260980716d), new NpgsqlTypes.NpgsqlPoint(x: 0.24533591221711637d, y: 0.3173800560130199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7717993821092056d, y: 0.3307295103105802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300131367261723d, y: 0.8917410014535309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608687456408246d, y: 0.36917727419295576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21321652770823019d, y: 0.4601457044358608d), new NpgsqlTypes.NpgsqlPoint(x: 0.49477403027505396d, y: 0.8288249812987142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019012292120267d, y: 0.5488693267057132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48310869123970346d, y: 0.9277676128550233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285289896904666d, y: 0.7381304950828212d), new NpgsqlTypes.NpgsqlPoint(x: 0.23776965360476576d, y: 0.41085761127120635d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.493848859347365d, y: 0.40570571035344916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521584730218641d, y: 0.18066335045029902d), new NpgsqlTypes.NpgsqlPoint(x: 0.665327556872869d, y: 0.044501169152185494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48281946190921676d, y: 0.9239898772947883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001703043262283d, y: 0.12688868049022162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138200724539808d, y: 0.8421935156533233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7374306381945425d, y: 0.41766722380631216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636000774928814d, y: 0.15427106324532347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082731918938678d, y: 0.5244533949041318d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09838698086082664d, y: 0.8421252364673161d), new NpgsqlTypes.NpgsqlPoint(x: 0.1650769623197338d, y: 0.4794949305612941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6574965211918957d, y: 0.5053435504221591d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838714864483901d, y: 0.958105280307494d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455930428355867d, y: 0.2205354739339549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537966955117855d, y: 0.7916829709888855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6727911477067542d, y: 0.330076945670954d), new NpgsqlTypes.NpgsqlPoint(x: 0.08464272156255881d, y: 0.11015686546098957d), new NpgsqlTypes.NpgsqlPoint(x: 0.025660809298257536d, y: 0.6262926237744147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991155583287068d, y: 0.8734101124459633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928620898759105d, y: 0.3085368548636579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373801786086813d, y: 0.17322994583997509d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012692844654060731d, y: 0.9899252984507712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851767926586236d, y: 0.17265420190421876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5135599498867771d, y: 0.48732873489450645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5304281220971017d, y: 0.19828157476873998d), new NpgsqlTypes.NpgsqlPoint(x: 0.33570607266518526d, y: 0.9809140976334175d), new NpgsqlTypes.NpgsqlPoint(x: 0.45024723240112097d, y: 0.8020398393023642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26536297775108453d, y: 0.5687719595770934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472031251704597d, y: 0.9278737994069685d), new NpgsqlTypes.NpgsqlPoint(x: 0.35777429547862005d, y: 0.45754748674708756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14376123246816663d, y: 0.5604214293838542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651180334688085d, y: 0.338577133606084d), new NpgsqlTypes.NpgsqlPoint(x: 0.4733000221924101d, y: 0.1262749342455569d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5983236076794796d, y: 0.10325370157834768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765715534991978d, y: 0.45735003677628516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08419656924052932d, y: 0.32690478703248915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1461423579409391d, y: 0.7042813270613932d), new NpgsqlTypes.NpgsqlPoint(x: 0.45082175195595653d, y: 0.17511730074127296d), new NpgsqlTypes.NpgsqlPoint(x: 0.1872003529343924d, y: 0.17185751521104964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224325587069658d, y: 0.08503361610661075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221276801680047d, y: 0.06338937897957764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930494546452515d, y: 0.9290244611615611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8235846763762323d, y: 0.7915046719891847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4561346341776936d, y: 0.25205228077813724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596341417872067d, y: 0.3593091139540622d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 131, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 53, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

