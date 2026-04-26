

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6306281236796757d,right: 0.5266125930577834d,bottom: 0.42503522102376823d,left: 0.15875290494579186d),

new NpgsqlTypes.NpgsqlBox(top: 0.20865840403263447d,right: 0.2429412364070993d,bottom: 0.2012043634096503d,left: 0.07660763255839775d),

new NpgsqlTypes.NpgsqlBox(top: 0.995045109529674d,right: 0.9716569010934852d,bottom: 0.2681054891209409d,left: 0.1355115245288674d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4612979318917041d,right: 0.9804732806192019d,bottom: 0.18456441248034539d,left: 0.2273932676422582d),

new NpgsqlTypes.NpgsqlBox(top: 0.727655824244838d,right: 0.99037898499257d,bottom: 0.403956480681942d,left: 0.574264877395367d),

new NpgsqlTypes.NpgsqlBox(top: 0.9002629437351772d,right: 0.6686791261618766d,bottom: 0.4666041573805415d,left: 0.14026681364751137d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8485103916166611d,right: 0.784749116944653d,bottom: 0.4975585288201888d,left: 0.36592635190245426d),

new NpgsqlTypes.NpgsqlBox(top: 0.9547437233349871d,right: 0.9090723558669621d,bottom: 0.2429780580897949d,left: 0.3111074666198933d),

new NpgsqlTypes.NpgsqlBox(top: 0.9469580316683306d,right: 0.8347093587803113d,bottom: 0.907900756537052d,left: 0.429173749686782d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8945261386940917d,right: 0.9849991560887951d,bottom: 0.7776238868743865d,left: 0.06867507451426536d),

new NpgsqlTypes.NpgsqlBox(top: 0.8747047887777853d,right: 0.9684798933231082d,bottom: 0.8209359061018556d,left: 0.3400992424296757d),

new NpgsqlTypes.NpgsqlBox(top: 0.8455414248188676d,right: 0.38439868200303395d,bottom: 0.2149923871298992d,left: 0.03063167235526798d),

new NpgsqlTypes.NpgsqlBox(top: 0.6153409697458415d,right: 0.8938366845639084d,bottom: 0.2521773700719905d,left: 0.8329662637693793d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9789975946921292d,right: 0.9742240781466248d,bottom: 0.029782301856545623d,left: 0.2744385155194198d),

new NpgsqlTypes.NpgsqlBox(top: 0.28399376007494936d,right: 0.9494750918176149d,bottom: 0.07207225366965253d,left: 0.1604408030893325d),

new NpgsqlTypes.NpgsqlBox(top: 0.5612752779327723d,right: 0.922857902423161d,bottom: 0.1700679304261885d,left: 0.9061097912107389d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5082158602013319d,right: 0.1602255151800127d,bottom: 0.28063941492646716d,left: 0.03384165676167661d),

new NpgsqlTypes.NpgsqlBox(top: 0.6774848435020008d,right: 0.5105745795686354d,bottom: 0.04249032113806506d,left: 0.22034914154827612d),

new NpgsqlTypes.NpgsqlBox(top: 0.7846597337354818d,right: 0.521850544111003d,bottom: 0.6414961631671098d,left: 0.4555957600409861d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6629797108874173d,right: 0.38378518325156963d,bottom: 0.5507898498044109d,left: 0.20633867312728027d),

new NpgsqlTypes.NpgsqlBox(top: 0.950838523660674d,right: 0.7575630461554259d,bottom: 0.0946826341178737d,left: 0.4566153545428273d),

new NpgsqlTypes.NpgsqlBox(top: 0.45043083877659895d,right: 0.5223937471555258d,bottom: 0.37491206720177306d,left: 0.017051835179309194d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4979792908843319d,right: 0.9299281571862109d,bottom: 0.0858964438777634d,left: 0.6791214065511235d),

new NpgsqlTypes.NpgsqlBox(top: 0.37184899050937426d,right: 0.8911880832760986d,bottom: 0.2410148338031497d,left: 0.5910260337056917d),

new NpgsqlTypes.NpgsqlBox(top: 0.5971300462226782d,right: 0.81268231132912d,bottom: 0.09270390321150412d,left: 0.4398554279630271d),

new NpgsqlTypes.NpgsqlBox(top: 0.8842634049767105d,right: 0.5117155086484132d,bottom: 0.09556563979740074d,left: 0.12299304573163228d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2022595253335021d,right: 0.24047560662029255d,bottom: 0.12946015609019468d,left: 0.03737924195140896d),

new NpgsqlTypes.NpgsqlBox(top: 0.15222259105746516d,right: 0.38608621258429066d,bottom: 0.14926764804806625d,left: 0.20455756377975354d),

new NpgsqlTypes.NpgsqlBox(top: 0.9463624131807704d,right: 0.403590685938914d,bottom: 0.7326970530532095d,left: 0.39053025219644644d),

new NpgsqlTypes.NpgsqlBox(top: 0.9737216429427394d,right: 0.9156808185944172d,bottom: 0.4823328617132985d,left: 0.6952661535215355d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7538564928090883d,right: 0.9826226470718148d,bottom: 0.007919430870168997d,left: 0.46109201012877443d),

