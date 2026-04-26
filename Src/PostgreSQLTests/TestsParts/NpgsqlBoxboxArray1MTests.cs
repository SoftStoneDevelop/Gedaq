

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9111596384407753d,right: 0.4328342292702261d,bottom: 0.5585619142935389d,left: 0.1504440893208815d),
new NpgsqlTypes.NpgsqlBox(top: 0.8758206593412797d,right: 0.3114385889302964d,bottom: 0.2764999693294088d,left: 0.05410966662009742d),
new NpgsqlTypes.NpgsqlBox(top: 0.8446734780847158d,right: 0.7483820593510898d,bottom: 0.4090773218375652d,left: 0.20644951822279412d),
new NpgsqlTypes.NpgsqlBox(top: 0.5320899544436972d,right: 0.6953850112895563d,bottom: 0.025240106214332036d,left: 0.5730955100304951d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4146379144401944d,right: 0.2980424938528836d,bottom: 0.20904348946713047d,left: 0.0745522226649894d),
new NpgsqlTypes.NpgsqlBox(top: 0.5001969913122959d,right: 0.6907016858966372d,bottom: 0.4901258481059544d,left: 0.01217366247538687d),
new NpgsqlTypes.NpgsqlBox(top: 0.7636222034515786d,right: 0.9617902039521017d,bottom: 0.26219210915138347d,left: 0.505908972973174d),
new NpgsqlTypes.NpgsqlBox(top: 0.5787805032753909d,right: 0.4720834185877345d,bottom: 0.3440691796714147d,left: 0.05002608066826475d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8773653712701585d,right: 0.6896203843315519d,bottom: 0.6100932394551619d,left: 0.6890693870479465d),
new NpgsqlTypes.NpgsqlBox(top: 0.9824608307569584d,right: 0.4120786768299559d,bottom: 0.7334382572091697d,left: 0.04098721662402938d),
new NpgsqlTypes.NpgsqlBox(top: 0.492985029392793d,right: 0.4349614962096442d,bottom: 0.370376522435811d,left: 0.31022560716706826d),
new NpgsqlTypes.NpgsqlBox(top: 0.8442421287987979d,right: 0.8996133503241979d,bottom: 0.3043763078708943d,left: 0.3875321233228892d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5976915932476201d,right: 0.5401376759941159d,bottom: 0.44656675150666025d,left: 0.3431118861986271d),
new NpgsqlTypes.NpgsqlBox(top: 0.8808282431967809d,right: 0.6603307801562096d,bottom: 0.17700314561010422d,left: 0.6564446892834699d),
new NpgsqlTypes.NpgsqlBox(top: 0.8322304669441885d,right: 0.5938047915533433d,bottom: 0.7472061126764877d,left: 0.20390473431783696d),
new NpgsqlTypes.NpgsqlBox(top: 0.49571689489704973d,right: 0.696589363436413d,bottom: 0.40761978850884595d,left: 0.034978458263700385d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7299076032911967d,right: 0.9195179844057777d,bottom: 0.008261383193023053d,left: 0.5532252761009798d),
new NpgsqlTypes.NpgsqlBox(top: 0.13444409895249232d,right: 0.9804420595135448d,bottom: 0.08879586222337854d,left: 0.3173773405793534d),
new NpgsqlTypes.NpgsqlBox(top: 0.9595491646091395d,right: 0.9715332195189987d,bottom: 0.09522452812726712d,left: 0.4575374284309852d),
new NpgsqlTypes.NpgsqlBox(top: 0.686425092392547d,right: 0.12472512211890008d,bottom: 0.45347525843734726d,left: 0.00909234917179158d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9384780094613518d,right: 0.8745015497731831d,bottom: 0.8013181140022825d,left: 0.31419068136755546d),
new NpgsqlTypes.NpgsqlBox(top: 0.7819082093917019d,right: 0.4763717677848701d,bottom: 0.23214447253544246d,left: 0.23281357252298318d),
new NpgsqlTypes.NpgsqlBox(top: 0.8405339283733061d,right: 0.6173277539679876d,bottom: 0.8258105972618234d,left: 0.549699698920314d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9357040963805715d,right: 0.7440270281012752d,bottom: 0.4636886364661441d,left: 0.05314690064235794d),
new NpgsqlTypes.NpgsqlBox(top: 0.6082422393726908d,right: 0.857047651591612d,bottom: 0.5805622461302464d,left: 0.3510255230919288d),
new NpgsqlTypes.NpgsqlBox(top: 0.12579367638873673d,right: 0.6717210935581042d,bottom: 0.04553340945486284d,left: 0.13408953121835288d),
new NpgsqlTypes.NpgsqlBox(top: 0.18081634991921125d,right: 0.47868166379305266d,bottom: 0.1474784560446194d,left: 0.07215644633251983d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7187661998836062d,right: 0.51145890426904d,bottom: 0.0838293699495043d,left: 0.1262060953081945d),
new NpgsqlTypes.NpgsqlBox(top: 0.44193854835874824d,right: 0.7951088328385819d,bottom: 0.33053341102764466d,left: 0.6527040295425376d),
new NpgsqlTypes.NpgsqlBox(top: 0.9758110395796783d,right: 0.5533669451330018d,bottom: 0.9721095543654232d,left: 0.17454236897025743d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8335143693365168d,right: 0.9660694996489493d,bottom: 0.6323683143947992d,left: 0.5119381993715177d),
new NpgsqlTypes.NpgsqlBox(top: 0.9523796782634536d,right: 0.5990147960895528d,bottom: 0.20757928515191693d,left: 0.49682769198264665d),
new NpgsqlTypes.NpgsqlBox(top: 0.8566000648254659d,right: 0.9956969311010904d,bottom: 0.2813591171571048d,left: 0.89207693503385d),
new NpgsqlTypes.NpgsqlBox(top: 0.1412936247305827d,right: 0.7463520872934833d,bottom: 0.017234774846449308d,left: 0.40599289101559743d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46667501121742616d,right: 0.6537723192724559d,bottom: 0.37551355285614774d,left: 0.19631830365055947d),
new NpgsqlTypes.NpgsqlBox(top: 0.35449181140627983d,right: 0.703606247744491d,bottom: 0.2288084434959473d,left: 0.08638358716634242d),
new NpgsqlTypes.NpgsqlBox(top: 0.7291433545440994d,right: 0.36292522722070664d,bottom: 0.2918431494997321d,left: 0.33325777752484365d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8236727158610748d,right: 0.4550785479413799d,bottom: 0.07793609293932213d,left: 0.39622669722800985d),
new NpgsqlTypes.NpgsqlBox(top: 0.87263574860044d,right: 0.6326140544925657d,bottom: 0.5034009178771337d,left: 0.177220570570645d),
new NpgsqlTypes.NpgsqlBox(top: 0.7913273954390303d,right: 0.9113018158349068d,bottom: 0.47025617509045514d,left: 0.8369593879908868d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3104710483114552d,right: 0.665799959410713d,bottom: 0.10128240550983247d,left: 0.5199859160366929d),
new NpgsqlTypes.NpgsqlBox(top: 0.9042903355805683d,right: 0.25549104290940083d,bottom: 0.6000870596286844d,left: 0.199521228828914d),
new NpgsqlTypes.NpgsqlBox(top: 0.5293116750231736d,right: 0.8382178207865304d,bottom: 0.4655527561185605d,left: 0.00028276518185488264d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7120945205078826d,right: 0.6870993413698313d,bottom: 0.4450312729204078d,left: 0.12229391455656236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9064615937880354d,right: 0.5434905265578265d,bottom: 0.15465364247950397d,left: 0.3357552435604807d),
new NpgsqlTypes.NpgsqlBox(top: 0.6671651357972508d,right: 0.9889909906368435d,bottom: 0.2753284674254488d,left: 0.9617225297563805d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7151575649969539d,right: 0.8313168219052757d,bottom: 0.5542959381269178d,left: 0.11686302425525652d),
new NpgsqlTypes.NpgsqlBox(top: 0.9902031223977003d,right: 0.49318404064727117d,bottom: 0.6828598913890598d,left: 0.4200433303717419d),
new NpgsqlTypes.NpgsqlBox(top: 0.9833706257358467d,right: 0.4591110676538833d,bottom: 0.8414769313426874d,left: 0.05865452673488869d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6227214954122651d,right: 0.8496161303849971d,bottom: 0.20336647198861257d,left: 0.49896618762371336d),
new NpgsqlTypes.NpgsqlBox(top: 0.9527533971169854d,right: 0.8643877033335999d,bottom: 0.2879610709936029d,left: 0.1986577341083835d),
new NpgsqlTypes.NpgsqlBox(top: 0.6665974098350329d,right: 0.15112285295587824d,bottom: 0.41604552934770045d,left: 0.11048322039028602d),
new NpgsqlTypes.NpgsqlBox(top: 0.2068369001117365d,right: 0.5361014134530473d,bottom: 0.11697941233289988d,left: 0.3336078119811511d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8614559435864848d,right: 0.9077855729726679d,bottom: 0.6645965459615684d,left: 0.20033795110917219d),
new NpgsqlTypes.NpgsqlBox(top: 0.878214263435187d,right: 0.9431183055872343d,bottom: 0.8736381017810415d,left: 0.3540049462717916d),
new NpgsqlTypes.NpgsqlBox(top: 0.9319170819950314d,right: 0.885315134103702d,bottom: 0.5848976640680708d,left: 0.7608628562782468d),
new NpgsqlTypes.NpgsqlBox(top: 0.6547614317056821d,right: 0.3937380694234175d,bottom: 0.05871433733547693d,left: 0.10383640971954222d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8980413737363429d,right: 0.821289697939323d,bottom: 0.6386945762462605d,left: 0.7566019727316591d),
new NpgsqlTypes.NpgsqlBox(top: 0.13065863911436848d,right: 0.41394418257051424d,bottom: 0.05200016845292399d,left: 0.040299500798483656d),
new NpgsqlTypes.NpgsqlBox(top: 0.8540346177291868d,right: 0.8843329262959325d,bottom: 0.6548035947941442d,left: 0.31211350355886935d),
new NpgsqlTypes.NpgsqlBox(top: 0.5198292769987599d,right: 0.2465163222415182d,bottom: 0.4340765978756991d,left: 0.24092405476146161d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5944690402775783d,right: 0.7246787477874341d,bottom: 0.11097317256432293d,left: 0.1361663592783341d),
new NpgsqlTypes.NpgsqlBox(top: 0.6497335938947002d,right: 0.8387632073814683d,bottom: 0.4114986644203358d,left: 0.8019427086812959d),
new NpgsqlTypes.NpgsqlBox(top: 0.9661738299036583d,right: 0.9823873454133398d,bottom: 0.765525930297263d,left: 0.5898075967691131d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7645753350548692d,right: 0.13193778151199875d,bottom: 0.027569494178747322d,left: 0.001048644766098783d),
new NpgsqlTypes.NpgsqlBox(top: 0.9444963700109041d,right: 0.5433198288213514d,bottom: 0.3606530994320589d,left: 0.09971717650431833d),
new NpgsqlTypes.NpgsqlBox(top: 0.46869605848731477d,right: 0.7907059504743637d,bottom: 0.08066320676828931d,left: 0.27966787680779936d),
new NpgsqlTypes.NpgsqlBox(top: 0.9306975618555811d,right: 0.9507362858931044d,bottom: 0.14605226478916022d,left: 0.6398514157820049d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9994141655833221d,right: 0.7519261374861564d,bottom: 0.8205076538080499d,left: 0.5189338768775409d),
new NpgsqlTypes.NpgsqlBox(top: 0.45432675985825655d,right: 0.6431764064892815d,bottom: 0.22284629341359374d,left: 0.3497330851985435d),
new NpgsqlTypes.NpgsqlBox(top: 0.6389235551025051d,right: 0.64154908896611d,bottom: 0.43623365991103413d,left: 0.46247107393433795d),
new NpgsqlTypes.NpgsqlBox(top: 0.6561536079230386d,right: 0.5125794004714678d,bottom: 0.0916941212512753d,left: 0.010687309097598963d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9633386463909733d,right: 0.6648683264200314d,bottom: 0.7625297076211307d,left: 0.09985048148758724d),
new NpgsqlTypes.NpgsqlBox(top: 0.9847024541990576d,right: 0.3928080986942776d,bottom: 0.4813422974294893d,left: 0.0646727517186847d),
new NpgsqlTypes.NpgsqlBox(top: 0.625268725294921d,right: 0.9621110233879289d,bottom: 0.07531681143370361d,left: 0.5440751548970483d),
new NpgsqlTypes.NpgsqlBox(top: 0.804822008947236d,right: 0.921215782258708d,bottom: 0.6629828722438719d,left: 0.6979790716301866d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7651728948943007d,right: 0.5476812274033545d,bottom: 0.35119497150007895d,left: 0.2685717959606715d),
new NpgsqlTypes.NpgsqlBox(top: 0.6548981855047088d,right: 0.9387870401193436d,bottom: 0.5395080814072072d,left: 0.2126857026283181d),
new NpgsqlTypes.NpgsqlBox(top: 0.8006388584372206d,right: 0.2576203327885649d,bottom: 0.040805828806490196d,left: 0.22211113495696688d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7184094198424161d,right: 0.8977053817151506d,bottom: 0.5803105281366429d,left: 0.0369769919532299d),
new NpgsqlTypes.NpgsqlBox(top: 0.9368061868020647d,right: 0.531643251300243d,bottom: 0.14365483514167143d,left: 0.4087928332772629d),
new NpgsqlTypes.NpgsqlBox(top: 0.40737996025302203d,right: 0.665409870737616d,bottom: 0.0993235786709924d,left: 0.11599559302002993d),
new NpgsqlTypes.NpgsqlBox(top: 0.4174112152106666d,right: 0.4449267100671416d,bottom: 0.25295433925113386d,left: 0.33120129469096327d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9463918294562315d,right: 0.5563102742554541d,bottom: 0.366380535677036d,left: 0.17856743860101287d),
new NpgsqlTypes.NpgsqlBox(top: 0.7281325692497088d,right: 0.3789550969796114d,bottom: 0.5143217219148684d,left: 0.3703665512182418d),
new NpgsqlTypes.NpgsqlBox(top: 0.08396912195231443d,right: 0.5061534512164879d,bottom: 0.03546504012813634d,left: 0.03033725210073568d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7742418885005531d,right: 0.5247442830031626d,bottom: 0.44135116229770666d,left: 0.08113908656281621d),
new NpgsqlTypes.NpgsqlBox(top: 0.6385454653380024d,right: 0.656773317457579d,bottom: 0.20272634919986665d,left: 0.626759811519513d),
new NpgsqlTypes.NpgsqlBox(top: 0.190183124839731d,right: 0.8357878960516723d,bottom: 0.16918124696142278d,left: 0.8168515944001765d),
new NpgsqlTypes.NpgsqlBox(top: 0.9285204744458171d,right: 0.6190065378410662d,bottom: 0.331513665271288d,left: 0.6101024153232174d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3900702593316986d,right: 0.4751413387941038d,bottom: 0.3745714843950514d,left: 0.1580930735405608d),
new NpgsqlTypes.NpgsqlBox(top: 0.8850887056337667d,right: 0.13811711860836806d,bottom: 0.4680787864879822d,left: 0.04162655034162699d),
new NpgsqlTypes.NpgsqlBox(top: 0.713133088644384d,right: 0.7148233310040171d,bottom: 0.44005444542159666d,left: 0.11666293992009913d),
new NpgsqlTypes.NpgsqlBox(top: 0.7554269257983051d,right: 0.8575996000131144d,bottom: 0.2595297109183823d,left: 0.8350283873750995d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4534217038328088d,right: 0.7426764832782818d,bottom: 0.18662291187049584d,left: 0.08716851792108216d),
new NpgsqlTypes.NpgsqlBox(top: 0.3228615512397155d,right: 0.842635408820531d,bottom: 0.01362540373469956d,left: 0.7629708433893456d),
new NpgsqlTypes.NpgsqlBox(top: 0.4243779092486498d,right: 0.42452924456729035d,bottom: 0.1884137269637587d,left: 0.06162342114384267d),
new NpgsqlTypes.NpgsqlBox(top: 0.30041538217966834d,right: 0.8850469467884178d,bottom: 0.00547493577336533d,left: 0.672425959930777d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9336326288203497d,right: 0.9127566944160609d,bottom: 0.8207398713280727d,left: 0.11751018538983149d),
new NpgsqlTypes.NpgsqlBox(top: 0.7929859755980931d,right: 0.7428828007702352d,bottom: 0.5547717499274274d,left: 0.2007664952592808d),
new NpgsqlTypes.NpgsqlBox(top: 0.5227875585315963d,right: 0.9472865512716713d,bottom: 0.10463354264945146d,left: 0.15880346830966474d),
new NpgsqlTypes.NpgsqlBox(top: 0.9789974556650092d,right: 0.48917920422838757d,bottom: 0.6721744986965783d,left: 0.187736194264423d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40369552789354046d,right: 0.3616531679250772d,bottom: 0.3754086910366573d,left: 0.2304362745958437d),
new NpgsqlTypes.NpgsqlBox(top: 0.5065044533058568d,right: 0.9954485216713966d,bottom: 0.3464792625798281d,left: 0.5731647322116747d),
new NpgsqlTypes.NpgsqlBox(top: 0.8530107653229683d,right: 0.3377928567344153d,bottom: 0.40508467634569656d,left: 0.1529888695261572d),
new NpgsqlTypes.NpgsqlBox(top: 0.9312505115317805d,right: 0.6786185085926139d,bottom: 0.28504409164701305d,left: 0.6187868699974389d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4528573785004233d,right: 0.4681244424158002d,bottom: 0.1321072072317998d,left: 0.1823380668174187d),
new NpgsqlTypes.NpgsqlBox(top: 0.9540873093147718d,right: 0.5435473663017998d,bottom: 0.16908553912759572d,left: 0.4536386512370073d),
new NpgsqlTypes.NpgsqlBox(top: 0.6027257955006969d,right: 0.7083772899179632d,bottom: 0.2876718664550105d,left: 0.33830363580598655d),
new NpgsqlTypes.NpgsqlBox(top: 0.9734933761363938d,right: 0.8476736826580932d,bottom: 0.5069194355837124d,left: 0.6475376987236433d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7117417103971463d,right: 0.5015431256523741d,bottom: 0.6669942820468521d,left: 0.2629824379340602d),
new NpgsqlTypes.NpgsqlBox(top: 0.8843208776823631d,right: 0.8908431498870507d,bottom: 0.13260260981568606d,left: 0.7975798391138746d),
new NpgsqlTypes.NpgsqlBox(top: 0.9994422272900432d,right: 0.7336520578933622d,bottom: 0.5289992406402878d,left: 0.619997813867212d),
new NpgsqlTypes.NpgsqlBox(top: 0.5135953517335425d,right: 0.404784314454822d,bottom: 0.1603844032511047d,left: 0.2848867052140406d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5545555702875659d,right: 0.23693402609392056d,bottom: 0.37433908294684837d,left: 0.2052071981617244d),
new NpgsqlTypes.NpgsqlBox(top: 0.5762513569187033d,right: 0.5938863997663771d,bottom: 0.16941086571306663d,left: 0.2247379900084565d),
new NpgsqlTypes.NpgsqlBox(top: 0.5090756323467219d,right: 0.5374613240816332d,bottom: 0.29496332117404656d,left: 0.408829245729043d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9611026443648399d,right: 0.843456000577517d,bottom: 0.7394968523056433d,left: 0.05442145195545689d),
new NpgsqlTypes.NpgsqlBox(top: 0.8129265436411304d,right: 0.7897301261409018d,bottom: 0.5263580462185801d,left: 0.590366920359015d),
new NpgsqlTypes.NpgsqlBox(top: 0.3100563981756085d,right: 0.49820116839664774d,bottom: 0.11835100560518197d,left: 0.29404295389975865d),
new NpgsqlTypes.NpgsqlBox(top: 0.8446383435668008d,right: 0.902326575784692d,bottom: 0.22691511073739745d,left: 0.33859946516409045d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.977903055717885d,right: 0.8839472260577419d,bottom: 0.2592327756763192d,left: 0.44021859141680586d),
new NpgsqlTypes.NpgsqlBox(top: 0.24626183856039674d,right: 0.23064886202613166d,bottom: 0.1041198582761853d,left: 0.00918456065546136d),
new NpgsqlTypes.NpgsqlBox(top: 0.9429144112493137d,right: 0.7312368189842333d,bottom: 0.32244941630549073d,left: 0.19812997958679412d),
new NpgsqlTypes.NpgsqlBox(top: 0.9080750626909531d,right: 0.5021311114174091d,bottom: 0.3240596246050105d,left: 0.034887546794497126d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.09004341073621625d,right: 0.937351255264483d,bottom: 0.0618616217342256d,left: 0.07477173547614302d),
new NpgsqlTypes.NpgsqlBox(top: 0.7920587812174689d,right: 0.09010111005045618d,bottom: 0.27866540074356816d,left: 0.040460308518022736d),
new NpgsqlTypes.NpgsqlBox(top: 0.9878555232987125d,right: 0.5088927649652181d,bottom: 0.26751972188251827d,left: 0.471930415021087d),
new NpgsqlTypes.NpgsqlBox(top: 0.26294950800408357d,right: 0.9330553870467352d,bottom: 0.2085385701100574d,left: 0.8059842466341353d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3496435372906329d,right: 0.793089123101799d,bottom: 0.05243787147308954d,left: 0.355014939198129d),
new NpgsqlTypes.NpgsqlBox(top: 0.971559629661734d,right: 0.9747766429022569d,bottom: 0.07235905633256179d,left: 0.0754258796031676d),
new NpgsqlTypes.NpgsqlBox(top: 0.6033988472159566d,right: 0.49860981296574614d,bottom: 0.06182771198801873d,left: 0.3434162284955491d),
new NpgsqlTypes.NpgsqlBox(top: 0.7198318564126172d,right: 0.7465483020325767d,bottom: 0.10548825696892938d,left: 0.04014651105008671d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8500737487260323d,right: 0.5048277728408667d,bottom: 0.8288612819722528d,left: 0.3792770307405142d),
new NpgsqlTypes.NpgsqlBox(top: 0.9799334078893258d,right: 0.8049795265058108d,bottom: 0.05951380815839613d,left: 0.14473816903011583d),
new NpgsqlTypes.NpgsqlBox(top: 0.4748547364154012d,right: 0.2887979861219022d,bottom: 0.180704517757584d,left: 0.1970032376176819d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8884685220675684d,right: 0.31906595784957703d,bottom: 0.16028755038992126d,left: 0.08819331418919996d),
new NpgsqlTypes.NpgsqlBox(top: 0.4422127729831561d,right: 0.508776899304803d,bottom: 0.27712263799137526d,left: 0.12039707168561065d),
new NpgsqlTypes.NpgsqlBox(top: 0.4629170808875619d,right: 0.7591360725319559d,bottom: 0.10340207233790988d,left: 0.617847042710144d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2198871794171563d,right: 0.8129012124385819d,bottom: 0.0727965192113057d,left: 0.30732310024201603d),
new NpgsqlTypes.NpgsqlBox(top: 0.5262404745944009d,right: 0.9596132384386703d,bottom: 0.2088750557179564d,left: 0.6501944975589462d),
new NpgsqlTypes.NpgsqlBox(top: 0.7737721079217945d,right: 0.8895527682935763d,bottom: 0.37209815447050454d,left: 0.5419073620724529d),
new NpgsqlTypes.NpgsqlBox(top: 0.4750154311376903d,right: 0.3376056787805565d,bottom: 0.4732857322724042d,left: 0.30901120025436335d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8504258922037572d,right: 0.7196749873489693d,bottom: 0.44165057530504714d,left: 0.5233810635307202d),
new NpgsqlTypes.NpgsqlBox(top: 0.9286305813423334d,right: 0.8591209738043747d,bottom: 0.43329946852695267d,left: 0.7926976069804184d),
new NpgsqlTypes.NpgsqlBox(top: 0.5277592894174987d,right: 0.7651733644364245d,bottom: 0.23139073385399134d,left: 0.5293198759811687d),
new NpgsqlTypes.NpgsqlBox(top: 0.15824264662288312d,right: 0.6747347234607816d,bottom: 0.14737396021484017d,left: 0.4320958508501942d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8683929447776776d,right: 0.21329289145885233d,bottom: 0.08086247764372378d,left: 0.09601101314007865d),
new NpgsqlTypes.NpgsqlBox(top: 0.8176411054860704d,right: 0.9016316609436342d,bottom: 0.7536675183691117d,left: 0.6561566804248693d),
new NpgsqlTypes.NpgsqlBox(top: 0.5283050196204236d,right: 0.4677968773596298d,bottom: 0.14138633888004248d,left: 0.3830324071345331d),
new NpgsqlTypes.NpgsqlBox(top: 0.6442189863272436d,right: 0.32219250645235176d,bottom: 0.41244378918162306d,left: 0.12995449437690354d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1428437777442294d,right: 0.7983675752540328d,bottom: 0.04086553949078242d,left: 0.787205418859936d),
new NpgsqlTypes.NpgsqlBox(top: 0.27508876619793865d,right: 0.04402628467602232d,bottom: 0.22780105707310605d,left: 0.025709217315626698d),
new NpgsqlTypes.NpgsqlBox(top: 0.7066736805441866d,right: 0.8246204365370504d,bottom: 0.0637249326511734d,left: 0.8059800004469321d),
new NpgsqlTypes.NpgsqlBox(top: 0.7398298672023925d,right: 0.7425789710263154d,bottom: 0.6187236901793721d,left: 0.12141374334186195d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7129682756063036d,right: 0.5939658967650762d,bottom: 0.15954383681882878d,left: 0.097779617429678d),
new NpgsqlTypes.NpgsqlBox(top: 0.723249697672663d,right: 0.5465801654459755d,bottom: 0.004586480866916931d,left: 0.13235057359343405d),
new NpgsqlTypes.NpgsqlBox(top: 0.295422387120553d,right: 0.9132836091496348d,bottom: 0.15248842722732459d,left: 0.2932021539743561d),
new NpgsqlTypes.NpgsqlBox(top: 0.2553331928240734d,right: 0.2850670818826434d,bottom: 0.0041947917926962175d,left: 0.231851220231728d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8841913452910681d,right: 0.21753574914845764d,bottom: 0.1294891529162322d,left: 0.006368716941318908d),
new NpgsqlTypes.NpgsqlBox(top: 0.6116561703995854d,right: 0.7526618134240987d,bottom: 0.2569953528872191d,left: 0.31966657109124796d),
new NpgsqlTypes.NpgsqlBox(top: 0.5858131647917866d,right: 0.9320743892412472d,bottom: 0.03652473650566068d,left: 0.5306193445411274d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7632330484881399d,right: 0.5774185611152451d,bottom: 0.3701765643114524d,left: 0.10848133906551793d),
new NpgsqlTypes.NpgsqlBox(top: 0.8189774512940086d,right: 0.29009961910824145d,bottom: 0.5464734176773481d,left: 0.015564567685187658d),
new NpgsqlTypes.NpgsqlBox(top: 0.9054693980923372d,right: 0.6545980417699206d,bottom: 0.6313326625831505d,left: 0.06340795953738543d),
new NpgsqlTypes.NpgsqlBox(top: 0.8969099471797961d,right: 0.7309170690814882d,bottom: 0.7897881267586511d,left: 0.34017927745906273d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8788101583057062d,right: 0.9680664484011593d,bottom: 0.6109173145339031d,left: 0.2936124338426499d),
new NpgsqlTypes.NpgsqlBox(top: 0.8475503413259563d,right: 0.9797537701149721d,bottom: 0.5348272058798009d,left: 0.3468437568559688d),
new NpgsqlTypes.NpgsqlBox(top: 0.9332223774313455d,right: 0.46338826499805363d,bottom: 0.6571357396180458d,left: 0.22693662253561997d),
new NpgsqlTypes.NpgsqlBox(top: 0.8599316994215807d,right: 0.374242940437864d,bottom: 0.4544683781690033d,left: 0.19590787053505687d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.421022229773688d,right: 0.5510336940005028d,bottom: 0.3029221818195349d,left: 0.1389246032479582d),
new NpgsqlTypes.NpgsqlBox(top: 0.7647458648722979d,right: 0.9355471108958991d,bottom: 0.35767651128626d,left: 0.8374692934510202d),
new NpgsqlTypes.NpgsqlBox(top: 0.656157900628852d,right: 0.7927275536607257d,bottom: 0.5952114325543514d,left: 0.13871547661836992d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8786349418996856d,right: 0.6177609230295766d,bottom: 0.7641748624711614d,left: 0.32695027007579813d),
new NpgsqlTypes.NpgsqlBox(top: 0.7592442273065965d,right: 0.5940356138284516d,bottom: 0.5828945980647557d,left: 0.038199682007750035d),
new NpgsqlTypes.NpgsqlBox(top: 0.26579197719882774d,right: 0.7112025265362067d,bottom: 0.16520594581828996d,left: 0.48851291349602d),
new NpgsqlTypes.NpgsqlBox(top: 0.3945127435298029d,right: 0.9904927480078006d,bottom: 0.010190987308301258d,left: 0.6664604108049506d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35329277651197666d,right: 0.8254688190067138d,bottom: 0.131742598594917d,left: 0.7946653852808819d),
new NpgsqlTypes.NpgsqlBox(top: 0.8638782303190813d,right: 0.8839588911488689d,bottom: 0.63992424917928d,left: 0.3411488011158733d),
new NpgsqlTypes.NpgsqlBox(top: 0.9241994203073991d,right: 0.42027095719892227d,bottom: 0.4544150484388001d,left: 0.23206792782145458d),
new NpgsqlTypes.NpgsqlBox(top: 0.878088989632059d,right: 0.7409287841850001d,bottom: 0.27266682778647955d,left: 0.1838465473330415d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.761971969531366d,right: 0.5583704774753491d,bottom: 0.1841770985099388d,left: 0.44223872439831025d),
new NpgsqlTypes.NpgsqlBox(top: 0.44763078802709355d,right: 0.5100964597680486d,bottom: 0.05344219336788092d,left: 0.49486674544775444d),
new NpgsqlTypes.NpgsqlBox(top: 0.9259294577412284d,right: 0.9902115731260785d,bottom: 0.23441191619827917d,left: 0.505322328753733d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4321934930284551d,right: 0.7750105995341547d,bottom: 0.3064024270146807d,left: 0.2761993228108214d),
new NpgsqlTypes.NpgsqlBox(top: 0.472050902723435d,right: 0.36573586533075886d,bottom: 0.10340512802658886d,left: 0.16156584607690294d),
new NpgsqlTypes.NpgsqlBox(top: 0.5831772925488915d,right: 0.9554845597810798d,bottom: 0.3724420218667568d,left: 0.6235059239849182d),
new NpgsqlTypes.NpgsqlBox(top: 0.15473487184801704d,right: 0.4597045377554816d,bottom: 0.1495105423715083d,left: 0.32154037752297304d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7081101124312768d,right: 0.6247162738672676d,bottom: 0.04026420552975385d,left: 0.12478214139260702d),
new NpgsqlTypes.NpgsqlBox(top: 0.4931708510109841d,right: 0.9669735382298476d,bottom: 0.21811420120452618d,left: 0.9553769659190698d),
new NpgsqlTypes.NpgsqlBox(top: 0.9514191454422364d,right: 0.34442760906216696d,bottom: 0.49272227302304505d,left: 0.27943036709965074d),
new NpgsqlTypes.NpgsqlBox(top: 0.4280380698242575d,right: 0.9756215809861648d,bottom: 0.21265298719341508d,left: 0.27097159006545335d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7174790761446955d,right: 0.8774604754358838d,bottom: 0.33566792147302604d,left: 0.4247765939325069d),
new NpgsqlTypes.NpgsqlBox(top: 0.5113931960610506d,right: 0.16753684394984902d,bottom: 0.39774472086585766d,left: 0.11655669167912608d),
new NpgsqlTypes.NpgsqlBox(top: 0.8238238851711402d,right: 0.419959563028116d,bottom: 0.07094418777394373d,left: 0.4179035821760573d),
new NpgsqlTypes.NpgsqlBox(top: 0.8117121504454272d,right: 0.6254120857963352d,bottom: 0.4127619853204523d,left: 0.0431341308438693d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4235877502472938d,right: 0.9892838830817193d,bottom: 0.16179446509293438d,left: 0.47098584337979077d),
new NpgsqlTypes.NpgsqlBox(top: 0.5710076389337753d,right: 0.7107397633721358d,bottom: 0.191110906387725d,left: 0.508014099325297d),
new NpgsqlTypes.NpgsqlBox(top: 0.6918082161540647d,right: 0.8128880723586454d,bottom: 0.05831129793487577d,left: 0.6734973242054471d),
new NpgsqlTypes.NpgsqlBox(top: 0.7905989401666218d,right: 0.34025149568312973d,bottom: 0.33088402395658667d,left: 0.2209652510257516d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8248631658662835d,right: 0.5899898459969762d,bottom: 0.04156994473105857d,left: 0.4174434770344726d),
new NpgsqlTypes.NpgsqlBox(top: 0.7473799581566393d,right: 0.8308131664416374d,bottom: 0.6967975854015527d,left: 0.7162043146486634d),
new NpgsqlTypes.NpgsqlBox(top: 0.5496646510108106d,right: 0.7564698802618653d,bottom: 0.0896189345928059d,left: 0.5962274105568716d),
new NpgsqlTypes.NpgsqlBox(top: 0.6766189032993011d,right: 0.664188159997426d,bottom: 0.6152425535048391d,left: 0.2180916318338545d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9970037020534587d,right: 0.7346664091069091d,bottom: 0.8371736667720749d,left: 0.6214255173098289d),
new NpgsqlTypes.NpgsqlBox(top: 0.3685933666251432d,right: 0.6900427115748681d,bottom: 0.2684658773201497d,left: 0.6444774717191879d),
new NpgsqlTypes.NpgsqlBox(top: 0.9835565816585073d,right: 0.67647901775738d,bottom: 0.11127534260125449d,left: 0.0004884448668400765d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9385222020540859d,right: 0.9494613573237103d,bottom: 0.019868754018033896d,left: 0.6445418837503003d),
new NpgsqlTypes.NpgsqlBox(top: 0.9361121622049201d,right: 0.7044891158017998d,bottom: 0.28442775621660576d,left: 0.24160493564694552d),
new NpgsqlTypes.NpgsqlBox(top: 0.6578101082697069d,right: 0.6346684400967403d,bottom: 0.3047425017594765d,left: 0.4533655548844042d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9030592257572668d,right: 0.3174285424436515d,bottom: 0.7982770118870568d,left: 0.06543706446084041d),
new NpgsqlTypes.NpgsqlBox(top: 0.4691719651294214d,right: 0.9388282341192121d,bottom: 0.1224099449964301d,left: 0.8539525071952065d),
new NpgsqlTypes.NpgsqlBox(top: 0.6845078930145625d,right: 0.21383905566663186d,bottom: 0.13773890662877164d,left: 0.06425390830425604d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9351116109820474d,right: 0.4737528858343424d,bottom: 0.6753987743652653d,left: 0.10570353448018843d),
new NpgsqlTypes.NpgsqlBox(top: 0.85322148566536d,right: 0.7004666351724577d,bottom: 0.7617695993851805d,left: 0.6578315997409482d),
new NpgsqlTypes.NpgsqlBox(top: 0.26336016257299266d,right: 0.8267808977973514d,bottom: 0.10687263535514702d,left: 0.08593910900749335d),
new NpgsqlTypes.NpgsqlBox(top: 0.41471616736785133d,right: 0.7891901211782875d,bottom: 0.23901035895021805d,left: 0.48310664041885576d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7754076984898477d,right: 0.7465805753802909d,bottom: 0.5281257078857707d,left: 0.3654722519104433d),
new NpgsqlTypes.NpgsqlBox(top: 0.5641154523449804d,right: 0.5341257085521557d,bottom: 0.4852874545387489d,left: 0.3620504273768377d),
new NpgsqlTypes.NpgsqlBox(top: 0.4822615032809059d,right: 0.21972533902012858d,bottom: 0.33689897476113373d,left: 0.018619387171969315d),
new NpgsqlTypes.NpgsqlBox(top: 0.7139464718354539d,right: 0.4265806496731438d,bottom: 0.12424909877265333d,left: 0.19906293040475354d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2586779153856589d,right: 0.7684637207448758d,bottom: 0.10387977371964574d,left: 0.36914110962387425d),
new NpgsqlTypes.NpgsqlBox(top: 0.7850767904309383d,right: 0.6925408449395127d,bottom: 0.3782831566873499d,left: 0.19432700816462323d),
new NpgsqlTypes.NpgsqlBox(top: 0.9191505233449057d,right: 0.7021803546951543d,bottom: 0.19462361883199308d,left: 0.05650587000676144d),
new NpgsqlTypes.NpgsqlBox(top: 0.5466211549801483d,right: 0.7926328192919788d,bottom: 0.47799652785807223d,left: 0.7169788908095427d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20847238700186044d,right: 0.36588841932910565d,bottom: 0.017702357299186455d,left: 0.03200374889192792d),
new NpgsqlTypes.NpgsqlBox(top: 0.48306843436533164d,right: 0.917132561212056d,bottom: 0.4013444328794613d,left: 0.3809215304537652d),
new NpgsqlTypes.NpgsqlBox(top: 0.7791938149871875d,right: 0.663541866262068d,bottom: 0.5554028215960909d,left: 0.172951377603208d),
new NpgsqlTypes.NpgsqlBox(top: 0.5149663890201184d,right: 0.8818537675978441d,bottom: 0.22722418088699403d,left: 0.4594436773864955d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.826621471653248d,right: 0.7455279337201348d,bottom: 0.7751518900531961d,left: 0.11868536079443948d),
new NpgsqlTypes.NpgsqlBox(top: 0.8858377560838893d,right: 0.3371730513055933d,bottom: 0.6308324182135234d,left: 0.2279041939192289d),
new NpgsqlTypes.NpgsqlBox(top: 0.5337119458936134d,right: 0.7183549784214117d,bottom: 0.1644897766340192d,left: 0.26490120267157746d),
new NpgsqlTypes.NpgsqlBox(top: 0.6415658629133875d,right: 0.7045795064329363d,bottom: 0.5848995058852262d,left: 0.5573906107642518d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8572667360580913d,right: 0.23225029371530226d,bottom: 0.7685361223585159d,left: 0.21265968978538408d),
new NpgsqlTypes.NpgsqlBox(top: 0.8665301342914938d,right: 0.18615213005970654d,bottom: 0.48514724550061716d,left: 0.05438392126528013d),
new NpgsqlTypes.NpgsqlBox(top: 0.8142400208439876d,right: 0.994251283381556d,bottom: 0.6716039507953583d,left: 0.6949391288096584d),
new NpgsqlTypes.NpgsqlBox(top: 0.9655342493008142d,right: 0.7105526818413039d,bottom: 0.7932386881170771d,left: 0.197897296009386d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.14177560636761077d,right: 0.3101188392949318d,bottom: 0.048793720781378114d,left: 0.16072789385702746d),
new NpgsqlTypes.NpgsqlBox(top: 0.7283727847700017d,right: 0.9066636222273204d,bottom: 0.5021602412542073d,left: 0.40642998869891755d),
new NpgsqlTypes.NpgsqlBox(top: 0.5085372671416056d,right: 0.9386518454231073d,bottom: 0.31603176641286057d,left: 0.16665978032473017d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7625327558817598d,right: 0.9530652938829721d,bottom: 0.7012939864850872d,left: 0.6167035146758232d),
new NpgsqlTypes.NpgsqlBox(top: 0.29634470927192813d,right: 0.3360407657840897d,bottom: 0.2699293143843229d,left: 0.03140835335164982d),
new NpgsqlTypes.NpgsqlBox(top: 0.779634850347577d,right: 0.7128106662856052d,bottom: 0.7402419537931372d,left: 0.2768112771469514d),
new NpgsqlTypes.NpgsqlBox(top: 0.9753932071346055d,right: 0.9845952529506781d,bottom: 0.27589739666684254d,left: 0.4970097958086087d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42636184796151777d,right: 0.8027432391711525d,bottom: 0.16721734238875263d,left: 0.24424650128590164d),
new NpgsqlTypes.NpgsqlBox(top: 0.41910250843238894d,right: 0.6933210661033674d,bottom: 0.013831282016109614d,left: 0.2247855970540058d),
new NpgsqlTypes.NpgsqlBox(top: 0.6578155954897968d,right: 0.746256766716074d,bottom: 0.5890711030357432d,left: 0.21573399948143845d),
new NpgsqlTypes.NpgsqlBox(top: 0.43223523217986193d,right: 0.8463558549835063d,bottom: 0.1271934240359318d,left: 0.04802544664387198d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8236727158610748d,right: 0.4550785479413799d,bottom: 0.07793609293932213d,left: 0.39622669722800985d),
new NpgsqlTypes.NpgsqlBox(top: 0.87263574860044d,right: 0.6326140544925657d,bottom: 0.5034009178771337d,left: 0.177220570570645d),
new NpgsqlTypes.NpgsqlBox(top: 0.7913273954390303d,right: 0.9113018158349068d,bottom: 0.47025617509045514d,left: 0.8369593879908868d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8614559435864848d,right: 0.9077855729726679d,bottom: 0.6645965459615684d,left: 0.20033795110917219d),
new NpgsqlTypes.NpgsqlBox(top: 0.878214263435187d,right: 0.9431183055872343d,bottom: 0.8736381017810415d,left: 0.3540049462717916d),
new NpgsqlTypes.NpgsqlBox(top: 0.9319170819950314d,right: 0.885315134103702d,bottom: 0.5848976640680708d,left: 0.7608628562782468d),
new NpgsqlTypes.NpgsqlBox(top: 0.6547614317056821d,right: 0.3937380694234175d,bottom: 0.05871433733547693d,left: 0.10383640971954222d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7184094198424161d,right: 0.8977053817151506d,bottom: 0.5803105281366429d,left: 0.0369769919532299d),
new NpgsqlTypes.NpgsqlBox(top: 0.9368061868020647d,right: 0.531643251300243d,bottom: 0.14365483514167143d,left: 0.4087928332772629d),
new NpgsqlTypes.NpgsqlBox(top: 0.40737996025302203d,right: 0.665409870737616d,bottom: 0.0993235786709924d,left: 0.11599559302002993d),
new NpgsqlTypes.NpgsqlBox(top: 0.4174112152106666d,right: 0.4449267100671416d,bottom: 0.25295433925113386d,left: 0.33120129469096327d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 42, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 36, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 84, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

