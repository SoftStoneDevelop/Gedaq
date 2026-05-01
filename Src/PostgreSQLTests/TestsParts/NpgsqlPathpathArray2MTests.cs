

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48977015872827456d, y: 0.7786329523382469d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405359164943166d, y: 0.5762812357118523d), new NpgsqlTypes.NpgsqlPoint(x: 0.04142603678428991d, y: 0.3354414978615071d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1224005987386575d, y: 0.32689033004523105d), new NpgsqlTypes.NpgsqlPoint(x: 0.16536932719494424d, y: 0.8588396886147013d), new NpgsqlTypes.NpgsqlPoint(x: 0.726717193736303d, y: 0.5635671001759472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762807085262378d, y: 0.14833667756431346d), new NpgsqlTypes.NpgsqlPoint(x: 0.0726693468624946d, y: 0.08201658012597102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4141576401613466d, y: 0.8518910968608963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2511858705106834d, y: 0.9406104362453009d), new NpgsqlTypes.NpgsqlPoint(x: 0.1749304275348148d, y: 0.5195107097763572d), new NpgsqlTypes.NpgsqlPoint(x: 0.2900947530347444d, y: 0.7023718104661856d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5453617276641656d, y: 0.9025022948228901d), new NpgsqlTypes.NpgsqlPoint(x: 0.11816711796747115d, y: 0.037459803938234115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288971458078654d, y: 0.8926089159919685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37420998494836455d, y: 0.25684020111376704d), new NpgsqlTypes.NpgsqlPoint(x: 0.2469289412722132d, y: 0.36909087766909665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213512123410906d, y: 0.8014019143315884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12197322401176725d, y: 0.9088615314544594d), new NpgsqlTypes.NpgsqlPoint(x: 0.17935867178082832d, y: 0.08636547275324602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754043630830744d, y: 0.4832293892821009d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6397592412230936d, y: 0.11909231215395033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3575949305061794d, y: 0.24223549966262525d), new NpgsqlTypes.NpgsqlPoint(x: 0.3624868731044504d, y: 0.48414280655645237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769497342049507d, y: 0.6339153956326324d), new NpgsqlTypes.NpgsqlPoint(x: 0.12793835015520716d, y: 0.6791069855950242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002216690163953d, y: 0.5700177022307531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047236895426512215d, y: 0.3841329878558817d), new NpgsqlTypes.NpgsqlPoint(x: 0.07489567146952336d, y: 0.12901970306071053d), new NpgsqlTypes.NpgsqlPoint(x: 0.36892526581558305d, y: 0.6924016336652921d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983076459359791d, y: 0.7876411471799722d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826454821076515d, y: 0.09080406992688272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688006905931042d, y: 0.910597732781915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21825633289145097d, y: 0.3392827146220654d), new NpgsqlTypes.NpgsqlPoint(x: 0.4993806424756603d, y: 0.5853370628966589d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624157749031654d, y: 0.45100706259399925d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5299104060580575d, y: 0.3664525647140985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662760693917889d, y: 0.23760020751909894d), new NpgsqlTypes.NpgsqlPoint(x: 0.48466241105061525d, y: 0.326417704381636d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7468955566149051d, y: 0.5884252867373735d), new NpgsqlTypes.NpgsqlPoint(x: 0.4965011922878485d, y: 0.54577366859053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370751284008425d, y: 0.45894658655029097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36147344076636256d, y: 0.34658381693497975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2510049038307055d, y: 0.966890019874349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055533638835406d, y: 0.4117580020934777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36588170956881716d, y: 0.8033603142411692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8498316761872211d, y: 0.14966625553911583d), new NpgsqlTypes.NpgsqlPoint(x: 0.09862912898230558d, y: 0.6759588502541252d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9408489622924975d, y: 0.03719275859487581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826036279484871d, y: 0.747576902328464d), new NpgsqlTypes.NpgsqlPoint(x: 0.07217848884521572d, y: 0.6867541051629311d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7047102314979672d, y: 0.5390585437333384d), new NpgsqlTypes.NpgsqlPoint(x: 0.19601494994292223d, y: 0.2943720413563903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627087017342789d, y: 0.9389388031762401d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0906881894346081d, y: 0.4747995012255377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975955247411641d, y: 0.8280336060274481d), new NpgsqlTypes.NpgsqlPoint(x: 0.02751038303995257d, y: 0.6278924776914938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09618654487681866d, y: 0.07593322797146984d), new NpgsqlTypes.NpgsqlPoint(x: 0.4469585541283554d, y: 0.16017647513885214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4393880464208454d, y: 0.2396342449383151d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17245420044619297d, y: 0.9058109523054473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6051689200210318d, y: 0.15272344420262574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721395159657351d, y: 0.6003912992635121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9509000224948531d, y: 0.4175887037176611d), new NpgsqlTypes.NpgsqlPoint(x: 0.049456491323490614d, y: 0.250709995804106d), new NpgsqlTypes.NpgsqlPoint(x: 0.11164981554256048d, y: 0.28072924669334043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754455682481986d, y: 0.17397344594884967d), new NpgsqlTypes.NpgsqlPoint(x: 0.25000748669099837d, y: 0.7574986256014993d), new NpgsqlTypes.NpgsqlPoint(x: 0.1250985392009295d, y: 0.8429501966365865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6772176050133235d, y: 0.5811381357931832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578280255475123d, y: 0.7742519110798436d), new NpgsqlTypes.NpgsqlPoint(x: 0.07778158858647044d, y: 0.030987936609808364d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36559179395896724d, y: 0.9533672056906726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792878544778628d, y: 0.5651849637731852d), new NpgsqlTypes.NpgsqlPoint(x: 0.033293159240470604d, y: 0.13853678660455515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37889409992606093d, y: 0.15086966039440042d), new NpgsqlTypes.NpgsqlPoint(x: 0.21242716263252737d, y: 0.06656683759818616d), new NpgsqlTypes.NpgsqlPoint(x: 0.10538342695550951d, y: 0.7923315143550296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17774196685542043d, y: 0.6190618497172137d), new NpgsqlTypes.NpgsqlPoint(x: 0.06360315993923948d, y: 0.9402209625005218d), new NpgsqlTypes.NpgsqlPoint(x: 0.2441364137409726d, y: 0.8538838140811755d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04769955091398803d, y: 0.9698327019794508d), new NpgsqlTypes.NpgsqlPoint(x: 0.19237151221245086d, y: 0.4402195609136009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864897306130051d, y: 0.7625416828876447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4000936386808823d, y: 0.7505675199443725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189441634571281d, y: 0.7362205890962755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306825216526191d, y: 0.8405192261335152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11551862799140877d, y: 0.40783894877540416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720031153192114d, y: 0.9382470096074632d), new NpgsqlTypes.NpgsqlPoint(x: 0.11491101067308651d, y: 0.11987076413415132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6916849962430538d, y: 0.652094317595691d), new NpgsqlTypes.NpgsqlPoint(x: 0.1091061337207403d, y: 0.6851710114320472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694168279069656d, y: 0.6351693558903235d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47970372021293517d, y: 0.1040113856072099d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672364294474128d, y: 0.7273758579064251d), new NpgsqlTypes.NpgsqlPoint(x: 0.410767963940457d, y: 0.20277618408705878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4270282918857279d, y: 0.7752510328964647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2559197605377773d, y: 0.22098292128694086d), new NpgsqlTypes.NpgsqlPoint(x: 0.01058297324031321d, y: 0.4025210857724044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013447919696322752d, y: 0.9073222893287318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032953124559093d, y: 0.343479500009391d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672557514322286d, y: 0.9315749386754332d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28768092588974925d, y: 0.2929797659636689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4093370818590675d, y: 0.770246755943341d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576795103302353d, y: 0.4591854197522266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9116315750189613d, y: 0.22441102897787968d), new NpgsqlTypes.NpgsqlPoint(x: 0.23818848097335021d, y: 0.6836525783079769d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641935888356936d, y: 0.552063879304849d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12872747309679455d, y: 0.9754136255473979d), new NpgsqlTypes.NpgsqlPoint(x: 0.37682654492308665d, y: 0.12086208684513822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319398825995173d, y: 0.5708653902461494d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35323738866751375d, y: 0.720274243394153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093339065445331d, y: 0.21145150969624138d), new NpgsqlTypes.NpgsqlPoint(x: 0.19600406651600255d, y: 0.05068077375737412d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7339778068552877d, y: 0.6435264400242753d), new NpgsqlTypes.NpgsqlPoint(x: 0.49995522840778694d, y: 0.8585484592581203d), new NpgsqlTypes.NpgsqlPoint(x: 0.583024120639936d, y: 0.058385831947863176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39777077992580834d, y: 0.7189155055132334d), new NpgsqlTypes.NpgsqlPoint(x: 0.36033743565508003d, y: 0.9939690956779587d), new NpgsqlTypes.NpgsqlPoint(x: 0.22911946196317134d, y: 0.10085639856868256d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8936628249511487d, y: 0.5484240420292922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759784650746669d, y: 0.11708145987125684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144038241176338d, y: 0.9416713857418141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.701239380010926d, y: 0.5940077182202779d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384582460171034d, y: 0.06653589677138827d), new NpgsqlTypes.NpgsqlPoint(x: 0.12786204445548777d, y: 0.8321174956147287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5740152565628909d, y: 0.08170128571900248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854485928818819d, y: 0.7459729363974092d), new NpgsqlTypes.NpgsqlPoint(x: 0.07060882983272754d, y: 0.5433610055500899d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4701775794139357d, y: 0.03090888596110264d), new NpgsqlTypes.NpgsqlPoint(x: 0.034996001583733394d, y: 0.18968929120748457d), new NpgsqlTypes.NpgsqlPoint(x: 0.580602068270132d, y: 0.6048966256476139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02298586843356576d, y: 0.5725153143293179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180179639167704d, y: 0.1451208055617017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802823102393671d, y: 0.6818305526566562d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8136564475890221d, y: 0.8582482703399347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765354493841906d, y: 0.6848648855291348d), new NpgsqlTypes.NpgsqlPoint(x: 0.29888551552969467d, y: 0.5352222632357178d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5790606074673864d, y: 0.366842484560451d), new NpgsqlTypes.NpgsqlPoint(x: 0.47003786562403616d, y: 0.5123361764925475d), new NpgsqlTypes.NpgsqlPoint(x: 0.027808063284690654d, y: 0.3974771399156126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5351415463854196d, y: 0.432483477608567d), new NpgsqlTypes.NpgsqlPoint(x: 0.45294860533234527d, y: 0.4007587675235913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956968884411959d, y: 0.7847221381782182d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3238036879961851d, y: 0.9815130036349016d), new NpgsqlTypes.NpgsqlPoint(x: 0.1298750474317092d, y: 0.0389247217571167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7156625123225632d, y: 0.576671210097465d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2882487525692864d, y: 0.47746985858947466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3421247651715281d, y: 0.6605638148071407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7588670149045625d, y: 0.5215990871786761d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8907561583626471d, y: 0.5988943745709865d), new NpgsqlTypes.NpgsqlPoint(x: 0.787471674174012d, y: 0.19631662850775855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521178320365836d, y: 0.4560575170261423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036472203694891d, y: 0.47644837402401463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428384358401066d, y: 0.568881429894643d), new NpgsqlTypes.NpgsqlPoint(x: 0.41224723799063223d, y: 0.708509403892841d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.127656967550127d, y: 0.4941207474698128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307142612522268d, y: 0.13298032499901202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795170137286844d, y: 0.42782537650000885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17995071289000764d, y: 0.1976159561870484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036991395200812d, y: 0.4395912824042011d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838781852896917d, y: 0.004825382423887747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6458590800378712d, y: 0.043300174075030395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165092795401935d, y: 0.1755675036710066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096424249185106d, y: 0.9515719337509092d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168571187810369d, y: 0.09429840298315428d), new NpgsqlTypes.NpgsqlPoint(x: 0.07571503463887441d, y: 0.8038972503187641d), new NpgsqlTypes.NpgsqlPoint(x: 0.8862999410370047d, y: 0.8083440881345751d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9607267000914377d, y: 0.5687906396971328d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294190328117915d, y: 0.4828651068011578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758670999090568d, y: 0.8642786064546119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8890452155213908d, y: 0.995255691709118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295043389798069d, y: 0.28051260324547445d), new NpgsqlTypes.NpgsqlPoint(x: 0.13856313441185375d, y: 0.5565501807181952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09861806951952323d, y: 0.531286010982081d), new NpgsqlTypes.NpgsqlPoint(x: 0.0857092952054056d, y: 0.25828303767029015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3910958077069989d, y: 0.2628052211630264d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7436023150797938d, y: 0.11310085359529531d), new NpgsqlTypes.NpgsqlPoint(x: 0.3632298451235537d, y: 0.23020926532830632d), new NpgsqlTypes.NpgsqlPoint(x: 0.736812638808391d, y: 0.7951521828590328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679486693796738d, y: 0.201035641700118d), new NpgsqlTypes.NpgsqlPoint(x: 0.4676429835487792d, y: 0.5830425197292441d), new NpgsqlTypes.NpgsqlPoint(x: 0.11993346498158086d, y: 0.28088555254878855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4214112914575959d, y: 0.3690037052240628d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733512485033798d, y: 0.5029158355061779d), new NpgsqlTypes.NpgsqlPoint(x: 0.24082659172632848d, y: 0.605087622429302d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6362002367642599d, y: 0.3316344834410755d), new NpgsqlTypes.NpgsqlPoint(x: 0.2588469009674863d, y: 0.7706253572379196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7252821438715535d, y: 0.7271216904036957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521176911845295d, y: 0.004486207201704451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666286948840192d, y: 0.9585325737281212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904128237544815d, y: 0.25868081359617145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08058259688011138d, y: 0.9119118965128045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3366024089769729d, y: 0.3690024576818821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5405386580493025d, y: 0.24316875626737777d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9360889613259221d, y: 0.9555907623275216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7848307686209681d, y: 0.40199603638311454d), new NpgsqlTypes.NpgsqlPoint(x: 0.2399608872977963d, y: 0.7002712914097287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22268009549341994d, y: 0.8795237731018086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579005216959283d, y: 0.4033251084322971d), new NpgsqlTypes.NpgsqlPoint(x: 0.08448286797557969d, y: 0.8032838608577515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6113930124286656d, y: 0.4986549166323361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7804202418434748d, y: 0.7589759110775788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719440240941682d, y: 0.9645498146446658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1501591033253602d, y: 0.5458732096123644d), new NpgsqlTypes.NpgsqlPoint(x: 0.40576757325776436d, y: 0.2169387654671947d), new NpgsqlTypes.NpgsqlPoint(x: 0.13488144282417103d, y: 0.7776712055601457d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5362631588027605d, y: 0.5486726227903086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645693240072504d, y: 0.3307998479865978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281889211921954d, y: 0.013314460654039073d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13584667237097803d, y: 0.92013229519643d), new NpgsqlTypes.NpgsqlPoint(x: 0.27754973445652453d, y: 0.5529911161644824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668548654999017d, y: 0.44045815466737337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7232454695310558d, y: 0.017850761796517345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559438963984402d, y: 0.734847251762681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3656541004679673d, y: 0.7819926784675253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17574900848444797d, y: 0.13910434336523092d), new NpgsqlTypes.NpgsqlPoint(x: 0.23992166290218864d, y: 0.13072617392381447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3757809280508331d, y: 0.42750643525186804d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034866507983073d, y: 0.7106567180774752d), new NpgsqlTypes.NpgsqlPoint(x: 0.38928230177088874d, y: 0.9379885555393419d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624622103264715d, y: 0.49717581080973317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24925281864304594d, y: 0.3758728167345764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4684344404483848d, y: 0.9429883204004957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7960489475900164d, y: 0.16128456811065928d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11674906585950162d, y: 0.4269931153159232d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536787915509991d, y: 0.3858417729853246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546279829631357d, y: 0.240495246593454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8094422295676923d, y: 0.6156487192000878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205603533054526d, y: 0.24333963613178566d), new NpgsqlTypes.NpgsqlPoint(x: 0.09377816968820252d, y: 0.6560731617891113d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1640295722165731d, y: 0.39966980767691096d), new NpgsqlTypes.NpgsqlPoint(x: 0.1784624989287481d, y: 0.6937553981072058d), new NpgsqlTypes.NpgsqlPoint(x: 0.804307376469382d, y: 0.20157829610589628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9112286602655155d, y: 0.3706893567152666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313631807266232d, y: 0.3517965400387889d), new NpgsqlTypes.NpgsqlPoint(x: 0.10312195288453385d, y: 0.329518501016431d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2783495994642319d, y: 0.3733517790334575d), new NpgsqlTypes.NpgsqlPoint(x: 0.375268878374987d, y: 0.1344568019116782d), new NpgsqlTypes.NpgsqlPoint(x: 0.4625583596677101d, y: 0.1679571215569211d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6936731102004312d, y: 0.11068926989790062d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622377809721845d, y: 0.7767122343639651d), new NpgsqlTypes.NpgsqlPoint(x: 0.41183450521533094d, y: 0.5812662168001732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5724828123141991d, y: 0.09092921558663292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863512456216079d, y: 0.020502273079286315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591648227840327d, y: 0.5214172513113903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9850530014503116d, y: 0.9730046353579993d), new NpgsqlTypes.NpgsqlPoint(x: 0.07532748812654932d, y: 0.679994556568927d), new NpgsqlTypes.NpgsqlPoint(x: 0.08281926071214374d, y: 0.5159597592693171d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6337431239055089d, y: 0.5923271600165408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504471993082427d, y: 0.32604189243411297d), new NpgsqlTypes.NpgsqlPoint(x: 0.07757250454430642d, y: 0.873342683764864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9544334219876067d, y: 0.6373995909827018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6586916173983889d, y: 0.5193756858591796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5077572434806438d, y: 0.77140487751232d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06453823752753851d, y: 0.5187080438801978d), new NpgsqlTypes.NpgsqlPoint(x: 0.05665249968224295d, y: 0.7838795460447635d), new NpgsqlTypes.NpgsqlPoint(x: 0.4219038228899652d, y: 0.16277998027563378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25136242490025085d, y: 0.1626679548001092d), new NpgsqlTypes.NpgsqlPoint(x: 0.07519752589047668d, y: 0.6186256375519631d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402731958201225d, y: 0.09526995724401066d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6585613674996513d, y: 0.08988202545279822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503133243084157d, y: 0.18291674383037193d), new NpgsqlTypes.NpgsqlPoint(x: 0.058716835330549166d, y: 0.9510023049890667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49417326694041475d, y: 0.9195835486775753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6083844019209983d, y: 0.18361234570660045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2115573056767467d, y: 0.14321270411128284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7748252721376653d, y: 0.275819636285179d), new NpgsqlTypes.NpgsqlPoint(x: 0.2483982097281784d, y: 0.7032203571185328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3348619119364532d, y: 0.5417963721427452d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7625078507387234d, y: 0.1741628547615729d), new NpgsqlTypes.NpgsqlPoint(x: 0.18501684186963374d, y: 0.8440628238785339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731456929475154d, y: 0.023941912154432754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21522507506409683d, y: 0.0475432603866669d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356228135648602d, y: 0.8065097815327327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3739828322544564d, y: 0.8444364205092295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31683164900302363d, y: 0.8420200079747409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279203055294952d, y: 0.5273571280499436d), new NpgsqlTypes.NpgsqlPoint(x: 0.688644658922441d, y: 0.7534571482669766d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6712633392087785d, y: 0.30216167143991424d), new NpgsqlTypes.NpgsqlPoint(x: 0.330002860293907d, y: 0.4106276325732703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085045986012571d, y: 0.7283100952082707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3842124436914258d, y: 0.47534884739222816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877723680326038d, y: 0.2674700131687868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441722489483603d, y: 0.02434066336615537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4136223686850883d, y: 0.8901037344308698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157365671921851d, y: 0.5874435865796538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5816567216347822d, y: 0.6505816280250499d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4938927909971317d, y: 0.6297609191413386d), new NpgsqlTypes.NpgsqlPoint(x: 0.2170118258138588d, y: 0.2807498137149613d), new NpgsqlTypes.NpgsqlPoint(x: 0.0015808706760381819d, y: 0.6260954908946772d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02687962958990997d, y: 0.6194072056218869d), new NpgsqlTypes.NpgsqlPoint(x: 0.10358578348536729d, y: 0.014044715592828494d), new NpgsqlTypes.NpgsqlPoint(x: 0.583208514402079d, y: 0.7606471569320639d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1196298441928576d, y: 0.7062187769503484d), new NpgsqlTypes.NpgsqlPoint(x: 0.4576339568888155d, y: 0.19280474090483612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200270959917395d, y: 0.9050896119709957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08822239389555275d, y: 0.5617595133774437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3440108449923024d, y: 0.020999945184220548d), new NpgsqlTypes.NpgsqlPoint(x: 0.08383969358177334d, y: 0.42622571087014727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6539204583829911d, y: 0.9851492684262548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513658558109958d, y: 0.46970511711586405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5313444581663113d, y: 0.5035129709918691d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40841813964050033d, y: 0.2596203335829096d), new NpgsqlTypes.NpgsqlPoint(x: 0.32975324405493445d, y: 0.9596687786135162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139735600403236d, y: 0.6622100733654144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9507086050302295d, y: 0.08928830118140607d), new NpgsqlTypes.NpgsqlPoint(x: 0.22672305120467962d, y: 0.22324366019532504d), new NpgsqlTypes.NpgsqlPoint(x: 0.318337881534697d, y: 0.48375775638025176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01960648902807438d, y: 0.7331923664522114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262843925315447d, y: 0.3166827028283882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054949396138167d, y: 0.5233823693202468d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1777369065371025d, y: 0.2517793730779144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002654747834584d, y: 0.8626551415711075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140810294635975d, y: 0.9729892544952986d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34943701574731734d, y: 0.3114857376394433d), new NpgsqlTypes.NpgsqlPoint(x: 0.463456061134806d, y: 0.8740710886311681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069860552869049d, y: 0.950262108747466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052542623323360016d, y: 0.9004860500603463d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669409855410497d, y: 0.32891550843036377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703499421518375d, y: 0.741307431573769d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3152481679460507d, y: 0.5870858254936859d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341007159148748d, y: 0.8437063600960893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569083600728132d, y: 0.24752543410008954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6371639775481015d, y: 0.9175017338281536d), new NpgsqlTypes.NpgsqlPoint(x: 0.2487669324044568d, y: 0.5869925564131295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495131630973278d, y: 0.7621782187104633d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9269054219389248d, y: 0.7642763037990425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857190703475646d, y: 0.502830513455195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513973893921576d, y: 0.20451691478266243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713216690483612d, y: 0.5354619960742267d), new NpgsqlTypes.NpgsqlPoint(x: 0.31961228083306104d, y: 0.15112731764800513d), new NpgsqlTypes.NpgsqlPoint(x: 0.567611612787764d, y: 0.4200360644898513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1034559289753687d, y: 0.464953040527466d), new NpgsqlTypes.NpgsqlPoint(x: 0.38961313878629766d, y: 0.5460195749564097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558796886735857d, y: 0.5294720620998264d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5948692051635356d, y: 0.049835360061426526d), new NpgsqlTypes.NpgsqlPoint(x: 0.01237998221348069d, y: 0.7321283877259871d), new NpgsqlTypes.NpgsqlPoint(x: 0.11732240086304291d, y: 0.6427505630477686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22194282025819156d, y: 0.7956471800095518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801523633449293d, y: 0.6178916059640822d), new NpgsqlTypes.NpgsqlPoint(x: 0.07400018832739552d, y: 0.5636446146376869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7592470209499749d, y: 0.7084135355922956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002341142704603d, y: 0.11176931119402089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694058668456638d, y: 0.0912961869904707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6566583358436917d, y: 0.41601151780510015d), new NpgsqlTypes.NpgsqlPoint(x: 0.048424515637675136d, y: 0.6960328212402458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106170435334646d, y: 0.04518850948923092d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7355212681923725d, y: 0.7144419885319713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8779169673110013d, y: 0.7349327270135088d), new NpgsqlTypes.NpgsqlPoint(x: 0.46758067370404544d, y: 0.4113811744709517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155818178998007d, y: 0.9732673815156581d), new NpgsqlTypes.NpgsqlPoint(x: 0.12240075528261429d, y: 0.3956324953520207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730077599780894d, y: 0.641920198925148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5460014550896674d, y: 0.46142682813524616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924273444184125d, y: 0.5980608650885112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331637638115079d, y: 0.6373319257642133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06536526362239226d, y: 0.7731555046071246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572680454202867d, y: 0.24958313076451122d), new NpgsqlTypes.NpgsqlPoint(x: 0.20488360950513118d, y: 0.09485099598338365d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6631442027397284d, y: 0.07444188176844313d), new NpgsqlTypes.NpgsqlPoint(x: 0.07004493424705538d, y: 0.8820423660490777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968413213006978d, y: 0.056562659102007196d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531618836946904d, y: 0.32485071641119034d), new NpgsqlTypes.NpgsqlPoint(x: 0.25313422593672963d, y: 0.47199235469400314d), new NpgsqlTypes.NpgsqlPoint(x: 0.0799438166144244d, y: 0.17278765457520118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8428195766453574d, y: 0.4047724152051727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540828677188023d, y: 0.10638084042474405d), new NpgsqlTypes.NpgsqlPoint(x: 0.31161525767755394d, y: 0.7417850153832565d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030541260800925674d, y: 0.996462200480312d), new NpgsqlTypes.NpgsqlPoint(x: 0.04948453238756434d, y: 0.25969060690736634d), new NpgsqlTypes.NpgsqlPoint(x: 0.792920952764041d, y: 0.23310884012522037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5227603078564839d, y: 0.6367715141471351d), new NpgsqlTypes.NpgsqlPoint(x: 0.9416611750810611d, y: 0.1211653607160843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6996326410560393d, y: 0.9776862739954133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3335545767301017d, y: 0.8437803523496226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3900914085776772d, y: 0.9529971175968718d), new NpgsqlTypes.NpgsqlPoint(x: 0.28969335713631983d, y: 0.14304622501260955d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2545516926602338d, y: 0.09679794423255306d), new NpgsqlTypes.NpgsqlPoint(x: 0.13337650497253595d, y: 0.5971023509529301d), new NpgsqlTypes.NpgsqlPoint(x: 0.03641878721645897d, y: 0.5220418942521641d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11569085100309306d, y: 0.5961016840466319d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529145960582335d, y: 0.48972775275806024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878842871015133d, y: 0.0011864356974774504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003909185205347998d, y: 0.47345366010658385d), new NpgsqlTypes.NpgsqlPoint(x: 0.49481414850935856d, y: 0.9969414544786535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337066877289532d, y: 0.8418252624613283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25918736977791534d, y: 0.9641176737497313d), new NpgsqlTypes.NpgsqlPoint(x: 0.186202066729257d, y: 0.5447026500010549d), new NpgsqlTypes.NpgsqlPoint(x: 0.029058722431843043d, y: 0.026795415113010423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9768196214940978d, y: 0.20083055335887723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575924433732306d, y: 0.4968724558715788d), new NpgsqlTypes.NpgsqlPoint(x: 0.09044626184701243d, y: 0.6769955756099701d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8164708248208279d, y: 0.4717287941606275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928381121372706d, y: 0.9078893573955239d), new NpgsqlTypes.NpgsqlPoint(x: 0.2995111264916652d, y: 0.3835424286921415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8490843116368254d, y: 0.15810591838432464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014236342930151d, y: 0.4340980235984091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4172414148618845d, y: 0.08168072987691766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7383501227816097d, y: 0.03385687830255801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982946707942896d, y: 0.22692705335082153d), new NpgsqlTypes.NpgsqlPoint(x: 0.15316868938119987d, y: 0.8659763259413069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.622116519263063d, y: 0.740182887809988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3006525167383022d, y: 0.2694289814795342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819764440497033d, y: 0.24485193486486534d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32444828000665615d, y: 0.6020139270270395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7087979049866839d, y: 0.8603373606587955d), new NpgsqlTypes.NpgsqlPoint(x: 0.800413000125116d, y: 0.8772453848929458d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5741454772187116d, y: 0.20007040224259676d), new NpgsqlTypes.NpgsqlPoint(x: 0.29568447179996415d, y: 0.2720323355753934d), new NpgsqlTypes.NpgsqlPoint(x: 0.19909222310143393d, y: 0.6488798103079043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5711288151663542d, y: 0.5764798589492677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278962911660077d, y: 0.36215525840315166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264762632670716d, y: 0.5403469282033504d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47560487573442256d, y: 0.6350578970364729d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356497231015651d, y: 0.978965987556797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621756663694898d, y: 0.9255507624490699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3281601310060358d, y: 0.8442590309566858d), new NpgsqlTypes.NpgsqlPoint(x: 0.962375839452918d, y: 0.06110438290949183d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624730337039656d, y: 0.7752602238763875d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10409500837384922d, y: 0.16860125717977836d), new NpgsqlTypes.NpgsqlPoint(x: 0.08547926652560123d, y: 0.9337984706980036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5149264558792402d, y: 0.083817031367588d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0810765968674052d, y: 0.7561847813604703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637966239699493d, y: 0.7112024252717811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867519819096032d, y: 0.5764319347546657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19650243496146325d, y: 0.1728950572068647d), new NpgsqlTypes.NpgsqlPoint(x: 0.22556255935242686d, y: 0.9111358103778499d), new NpgsqlTypes.NpgsqlPoint(x: 0.28328758966807943d, y: 0.4794293191313832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25032834971440265d, y: 0.7817260930830008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813352587200479d, y: 0.379774246802669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781046007678224d, y: 0.13547089272241764d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45983446948902096d, y: 0.5328693747190327d), new NpgsqlTypes.NpgsqlPoint(x: 0.43012508424193485d, y: 0.080819492779586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6778516850724504d, y: 0.41066142607385403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6883332951608472d, y: 0.5749571572485396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002092632234595d, y: 0.790245009300303d), new NpgsqlTypes.NpgsqlPoint(x: 0.06710465598683224d, y: 0.7863664230526479d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27605526904084643d, y: 0.4940253424637414d), new NpgsqlTypes.NpgsqlPoint(x: 0.17175252440235889d, y: 0.30995617161609d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116293843397164d, y: 0.391104539493751d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38143045291094213d, y: 0.15933209338652798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4587135401174467d, y: 0.6364318321191946d), new NpgsqlTypes.NpgsqlPoint(x: 0.05611005093304067d, y: 0.06006347297669379d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48276533924395226d, y: 0.7053791776615583d), new NpgsqlTypes.NpgsqlPoint(x: 0.02954658156369283d, y: 0.6654552092069785d), new NpgsqlTypes.NpgsqlPoint(x: 0.16292818841098178d, y: 0.8037557662857465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20510762576264652d, y: 0.8784213749601445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1313634319972108d, y: 0.5208366439487087d), new NpgsqlTypes.NpgsqlPoint(x: 0.367628884042831d, y: 0.8969653823029307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3710001096704314d, y: 0.027168129314457223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394103280302798d, y: 0.7593337148881798d), new NpgsqlTypes.NpgsqlPoint(x: 0.34990703252698396d, y: 0.4229192227270455d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10024658225153504d, y: 0.8289758104872332d), new NpgsqlTypes.NpgsqlPoint(x: 0.938359497601095d, y: 0.640944008398573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852725528347195d, y: 0.852286874616054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03240838522566136d, y: 0.08715143259202729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873434940273638d, y: 0.6738904386903737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855628135806711d, y: 0.5743901987435893d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4937265177142407d, y: 0.4736979742328965d), new NpgsqlTypes.NpgsqlPoint(x: 0.23662266125464892d, y: 0.9437353420743182d), new NpgsqlTypes.NpgsqlPoint(x: 0.23879455339708133d, y: 0.05433058825317616d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3425571154978758d, y: 0.32248320925937557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394129699663619d, y: 0.1993981946943949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127666374499726d, y: 0.9006285570127355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12623240390354107d, y: 0.23062008777562515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117152797428544d, y: 0.1478652464987379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267956457827384d, y: 0.9971930504997951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8854655374422616d, y: 0.5415330101655915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254476065971602d, y: 0.05428379379366832d), new NpgsqlTypes.NpgsqlPoint(x: 0.456979721455966d, y: 0.7064619216393753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5822520773029357d, y: 0.9507595452921033d), new NpgsqlTypes.NpgsqlPoint(x: 0.05563589960543969d, y: 0.541206908241012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935353009583119d, y: 0.6198359847455519d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942257935884248d, y: 0.054102607031780714d), new NpgsqlTypes.NpgsqlPoint(x: 0.08205985708565422d, y: 0.5099736759434564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228093120934776d, y: 0.336768351720813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338994783173489d, y: 0.36710977241279186d), new NpgsqlTypes.NpgsqlPoint(x: 0.20279231786430607d, y: 0.698576738107291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137281243406298d, y: 0.18220736233034684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140834271208702d, y: 0.8847040052221133d), new NpgsqlTypes.NpgsqlPoint(x: 0.11974374218262707d, y: 0.7442522350866596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225965515658814d, y: 0.0957392170873621d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8716938369935073d, y: 0.13419119507687594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512393028395656d, y: 0.551248671640352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105458631492996d, y: 0.16145044857864765d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41423562121403956d, y: 0.8920731079187924d), new NpgsqlTypes.NpgsqlPoint(x: 0.2437921295734704d, y: 0.4384972506715321d), new NpgsqlTypes.NpgsqlPoint(x: 0.21249670323499026d, y: 0.5352115383452507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7545719167532281d, y: 0.4202708443341976d), new NpgsqlTypes.NpgsqlPoint(x: 0.4256667404128692d, y: 0.9453206983050204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860012158765526d, y: 0.8768049320720428d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4024257751364594d, y: 0.8302655104082148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314363370191632d, y: 0.31641339469046426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139215108335219d, y: 0.6486444945669728d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0861265935640122d, y: 0.03325004337614246d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849545759994674d, y: 0.45124852322043196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252061288243446d, y: 0.10655551109270345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.682611621290714d, y: 0.8999301890366602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159435446046571d, y: 0.1320850574124357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9032927193396771d, y: 0.7494157024948838d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9197312443572007d, y: 0.3420447982131276d), new NpgsqlTypes.NpgsqlPoint(x: 0.17498481916759623d, y: 0.3859621324314142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549274281034273d, y: 0.08019558136720806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5254602910838555d, y: 0.3474649338177709d), new NpgsqlTypes.NpgsqlPoint(x: 0.4731257715790872d, y: 0.7444591887924463d), new NpgsqlTypes.NpgsqlPoint(x: 0.44644510395777626d, y: 0.05141199383721762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8830418613571532d, y: 0.8772116946325483d), new NpgsqlTypes.NpgsqlPoint(x: 0.13021702867917606d, y: 0.06425981237277534d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274489358545276d, y: 0.7412872133100312d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858396129284854d, y: 0.7212058608269755d), new NpgsqlTypes.NpgsqlPoint(x: 0.23743425797706585d, y: 0.19816789841670657d), new NpgsqlTypes.NpgsqlPoint(x: 0.3639854781890036d, y: 0.03476914110300722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5305179597945509d, y: 0.4670538595839717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5698135972176074d, y: 0.48949014591598405d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802597971142462d, y: 0.3400931341148661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7429491677792404d, y: 0.1580915555544632d), new NpgsqlTypes.NpgsqlPoint(x: 0.2344895921389598d, y: 0.05173126172317122d), new NpgsqlTypes.NpgsqlPoint(x: 0.0589805001267637d, y: 0.44014151621120556d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29921482232181196d, y: 0.03756514262399169d), new NpgsqlTypes.NpgsqlPoint(x: 0.10961117935500886d, y: 0.2558198494704066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317105967024733d, y: 0.18747217205328315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41628786562643194d, y: 0.301364130715411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6076378697843717d, y: 0.855159570964144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822389787691047d, y: 0.47821656019662684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05682817805058271d, y: 0.8820873947998936d), new NpgsqlTypes.NpgsqlPoint(x: 0.28023943006260366d, y: 0.4543761960724967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759073539974555d, y: 0.564651952272384d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49034464823579027d, y: 0.3033768607013938d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818658923551969d, y: 0.9655513052758025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108526058739024d, y: 0.3970481900109871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44229865206715613d, y: 0.5286374875985396d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007677702209327d, y: 0.0743988385409341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519716078146398d, y: 0.9612178728591336d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.849572057692734d, y: 0.7576935783373774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445217000979059d, y: 0.2653284016944303d), new NpgsqlTypes.NpgsqlPoint(x: 0.12390257094868407d, y: 0.5614883911103178d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14805242539654428d, y: 0.19001570274216983d), new NpgsqlTypes.NpgsqlPoint(x: 0.46259986215530235d, y: 0.3048742602411837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179482111799666d, y: 0.1118325323379663d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8912181168273797d, y: 0.3246848793424023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7349335024209411d, y: 0.15822526691052563d), new NpgsqlTypes.NpgsqlPoint(x: 0.10897976661210562d, y: 0.44760127531877136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3958986259103452d, y: 0.5624948255857738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111397746862888d, y: 0.0028397774002437703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163832091922039d, y: 0.9145583257922825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2013458611510447d, y: 0.31838887700353846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250162762288455d, y: 0.09442956845625161d), new NpgsqlTypes.NpgsqlPoint(x: 0.24237293400647042d, y: 0.6709519897853982d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2263254115733886d, y: 0.44116318413865574d), new NpgsqlTypes.NpgsqlPoint(x: 0.19756850644333934d, y: 0.8187834539490544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9588379090115496d, y: 0.43560011813393384d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9866457800406785d, y: 0.5952410668321437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792454082085811d, y: 0.7868929165781543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7145732884376543d, y: 0.16911375946247986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4676236455997941d, y: 0.9237936365604172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653871491418113d, y: 0.5940170043717599d), new NpgsqlTypes.NpgsqlPoint(x: 0.4968980600638815d, y: 0.09522347793486696d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42036227266449855d, y: 0.8773780493071338d), new NpgsqlTypes.NpgsqlPoint(x: 0.05382444944465248d, y: 0.7119466327774624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3022932456770524d, y: 0.7777653329185377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0952833411537175d, y: 0.9500754080128919d), new NpgsqlTypes.NpgsqlPoint(x: 0.42047801938104834d, y: 0.8624637358145252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7571171511205891d, y: 0.826638059392949d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24420034056767181d, y: 0.5810043943227289d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718030824053611d, y: 0.36533384539173697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605453270128934d, y: 0.3561290168800293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1738851276831066d, y: 0.2565127892044692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358531317528532d, y: 0.2521652141261893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814215036782501d, y: 0.5202222565434138d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30525441861156277d, y: 0.7487002120720899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563354096116703d, y: 0.986586861097939d), new NpgsqlTypes.NpgsqlPoint(x: 0.23696085893207341d, y: 0.23046798309342698d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9020463065128318d, y: 0.03837743178713737d), new NpgsqlTypes.NpgsqlPoint(x: 0.14834965032180802d, y: 0.9631811993137519d), new NpgsqlTypes.NpgsqlPoint(x: 0.049842511417712676d, y: 0.3196767854487075d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5378280803807443d, y: 0.46569770524498844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457157923372473d, y: 0.037971634704661694d), new NpgsqlTypes.NpgsqlPoint(x: 0.4998081342523467d, y: 0.509539319631055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2766742353783723d, y: 0.7553655671321882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607724618125577d, y: 0.42059337773639616d), new NpgsqlTypes.NpgsqlPoint(x: 0.18831417451489618d, y: 0.2786640548368109d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38589976134840265d, y: 0.20084839043849456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489712061786844d, y: 0.14023769469956826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092874464036606d, y: 0.7362498231615414d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693454273698091d, y: 0.20320274542971128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5455430294227152d, y: 0.510914076878972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8643618830218575d, y: 0.24319534012831379d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14973958778335383d, y: 0.04031858784325093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936138727779055d, y: 0.7445685327616544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5938712807895997d, y: 0.8979409472099268d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5041014351275134d, y: 0.7296065836160848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745792986342393d, y: 0.621691569765049d), new NpgsqlTypes.NpgsqlPoint(x: 0.24595110754251004d, y: 0.22409701952654337d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8355936264997758d, y: 0.32233700969270607d), new NpgsqlTypes.NpgsqlPoint(x: 0.13545254197093304d, y: 0.3289567916672501d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463723424611019d, y: 0.8779843761358515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3100793678646896d, y: 0.05631162538901302d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502826699923212d, y: 0.6832376487779137d), new NpgsqlTypes.NpgsqlPoint(x: 0.1150575909978746d, y: 0.3301849280080411d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35879363384195073d, y: 0.7915111601746098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2143081073716363d, y: 0.40418227034247467d), new NpgsqlTypes.NpgsqlPoint(x: 0.47851965440190325d, y: 0.2919128949976382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.413259148916027d, y: 0.11627511385570355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408412733662529d, y: 0.5380423426289411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625135286124063d, y: 0.2563444679622727d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.626486050501725d, y: 0.2704874543676421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314575129983616d, y: 0.28738357795836844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9150415460821886d, y: 0.6772524941881611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6640358214799619d, y: 0.7858462474855121d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376122586992286d, y: 0.046385017836453324d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413890547639106d, y: 0.8307641759388437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49928951113254283d, y: 0.1939922526644151d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734247705137324d, y: 0.8134494226613782d), new NpgsqlTypes.NpgsqlPoint(x: 0.24522222896672807d, y: 0.6466272504165962d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05727993096202921d, y: 0.9009348245999488d), new NpgsqlTypes.NpgsqlPoint(x: 0.005526813624795124d, y: 0.1578329668602988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929595018813488d, y: 0.3453090865692221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6607424770864394d, y: 0.18673684219691167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372356116154402d, y: 0.05785370858416594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645714761447327d, y: 0.9255990215253723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8822074709829856d, y: 0.8932570314072165d), new NpgsqlTypes.NpgsqlPoint(x: 0.74475120359139d, y: 0.32348167943743833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459289110955877d, y: 0.4698648312992506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8946308877371293d, y: 0.7924740842338729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626006783331628d, y: 0.24144895724480764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4517724669249237d, y: 0.6917890236199674d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21100498108393673d, y: 0.3391918220572967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203468255258854d, y: 0.7824155101316069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901995774719567d, y: 0.6595339538297917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9079249528552704d, y: 0.5906793130306419d), new NpgsqlTypes.NpgsqlPoint(x: 0.16360533961969226d, y: 0.9125985064101747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3062323246921217d, y: 0.6193781276837695d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3312138065739627d, y: 0.8019555539934967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8779641118072519d, y: 0.41005561527463075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668379173550477d, y: 0.0776693760075321d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197967017550378d, y: 0.05889295581553966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055979009250285d, y: 0.18507287250121296d), new NpgsqlTypes.NpgsqlPoint(x: 0.01032821617914581d, y: 0.7032025335782293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8795141992982554d, y: 0.46313292762260116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2946939787143421d, y: 0.317616140501789d), new NpgsqlTypes.NpgsqlPoint(x: 0.91578779710636d, y: 0.4304840461603856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6207091682990616d, y: 0.19341406575200404d), new NpgsqlTypes.NpgsqlPoint(x: 0.39090401426476074d, y: 0.8632584910462562d), new NpgsqlTypes.NpgsqlPoint(x: 0.2752771918389031d, y: 0.5120012764457316d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7933641029837148d, y: 0.7360540545091933d), new NpgsqlTypes.NpgsqlPoint(x: 0.018188231357995743d, y: 0.020160981482920115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997444627647579d, y: 0.3004314061226747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30309436561098124d, y: 0.7740763180823602d), new NpgsqlTypes.NpgsqlPoint(x: 0.48416686124713804d, y: 0.7552324873787541d), new NpgsqlTypes.NpgsqlPoint(x: 0.002881209152174713d, y: 0.9933376410917176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483332968215052d, y: 0.9489909793559307d), new NpgsqlTypes.NpgsqlPoint(x: 0.08213864153722095d, y: 0.4640916493774203d), new NpgsqlTypes.NpgsqlPoint(x: 0.397555191745683d, y: 0.5301229472473585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27560943696418383d, y: 0.24889050695639048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901132564940259d, y: 0.4812824469157757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8514169444025477d, y: 0.07196384757860153d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6746974496588497d, y: 0.32191165092139984d), new NpgsqlTypes.NpgsqlPoint(x: 0.06716065210109623d, y: 0.9337390071417876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078682324612921d, y: 0.6509118939823126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9283371274784433d, y: 0.08190912888001112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354975021460739d, y: 0.1535767493233402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964231456832009d, y: 0.24181050368222623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5437886289247358d, y: 0.7817685791342278d), new NpgsqlTypes.NpgsqlPoint(x: 0.49268237206864474d, y: 0.2521890782220143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700711461610263d, y: 0.9431329335354064d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9924940971980024d, y: 0.20027972538698247d), new NpgsqlTypes.NpgsqlPoint(x: 0.38873556332337067d, y: 0.8687226709601296d), new NpgsqlTypes.NpgsqlPoint(x: 0.34768256226382144d, y: 0.33566895504452d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2702327340446964d, y: 0.8700350689784975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393564860427367d, y: 0.007765445538214899d), new NpgsqlTypes.NpgsqlPoint(x: 0.2893153935249252d, y: 0.7442107984311619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9813322357133775d, y: 0.6452957019184989d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809478006715891d, y: 0.32836401089080935d), new NpgsqlTypes.NpgsqlPoint(x: 0.1880200296449399d, y: 0.7026393302733399d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9812970516129543d, y: 0.4705830108091408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443556714781106d, y: 0.7245735895458327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139120802622835d, y: 0.5260706111706674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5613193736005269d, y: 0.08983533885580053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766156377954621d, y: 0.8750390132391007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223522304029468d, y: 0.11116093285088036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3923303696856625d, y: 0.6769513399085872d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844237606021598d, y: 0.7271272014879188d), new NpgsqlTypes.NpgsqlPoint(x: 0.924926856536766d, y: 0.1905445287569134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9282021647394324d, y: 0.5349321609487012d), new NpgsqlTypes.NpgsqlPoint(x: 0.18905419015215263d, y: 0.17553099399628513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006696103285473d, y: 0.1341126739069275d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03850827272695245d, y: 0.7053502590791823d), new NpgsqlTypes.NpgsqlPoint(x: 0.43688255105683527d, y: 0.6553034934547541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820170362634977d, y: 0.3210275778750342d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004829256067393484d, y: 0.7175863507891741d), new NpgsqlTypes.NpgsqlPoint(x: 0.49754819661157834d, y: 0.3452699364723366d), new NpgsqlTypes.NpgsqlPoint(x: 0.43034356139795316d, y: 0.5709871257125538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6643967897597227d, y: 0.8080338941121418d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651340060216185d, y: 0.8210284400792446d), new NpgsqlTypes.NpgsqlPoint(x: 0.14977208201510617d, y: 0.9426849235550302d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6748734549707942d, y: 0.15249140461679578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4794418434269221d, y: 0.5498003286092212d), new NpgsqlTypes.NpgsqlPoint(x: 0.04700530630357169d, y: 0.909070463089487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22571805663411393d, y: 0.7612729193917143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9627251863174668d, y: 0.18086481680009103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373421525411119d, y: 0.6840267157502947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8787670060522195d, y: 0.34173520196732d), new NpgsqlTypes.NpgsqlPoint(x: 0.1152480724242142d, y: 0.5679358625198763d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620815557558907d, y: 0.08111045656980542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9930582559179694d, y: 0.8999908396507892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866019757900725d, y: 0.46515421070006546d), new NpgsqlTypes.NpgsqlPoint(x: 0.14793561996127946d, y: 0.0837418925140142d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909821231120734d, y: 0.8940810826006093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4250240484598835d, y: 0.953105355290749d), new NpgsqlTypes.NpgsqlPoint(x: 0.4787980543156303d, y: 0.674326285754216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31638954018605814d, y: 0.9756139030597174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781074655756218d, y: 0.7487687430155805d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144957328845378d, y: 0.7243339810437439d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18628162398946968d, y: 0.8352524267993363d), new NpgsqlTypes.NpgsqlPoint(x: 0.691460278230561d, y: 0.6291008904654093d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712306166469002d, y: 0.6048137202380096d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9069491189190295d, y: 0.3966935021685789d), new NpgsqlTypes.NpgsqlPoint(x: 0.23287737194138425d, y: 0.058653955764981114d), new NpgsqlTypes.NpgsqlPoint(x: 0.07838745581844409d, y: 0.2945524423399263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22949190869403258d, y: 0.5803749163277366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8770096185987715d, y: 0.8563277161907256d), new NpgsqlTypes.NpgsqlPoint(x: 0.12816929105350994d, y: 0.050917825557962426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11077015639744481d, y: 0.5897368798093786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409227829781219d, y: 0.8604969571266209d), new NpgsqlTypes.NpgsqlPoint(x: 0.4166432399752147d, y: 0.5970898785428085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9673423311819271d, y: 0.4081884012614546d), new NpgsqlTypes.NpgsqlPoint(x: 0.11583227843978494d, y: 0.5485056124287374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5003529552185196d, y: 0.49787918804064535d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.541471357932151d, y: 0.038747636736696234d), new NpgsqlTypes.NpgsqlPoint(x: 0.030174435397306465d, y: 0.3493136284276763d), new NpgsqlTypes.NpgsqlPoint(x: 0.2883354726605796d, y: 0.931102596665666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.678530254396794d, y: 0.8011284113758596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5438521342527499d, y: 0.8215117031113911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764657840552815d, y: 0.2936543808837351d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.604277443338586d, y: 0.8534295498446619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561408803119783d, y: 0.11358620255804264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631336355945552d, y: 0.7746944822925614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8860762296919955d, y: 0.05302659890939765d), new NpgsqlTypes.NpgsqlPoint(x: 0.11420209283274108d, y: 0.6055473391570063d), new NpgsqlTypes.NpgsqlPoint(x: 0.29348173465861804d, y: 0.8767492284105164d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18692648926090127d, y: 0.6143601679023413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020724021500692d, y: 0.9328899187617964d), new NpgsqlTypes.NpgsqlPoint(x: 0.035029966125339596d, y: 0.9948839011838377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43228417135931585d, y: 0.42685481879352893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866593199623108d, y: 0.8597969176052892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9234386812390665d, y: 0.23355232493965772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5787270114393362d, y: 0.5517064426943351d), new NpgsqlTypes.NpgsqlPoint(x: 0.37344098505560364d, y: 0.24097203707934534d), new NpgsqlTypes.NpgsqlPoint(x: 0.18193902944894846d, y: 0.6564990878589325d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1838118208478139d, y: 0.43423206394009706d), new NpgsqlTypes.NpgsqlPoint(x: 0.28037766177680423d, y: 0.8905189520287452d), new NpgsqlTypes.NpgsqlPoint(x: 0.0642614014118873d, y: 0.6041499833002966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6966778826002517d, y: 0.9953357353763571d), new NpgsqlTypes.NpgsqlPoint(x: 0.04401788925276384d, y: 0.94065478629535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435954096851323d, y: 0.4878938154889719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3014963347645194d, y: 0.44291324226234385d), new NpgsqlTypes.NpgsqlPoint(x: 0.35646352567946626d, y: 0.6132159025094324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096494993600402d, y: 0.7902153977811994d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5188175642767202d, y: 0.6662350390738208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837890801646517d, y: 0.5138543278881565d), new NpgsqlTypes.NpgsqlPoint(x: 0.704622856508707d, y: 0.8433638780963296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236451285066578d, y: 0.5896426580522707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369577972751917d, y: 0.1465273101682978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549968305209731d, y: 0.04050769993329839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3250504756912129d, y: 0.010018093148833618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389235683656762d, y: 0.30247143315458846d), new NpgsqlTypes.NpgsqlPoint(x: 0.17183174625639952d, y: 0.8081893244154441d)),

},
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 76;
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
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 77, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 102, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 149, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