new NpgsqlTypes.NpgsqlBox(top: 0.46316194640835484d,right: 0.9497459015656139d,bottom: 0.31188005356231174d,left: 0.8886523623953047d),

new NpgsqlTypes.NpgsqlBox(top: 0.9936466158335554d,right: 0.9506961954396682d,bottom: 0.8259704702704369d,left: 0.12460186532012418d),

new NpgsqlTypes.NpgsqlBox(top: 0.9296095978497321d,right: 0.9550151191262324d,bottom: 0.9015514361868446d,left: 0.9389324291820188d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7001253356232685d,right: 0.722104542222233d,bottom: 0.4201554156056786d,left: 0.35295179310684754d),

new NpgsqlTypes.NpgsqlBox(top: 0.8948139124402693d,right: 0.8406601173439798d,bottom: 0.4763678852827865d,left: 0.4236490285672022d),

new NpgsqlTypes.NpgsqlBox(top: 0.4698613242527385d,right: 0.9984750956192556d,bottom: 0.345957855188337d,left: 0.2802808294709356d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9749074530805943d,right: 0.804546070904491d,bottom: 0.3399267407143861d,left: 0.6976771374979309d),

new NpgsqlTypes.NpgsqlBox(top: 0.4265872160177604d,right: 0.8913885495135814d,bottom: 0.26252212986204615d,left: 0.09537574320425513d),

new NpgsqlTypes.NpgsqlBox(top: 0.9957478998231301d,right: 0.8752138689117758d,bottom: 0.8327032766050818d,left: 0.6537632313088227d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3426842720123857d,right: 0.3690111777602907d,bottom: 0.16930260759718285d,left: 0.1297666208036926d),

new NpgsqlTypes.NpgsqlBox(top: 0.7677698860998674d,right: 0.8921169390749623d,bottom: 0.5551388522451681d,left: 0.613390915854602d),

new NpgsqlTypes.NpgsqlBox(top: 0.7821862238685837d,right: 0.11642703812329946d,bottom: 0.48097984631741353d,left: 0.04701885249588811d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7530087183855746d,right: 0.8663502717758617d,bottom: 0.08122194815458461d,left: 0.18434110342583976d),

new NpgsqlTypes.NpgsqlBox(top: 0.4359035569102949d,right: 0.559553683924168d,bottom: 0.05519561844118859d,left: 0.30207522590518077d),

new NpgsqlTypes.NpgsqlBox(top: 0.5219620220820339d,right: 0.14284434278870684d,bottom: 0.19572556913631256d,left: 0.06430325803471748d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7377928683583015d,right: 0.9880453806982905d,bottom: 0.7302146626183921d,left: 0.019370793830043254d),

new NpgsqlTypes.NpgsqlBox(top: 0.4599875792991823d,right: 0.9831619261935644d,bottom: 0.07307455791954076d,left: 0.6269749353583451d),

new NpgsqlTypes.NpgsqlBox(top: 0.4309549074023853d,right: 0.6929974853907012d,bottom: 0.2756798378977805d,left: 0.20856408692735573d),

new NpgsqlTypes.NpgsqlBox(top: 0.5416728084638311d,right: 0.9871331329045939d,bottom: 0.42578080222993575d,left: 0.4742676122448741d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.976162860075075d,right: 0.9575322318006403d,bottom: 0.8065273052349748d,left: 0.5127434281908217d),

new NpgsqlTypes.NpgsqlBox(top: 0.9634947485040636d,right: 0.672745163617896d,bottom: 0.46742767345745684d,left: 0.3916609378215956d),

new NpgsqlTypes.NpgsqlBox(top: 0.5694401672261312d,right: 0.5338255495682501d,bottom: 0.06104330890179266d,left: 0.07859873432903663d),

new NpgsqlTypes.NpgsqlBox(top: 0.6411852461692462d,right: 0.9885971081410418d,bottom: 0.19041166769919304d,left: 0.9847700473057645d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6273993774700463d,right: 0.5908394917458147d,bottom: 0.558027912597353d,left: 0.12845286862634064d),

new NpgsqlTypes.NpgsqlBox(top: 0.4481588659074174d,right: 0.9700917213426564d,bottom: 0.34940629039357707d,left: 0.9026141973752544d),

new NpgsqlTypes.NpgsqlBox(top: 0.2462882145149341d,right: 0.32121591716840925d,bottom: 0.035236420120159706d,left: 0.04805328399787179d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5422411600867456d,right: 0.8871255987296622d,bottom: 0.26618678741109514d,left: 0.6735914006872832d),

new NpgsqlTypes.NpgsqlBox(top: 0.4611871794762269d,right: 0.8297833612760194d,bottom: 0.2007148603106278d,left: 0.21774188593093802d),

new NpgsqlTypes.NpgsqlBox(top: 0.9991096931234651d,right: 0.47396546584263055d,bottom: 0.4846112340532509d,left: 0.05575317942187619d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8602103857622733d,right: 0.901589657474111d,bottom: 0.6724233114069199d,left: 0.41807048338544617d),

new NpgsqlTypes.NpgsqlBox(top: 0.9857220036662165d,right: 0.6685510451941891d,bottom: 0.030967363339463927d,left: 0.05300599919139559d),

new NpgsqlTypes.NpgsqlBox(top: 0.765745611765421d,right: 0.5790562730986489d,bottom: 0.16124164153567155d,left: 0.14773165072804495d),

new NpgsqlTypes.NpgsqlBox(top: 0.667889097734449d,right: 0.6464182682204724d,bottom: 0.27080705052732956d,left: 0.6040625689312922d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4318606748471939d,right: 0.6048153611778582d,bottom: 0.02463432030881396d,left: 0.37483695815173435d),

new NpgsqlTypes.NpgsqlBox(top: 0.8377728227969179d,right: 0.9609307922971516d,bottom: 0.6691658153292985d,left: 0.8944889894749037d),

new NpgsqlTypes.NpgsqlBox(top: 0.41023869249522904d,right: 0.8435792744853928d,bottom: 0.3896828396810095d,left: 0.5737581141042041d),

new NpgsqlTypes.NpgsqlBox(top: 0.8497567586024974d,right: 0.6950983908769042d,bottom: 0.21261827915079146d,left: 0.4366396397200428d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8774045925125458d,right: 0.4016345739194642d,bottom: 0.0581524498867404d,left: 0.08071593849192527d),

new NpgsqlTypes.NpgsqlBox(top: 0.4567607155589035d,right: 0.7031088104731986d,bottom: 0.3218788302950494d,left: 0.45372995440402697d),

new NpgsqlTypes.NpgsqlBox(top: 0.9838327309329967d,right: 0.9251338622815969d,bottom: 0.35171414975583126d,left: 0.5100372332804847d),

new NpgsqlTypes.NpgsqlBox(top: 0.748333316312242d,right: 0.08289232129124624d,bottom: 0.36760887992396374d,left: 0.07092668558575521d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.16967523240131843d,right: 0.5196353732867288d,bottom: 0.16870580924901046d,left: 0.005268338922713167d),

new NpgsqlTypes.NpgsqlBox(top: 0.8119810932921913d,right: 0.5632711610788688d,bottom: 0.36205602817294247d,left: 0.5358352444430368d),

new NpgsqlTypes.NpgsqlBox(top: 0.844928325696599d,right: 0.43467573241235735d,bottom: 0.20057620711811908d,left: 0.18532910316817064d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9453778845797272d,right: 0.8986662156449041d,bottom: 0.10279758525422789d,left: 0.1883548490753496d),

new NpgsqlTypes.NpgsqlBox(top: 0.5541428970910157d,right: 0.7217479688064986d,bottom: 0.0659754516890092d,left: 0.1998586122457282d),

new NpgsqlTypes.NpgsqlBox(top: 0.7708077674082009d,right: 0.8707704557141049d,bottom: 0.40660251558204263d,left: 0.6203441510544057d),

new NpgsqlTypes.NpgsqlBox(top: 0.8039972648616998d,right: 0.8435754167457662d,bottom: 0.6092579909822464d,left: 0.06970879322121437d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8547197858716805d,right: 0.8199876406509395d,bottom: 0.2719473632059072d,left: 0.1469107080126768d),

new NpgsqlTypes.NpgsqlBox(top: 0.7558088712451522d,right: 0.19386883383847475d,bottom: 0.3672801605501391d,left: 0.11718756098585914d),

new NpgsqlTypes.NpgsqlBox(top: 0.4879337212513787d,right: 0.8119695060343701d,bottom: 0.02401163707977949d,left: 0.2772318467607954d),

new NpgsqlTypes.NpgsqlBox(top: 0.7437261012662446d,right: 0.8396365765191912d,bottom: 0.06426003395299285d,left: 0.5209185715405664d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.40698078857032305d,right: 0.1981978273395908d,bottom: 0.3512923393703995d,left: 0.16133243437371592d),

new NpgsqlTypes.NpgsqlBox(top: 0.6495177391993489d,right: 0.4240243446541464d,bottom: 0.553109293170766d,left: 0.04226554988079256d),

new NpgsqlTypes.NpgsqlBox(top: 0.7569636035100502d,right: 0.3898832330382296d,bottom: 0.17440413064895133d,left: 0.12593558260999926d),

new NpgsqlTypes.NpgsqlBox(top: 0.20117873040725764d,right: 0.7459870585255418d,bottom: 0.1970083232720855d,left: 0.15951215127644802d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9239865053646771d,right: 0.8429220236219033d,bottom: 0.30580719638060627d,left: 0.3345666409740957d),

new NpgsqlTypes.NpgsqlBox(top: 0.5272273423645603d,right: 0.6522944017261775d,bottom: 0.4881178600669194d,left: 0.04096584135400305d),

new NpgsqlTypes.NpgsqlBox(top: 0.5235883349886092d,right: 0.4903987734990244d,bottom: 0.07192009429450064d,left: 0.16914986942452626d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9272603809115809d,right: 0.6958746193363053d,bottom: 0.8842625005622584d,left: 0.17311459216609282d),

new NpgsqlTypes.NpgsqlBox(top: 0.4073263788391869d,right: 0.7922546888805485d,bottom: 0.34664196282230575d,left: 0.08280086291213828d),

new NpgsqlTypes.NpgsqlBox(top: 0.8644110014593163d,right: 0.6517184297117518d,bottom: 0.1929514107383986d,left: 0.5145307527425823d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9960152777565745d,right: 0.7209195681669067d,bottom: 0.48172698046410933d,left: 0.36008880011457833d),

new NpgsqlTypes.NpgsqlBox(top: 0.5383609147712156d,right: 0.6335359037724964d,bottom: 0.14279326435055772d,left: 0.6044923552672066d),

new NpgsqlTypes.NpgsqlBox(top: 0.9979352580803896d,right: 0.9844290311967496d,bottom: 0.18416372055371666d,left: 0.7624443677517192d),

new NpgsqlTypes.NpgsqlBox(top: 0.6914157370324974d,right: 0.9797534804697153d,bottom: 0.08827181860504973d,left: 0.14441312710866916d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9879210788704403d,right: 0.8405185302448551d,bottom: 0.08997044002225052d,left: 0.16923922047352224d),

new NpgsqlTypes.NpgsqlBox(top: 0.9377766461295398d,right: 0.1087707301579024d,bottom: 0.9229217971358183d,left: 0.030335785132074355d),

new NpgsqlTypes.NpgsqlBox(top: 0.7395944523961643d,right: 0.797309204330349d,bottom: 0.29232499099725895d,left: 0.6455846016954165d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8884948101117126d,right: 0.5261818606889376d,bottom: 0.386810431635765d,left: 0.2832533282660933d),

new NpgsqlTypes.NpgsqlBox(top: 0.18466454101270735d,right: 0.8624048931953634d,bottom: 0.00655815269097848d,left: 0.3034182425542369d),

new NpgsqlTypes.NpgsqlBox(top: 0.9668764459825407d,right: 0.6264101008317449d,bottom: 0.6730138966631631d,left: 0.06199808999836964d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3768653643693829d,right: 0.5331200289908783d,bottom: 0.21453569442739684d,left: 0.5190589691762167d),

new NpgsqlTypes.NpgsqlBox(top: 0.48833915204773815d,right: 0.9907425008686945d,bottom: 0.05661503337877172d,left: 0.3856957076376728d),

new NpgsqlTypes.NpgsqlBox(top: 0.747657844607537d,right: 0.4477592502376522d,bottom: 0.2337186618836148d,left: 0.2237954305969072d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6506343418100416d,right: 0.43137720984253525d,bottom: 0.12063851806760495d,left: 0.2861316370096795d),

new NpgsqlTypes.NpgsqlBox(top: 0.3104298436329407d,right: 0.2670688317739689d,bottom: 0.022051423424708783d,left: 0.25340975902237306d),

new NpgsqlTypes.NpgsqlBox(top: 0.2733391292594196d,right: 0.9093372477765224d,bottom: 0.19813747362211076d,left: 0.8616003553628955d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6889215302943951d,right: 0.26282151370657303d,bottom: 0.0008069838125003281d,left: 0.12042062313089907d),

new NpgsqlTypes.NpgsqlBox(top: 0.8571888101408436d,right: 0.882309791433804d,bottom: 0.5395260495658295d,left: 0.4446039891118807d),

new NpgsqlTypes.NpgsqlBox(top: 0.9484931310192728d,right: 0.5673703056578716d,bottom: 0.2692188681646662d,left: 0.2249092058032438d),

new NpgsqlTypes.NpgsqlBox(top: 0.9488165854186115d,right: 0.5462284148785727d,bottom: 0.4391815779080597d,left: 0.016007179792690396d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8495019610401574d,right: 0.402103536793468d,bottom: 0.4146232197071408d,left: 0.1275828113722306d),

new NpgsqlTypes.NpgsqlBox(top: 0.5080292632114668d,right: 0.974255436687194d,bottom: 0.46744152241662684d,left: 0.2028777751286056d),

new NpgsqlTypes.NpgsqlBox(top: 0.1088189577063784d,right: 0.4857818569849328d,bottom: 0.002725769907729103d,left: 0.17819061534601388d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.549278250585127d,right: 0.18119733133506832d,bottom: 0.5383624566275604d,left: 0.16288104617520727d),

new NpgsqlTypes.NpgsqlBox(top: 0.8665748085567181d,right: 0.2147557209389832d,bottom: 0.2774967363594917d,left: 0.107188396009253d),

new NpgsqlTypes.NpgsqlBox(top: 0.6050494656414083d,right: 0.8996151161502657d,bottom: 0.37092319866243273d,left: 0.0959006519579112d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.96469398614392d,right: 0.4234061249524854d,bottom: 0.5950004840635013d,left: 0.29691448155829037d),

new NpgsqlTypes.NpgsqlBox(top: 0.18724084556344656d,right: 0.6729833641223923d,bottom: 0.08942395541242742d,left: 0.46946326280737527d),

new NpgsqlTypes.NpgsqlBox(top: 0.4101189936712283d,right: 0.5403616154940031d,bottom: 0.12613114923375213d,left: 0.29379431835975056d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9228896015423735d,right: 0.18364173731474542d,bottom: 0.04403274386072509d,left: 0.09703585929505654d),

new NpgsqlTypes.NpgsqlBox(top: 0.9469238419836014d,right: 0.9722828147982578d,bottom: 0.31350181574336344d,left: 0.10398478417054202d),

new NpgsqlTypes.NpgsqlBox(top: 0.8528713214455566d,right: 0.2815906787103968d,bottom: 0.464498760926636d,left: 0.11358131246678316d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.982422718035846d,right: 0.8231117572443103d,bottom: 0.3450439517564927d,left: 0.6297675656895775d),

new NpgsqlTypes.NpgsqlBox(top: 0.3713858418113666d,right: 0.9671799473062663d,bottom: 0.13258932798339207d,left: 0.2095738468287046d),

new NpgsqlTypes.NpgsqlBox(top: 0.9960912096277642d,right: 0.4968419448775586d,bottom: 0.6804104574654366d,left: 0.30365505874463505d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1807990837455672d,right: 0.3375314792507539d,bottom: 0.04009988453601143d,left: 0.07936893282494684d),

new NpgsqlTypes.NpgsqlBox(top: 0.39824018297460473d,right: 0.5815586184514572d,bottom: 0.04262531795479518d,left: 0.11455122877081714d),

new NpgsqlTypes.NpgsqlBox(top: 0.8291763935852604d,right: 0.9109763593945447d,bottom: 0.79866891299953d,left: 0.3847975431146139d),

new NpgsqlTypes.NpgsqlBox(top: 0.4697133647923667d,right: 0.42159246975207954d,bottom: 0.28457056594267516d,left: 0.027491394087183818d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7617986758349905d,right: 0.5078005349745763d,bottom: 0.07083433438486453d,left: 0.18545767557584691d),

new NpgsqlTypes.NpgsqlBox(top: 0.7588234098211446d,right: 0.5159360810995233d,bottom: 0.27230039551425667d,left: 0.48342991631535903d),

new NpgsqlTypes.NpgsqlBox(top: 0.894922499708786d,right: 0.7177530022361966d,bottom: 0.7605421796422396d,left: 0.7070604842955404d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8206169938592559d,right: 0.7287870436309434d,bottom: 0.6150432240633823d,left: 0.4475341972156618d),

new NpgsqlTypes.NpgsqlBox(top: 0.9467595672102233d,right: 0.5992220054459608d,bottom: 0.3554616075027901d,left: 0.043312644205778406d),

new NpgsqlTypes.NpgsqlBox(top: 0.6588965182177519d,right: 0.9172088231100382d,bottom: 0.412572109066042d,left: 0.5578316174578875d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4905111349174657d,right: 0.8146044678768011d,bottom: 0.399946815280656d,left: 0.2298080896736613d),

new NpgsqlTypes.NpgsqlBox(top: 0.9943193476780636d,right: 0.9616683816247513d,bottom: 0.9371961432787598d,left: 0.8805710352355149d),

new NpgsqlTypes.NpgsqlBox(top: 0.6128691225777766d,right: 0.9954739708216284d,bottom: 0.14667146865432068d,left: 0.5047028753957986d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7372455345829464d,right: 0.19032799251910915d,bottom: 0.6305669861824481d,left: 0.07499117677574774d),

new NpgsqlTypes.NpgsqlBox(top: 0.2809281179660079d,right: 0.31576420306376674d,bottom: 0.09644054068655428d,left: 0.14036315077089034d),

new NpgsqlTypes.NpgsqlBox(top: 0.8854707327469764d,right: 0.2703019577694188d,bottom: 0.5171136811045476d,left: 0.12081396744653783d),

new NpgsqlTypes.NpgsqlBox(top: 0.7177990754518738d,right: 0.1684661437240974d,bottom: 0.18175720027400855d,left: 0.1394791365975856d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4422899073810168d,right: 0.49010831483288375d,bottom: 0.22265110582810432d,left: 0.15337142797553183d),

new NpgsqlTypes.NpgsqlBox(top: 0.98044423108446d,right: 0.811209852574879d,bottom: 0.04186717076645741d,left: 0.7914308253993779d),

new NpgsqlTypes.NpgsqlBox(top: 0.8534076228480572d,right: 0.5968492208151728d,bottom: 0.41229112861077166d,left: 0.11263570396278433d),

new NpgsqlTypes.NpgsqlBox(top: 0.8307891439022709d,right: 0.7562243525835937d,bottom: 0.7976041554276954d,left: 0.5916877951339655d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45024161215071357d,right: 0.8894898321029935d,bottom: 0.3343687160100317d,left: 0.049251527746818735d),

new NpgsqlTypes.NpgsqlBox(top: 0.4813222061880966d,right: 0.15511890405406792d,bottom: 0.17409048949331773d,left: 0.10441633717819787d),

new NpgsqlTypes.NpgsqlBox(top: 0.8280916475673342d,right: 0.8805923601899073d,bottom: 0.31322462083814984d,left: 0.35889262730960036d),

new NpgsqlTypes.NpgsqlBox(top: 0.36720820037888946d,right: 0.6468554989012236d,bottom: 0.034869515657359296d,left: 0.19147575551536056d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5185906106675248d,right: 0.6880227099953983d,bottom: 0.3567099999229999d,left: 0.08053630516999455d),

new NpgsqlTypes.NpgsqlBox(top: 0.22253549948166673d,right: 0.8104524805500363d,bottom: 0.07175019710677843d,left: 0.6036093171126483d),

new NpgsqlTypes.NpgsqlBox(top: 0.8446422563597384d,right: 0.8923888122518694d,bottom: 0.7258293064264918d,left: 0.6731956746411241d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6956371474258918d,right: 0.36789399076057794d,bottom: 0.48049491464997185d,left: 0.10400410635496815d),

new NpgsqlTypes.NpgsqlBox(top: 0.5120503978001036d,right: 0.9171264448046806d,bottom: 0.15164956033125687d,left: 0.41813811364839926d),

new NpgsqlTypes.NpgsqlBox(top: 0.5935737905984046d,right: 0.7781961104220307d,bottom: 0.26108793484860804d,left: 0.3126540753133503d),

new NpgsqlTypes.NpgsqlBox(top: 0.9372004156569201d,right: 0.5202548084350301d,bottom: 0.34671617350077066d,left: 0.0706471159978096d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9795752218128261d,right: 0.6687612431978803d,bottom: 0.10854448256786275d,left: 0.5927664555760936d),

new NpgsqlTypes.NpgsqlBox(top: 0.9871418415011263d,right: 0.6582278356948146d,bottom: 0.3335031893722692d,left: 0.00801052068883723d),

new NpgsqlTypes.NpgsqlBox(top: 0.6714851711598063d,right: 0.5215133698162896d,bottom: 0.09080087622203026d,left: 0.3479178714397698d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.805896945927058d,right: 0.7007746213984728d,bottom: 0.6455661367247514d,left: 0.48051802715258984d),

new NpgsqlTypes.NpgsqlBox(top: 0.4019022822762164d,right: 0.6858190548767621d,bottom: 0.11222776029435111d,left: 0.06671978433922732d),

new NpgsqlTypes.NpgsqlBox(top: 0.2673920354522753d,right: 0.2720956516543309d,bottom: 0.08696693068431782d,left: 0.24551449347357457d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9986725771770816d,right: 0.6954273225019587d,bottom: 0.5025826560269941d,left: 0.033379233245618756d),

new NpgsqlTypes.NpgsqlBox(top: 0.8662487304039143d,right: 0.6504353574234336d,bottom: 0.4239756785312597d,left: 0.14462344533450933d),

new NpgsqlTypes.NpgsqlBox(top: 0.9718089498817675d,right: 0.40362140289810244d,bottom: 0.0523098886916068d,left: 0.3072870646172011d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8232692501431447d,right: 0.7009109180492793d,bottom: 0.469366278579457d,left: 0.16402962701190615d),

new NpgsqlTypes.NpgsqlBox(top: 0.35285439944781183d,right: 0.3544820493464339d,bottom: 0.1230940433001464d,left: 0.33333610976798067d),

new NpgsqlTypes.NpgsqlBox(top: 0.2844106241939923d,right: 0.9363332916159175d,bottom: 0.19440977756221778d,left: 0.4456795543818872d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6218165492812018d,right: 0.10340112118433842d,bottom: 0.6190227595464575d,left: 0.08368272078538919d),

new NpgsqlTypes.NpgsqlBox(top: 0.6466923812832039d,right: 0.8004415368703015d,bottom: 0.28158377430173354d,left: 0.7778822501919785d),

new NpgsqlTypes.NpgsqlBox(top: 0.46632401617809205d,right: 0.9306499185662424d,bottom: 0.1342479731426539d,left: 0.7632472543109031d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1460285517707729d,right: 0.9188282392259121d,bottom: 0.13599125053273042d,left: 0.7632702817951638d),

new NpgsqlTypes.NpgsqlBox(top: 0.3215199986926618d,right: 0.906760635350706d,bottom: 0.31156862917114103d,left: 0.3773658212941362d),

new NpgsqlTypes.NpgsqlBox(top: 0.1208550770313842d,right: 0.8791770900470378d,bottom: 0.10870549502233362d,left: 0.29877781125287795d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49562198616529496d,right: 0.9249861765839615d,bottom: 0.40813302697928466d,left: 0.8114205230128517d),

new NpgsqlTypes.NpgsqlBox(top: 0.7789855239898443d,right: 0.808250546646547d,bottom: 0.005737049311361875d,left: 0.27033672455176716d),

new NpgsqlTypes.NpgsqlBox(top: 0.55128591446534d,right: 0.9955596723916549d,bottom: 0.098004562063152d,left: 0.9435145710439256d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5956849854539371d,right: 0.8042809955275836d,bottom: 0.3516719607494895d,left: 0.615279685505788d),

new NpgsqlTypes.NpgsqlBox(top: 0.7313646156468842d,right: 0.34191938287619716d,bottom: 0.5692192433826274d,left: 0.02612661908989644d),

new NpgsqlTypes.NpgsqlBox(top: 0.5714752633468311d,right: 0.49388161519108276d,bottom: 0.5647189741353512d,left: 0.057840547604948056d),

new NpgsqlTypes.NpgsqlBox(top: 0.885509154497537d,right: 0.6536993514398883d,bottom: 0.15220757856788736d,left: 0.05273451842935506d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7897462143666711d,right: 0.9767479556784474d,bottom: 0.1425344297674106d,left: 0.37349540054335195d),

new NpgsqlTypes.NpgsqlBox(top: 0.46603147308298065d,right: 0.19875989034153163d,bottom: 0.1387444928636531d,left: 0.025756423883579127d),

new NpgsqlTypes.NpgsqlBox(top: 0.5605039302817468d,right: 0.8151196011539634d,bottom: 0.22942909932435374d,left: 0.5458884810652557d),

new NpgsqlTypes.NpgsqlBox(top: 0.947228108615978d,right: 0.7387628410642421d,bottom: 0.17671808143478218d,left: 0.33621571881151513d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.14363928030248307d,right: 0.1790706638804368d,bottom: 0.035352716004919404d,left: 0.04343157962573163d),

new NpgsqlTypes.NpgsqlBox(top: 0.9689478431629218d,right: 0.8428799257631631d,bottom: 0.7296447216936744d,left: 0.21017661622328143d),

new NpgsqlTypes.NpgsqlBox(top: 0.6349037285059866d,right: 0.7646082734844003d,bottom: 0.4890451653700514d,left: 0.17774468896502282d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4848339919693312d,right: 0.8209200650953222d,bottom: 0.09025529585138459d,left: 0.1394603750469171d),

new NpgsqlTypes.NpgsqlBox(top: 0.9883507599486481d,right: 0.8826497114385115d,bottom: 0.29495285797051496d,left: 0.864568120017416d),

new NpgsqlTypes.NpgsqlBox(top: 0.9300268025871998d,right: 0.9503738964496521d,bottom: 0.48554195294101443d,left: 0.2135756939228941d),

new NpgsqlTypes.NpgsqlBox(top: 0.9954396363527966d,right: 0.8529168024692412d,bottom: 0.35058381817720663d,left: 0.46166907742239316d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.586897979264752d,right: 0.5224243526774651d,bottom: 0.2378997019862913d,left: 0.2138932055975511d),

new NpgsqlTypes.NpgsqlBox(top: 0.923129321039701d,right: 0.7789448577521525d,bottom: 0.07326640089201908d,left: 0.2775421825660216d),

new NpgsqlTypes.NpgsqlBox(top: 0.7233628227765737d,right: 0.2655650785680086d,bottom: 0.2262517313690715d,left: 0.13129117300469795d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8301588593947344d,right: 0.5566502992627292d,bottom: 0.7335688834239282d,left: 0.18163824909852921d),

new NpgsqlTypes.NpgsqlBox(top: 0.5317159890607156d,right: 0.6482331638406592d,bottom: 0.47117111235354103d,left: 0.5078088488880019d),

new NpgsqlTypes.NpgsqlBox(top: 0.3696987981050729d,right: 0.6493905241413698d,bottom: 0.18857825377288562d,left: 0.5645738800613116d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4962414519290813d,right: 0.6814864735490721d,bottom: 0.22193736523963492d,left: 0.31555279055429575d),

new NpgsqlTypes.NpgsqlBox(top: 0.6179533552565197d,right: 0.8846664893691811d,bottom: 0.4403945753836458d,left: 0.11434445008718341d),

new NpgsqlTypes.NpgsqlBox(top: 0.8712457209847276d,right: 0.6669113485898593d,bottom: 0.06026020690508882d,left: 0.15439802931950775d),

new NpgsqlTypes.NpgsqlBox(top: 0.6417192786118255d,right: 0.4875534687552686d,bottom: 0.055001107988217335d,left: 0.1357327106568893d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6056645697539536d,right: 0.742559048393465d,bottom: 0.5081070484153464d,left: 0.1891077756936772d),

new NpgsqlTypes.NpgsqlBox(top: 0.6603254898660033d,right: 0.6013642985399374d,bottom: 0.0029448712148936185d,left: 0.027204468225836997d),

new NpgsqlTypes.NpgsqlBox(top: 0.5490833678671483d,right: 0.798661740390171d,bottom: 0.1560748325023309d,left: 0.24951254995738126d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6367486366918496d,right: 0.5515187501740892d,bottom: 0.11501963709147722d,left: 0.2436784997193694d),

new NpgsqlTypes.NpgsqlBox(top: 0.45519672994415106d,right: 0.7970177344794395d,bottom: 0.35564131599999993d,left: 0.6822414252158195d),

new NpgsqlTypes.NpgsqlBox(top: 0.8590754727859292d,right: 0.8227795271581632d,bottom: 0.5183729627460638d,left: 0.6555409740824376d),

new NpgsqlTypes.NpgsqlBox(top: 0.6592409015664732d,right: 0.9005159878729849d,bottom: 0.4152814190356431d,left: 0.005069175298670792d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.822479065698627d,right: 0.87405169436966d,bottom: 0.039544521401670085d,left: 0.02268882611863232d),

new NpgsqlTypes.NpgsqlBox(top: 0.866057525723939d,right: 0.8100236985745207d,bottom: 0.4610773602325089d,left: 0.6758665030201916d),

new NpgsqlTypes.NpgsqlBox(top: 0.710563469238661d,right: 0.35967966156119047d,bottom: 0.10152273787524824d,left: 0.23743467064124135d),

new NpgsqlTypes.NpgsqlBox(top: 0.7935932879043234d,right: 0.8537746419677237d,bottom: 0.6346961386605436d,left: 0.39000878519541027d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7560107265566872d,right: 0.9604648021487974d,bottom: 0.6051041220955723d,left: 0.19720457100391153d),

new NpgsqlTypes.NpgsqlBox(top: 0.9587133338658237d,right: 0.7199532824486481d,bottom: 0.06046484294735732d,left: 0.008812966608449102d),

new NpgsqlTypes.NpgsqlBox(top: 0.9282139961373409d,right: 0.773551019529998d,bottom: 0.634883790557992d,left: 0.5284019026175829d),

new NpgsqlTypes.NpgsqlBox(top: 0.6424822697944317d,right: 0.5858099261830528d,bottom: 0.4245073067220495d,left: 0.11291191430704617d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9749819058085559d,right: 0.7904819648076747d,bottom: 0.701335676943594d,left: 0.35709835926573563d),

new NpgsqlTypes.NpgsqlBox(top: 0.35105381531947544d,right: 0.8430518789454287d,bottom: 0.22467014555473286d,left: 0.12174411281250375d),

new NpgsqlTypes.NpgsqlBox(top: 0.84829864782376d,right: 0.22080248366491761d,bottom: 0.26889705295491584d,left: 0.12830106333675262d),

new NpgsqlTypes.NpgsqlBox(top: 0.37140909965249935d,right: 0.6248777544423906d,bottom: 0.043127820652632654d,left: 0.4868631814999287d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4915385964869482d,right: 0.8905068061857536d,bottom: 0.17946159715741838d,left: 0.38663320617609664d),

new NpgsqlTypes.NpgsqlBox(top: 0.7482196075075045d,right: 0.7884640179821302d,bottom: 0.74579768157097d,left: 0.5696294100483424d),

new NpgsqlTypes.NpgsqlBox(top: 0.8347065753237357d,right: 0.5079272359705372d,bottom: 0.3977707696781856d,left: 0.3410474938045368d),

new NpgsqlTypes.NpgsqlBox(top: 0.511620364188323d,right: 0.6811944604818281d,bottom: 0.43160694395137655d,left: 0.15309509307157487d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9519554274192301d,right: 0.41525367295454196d,bottom: 0.7857560585945327d,left: 0.0052188498640717285d),

new NpgsqlTypes.NpgsqlBox(top: 0.5066453282052732d,right: 0.9460893054272383d,bottom: 0.08532642863213469d,left: 0.6550182504400033d),

new NpgsqlTypes.NpgsqlBox(top: 0.4903403310764035d,right: 0.89804862194653d,bottom: 0.35212440482891516d,left: 0.5081177188492894d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4953656428320976d,right: 0.35310937398273967d,bottom: 0.017205685792791692d,left: 0.18678257942936383d),

new NpgsqlTypes.NpgsqlBox(top: 0.11373610369899334d,right: 0.46397553221051446d,bottom: 0.03084756503196384d,left: 0.4306860169923372d),

new NpgsqlTypes.NpgsqlBox(top: 0.7074036478698159d,right: 0.17841119317901244d,bottom: 0.599224989555915d,left: 0.048120605038439845d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.769104544631921d,right: 0.8116696746903285d,bottom: 0.16457192768617823d,left: 0.3730685229655001d),

new NpgsqlTypes.NpgsqlBox(top: 0.7973652336911691d,right: 0.35266447830670355d,bottom: 0.48243330007625784d,left: 0.21375832740342438d),

new NpgsqlTypes.NpgsqlBox(top: 0.8213264054888997d,right: 0.8549952055667528d,bottom: 0.17528942990573448d,left: 0.689918009300044d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5912665901966341d,right: 0.6746019811353376d,bottom: 0.25214669069040163d,left: 0.4356435445841157d),

new NpgsqlTypes.NpgsqlBox(top: 0.6113918321243345d,right: 0.7502965842136345d,bottom: 0.48022556881699174d,left: 0.3116949869188914d),

new NpgsqlTypes.NpgsqlBox(top: 0.800596557057622d,right: 0.7083698263526612d,bottom: 0.7685043709078818d,left: 0.020038325094296816d),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 2, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 35, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 10, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

