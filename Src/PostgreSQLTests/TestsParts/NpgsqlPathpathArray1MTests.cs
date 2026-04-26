

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51110168433867d, y: 0.5120420462852351d), new NpgsqlTypes.NpgsqlPoint(x: 0.060606212532827164d, y: 0.4803873123714817d), new NpgsqlTypes.NpgsqlPoint(x: 0.46517193283982405d, y: 0.4609664894477602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7710496627260807d, y: 0.4279113086116104d), new NpgsqlTypes.NpgsqlPoint(x: 0.005771829324108024d, y: 0.8877319808558071d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495488533663666d, y: 0.37051074586302335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48687015693804414d, y: 0.36673946426141224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4651829297277045d, y: 0.5305804258952167d), new NpgsqlTypes.NpgsqlPoint(x: 0.47816536771667095d, y: 0.9533373315139111d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4306243875708924d, y: 0.7454222562423822d), new NpgsqlTypes.NpgsqlPoint(x: 0.31782817249323403d, y: 0.16100290635084213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018918993087958d, y: 0.494501255783256d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7243062821482814d, y: 0.903646215117789d), new NpgsqlTypes.NpgsqlPoint(x: 0.3315995068348474d, y: 0.4290290093621415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330259575867407d, y: 0.08372983965787362d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507899776129418d, y: 0.1483292667685353d), new NpgsqlTypes.NpgsqlPoint(x: 0.3757005091448984d, y: 0.35438441536753007d), new NpgsqlTypes.NpgsqlPoint(x: 0.10267742482891729d, y: 0.0202655023627365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3393001774611776d, y: 0.6725123552801194d), new NpgsqlTypes.NpgsqlPoint(x: 0.2347007843637623d, y: 0.6184259524223238d), new NpgsqlTypes.NpgsqlPoint(x: 0.779565036311909d, y: 0.5374297365617949d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21050852928873787d, y: 0.1944264535597925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269140012317831d, y: 0.2917267662947063d), new NpgsqlTypes.NpgsqlPoint(x: 0.44005394396534947d, y: 0.47001918157555633d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3114512029107349d, y: 0.4106799006505665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276631805979565d, y: 0.3350883969801357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711900860734709d, y: 0.7249141836893572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9770882244070812d, y: 0.220028205567098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680830194784136d, y: 0.5695121412881055d), new NpgsqlTypes.NpgsqlPoint(x: 0.3956155434905396d, y: 0.4706635007286055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5009697739978143d, y: 0.32071316195772526d), new NpgsqlTypes.NpgsqlPoint(x: 0.05221956831660268d, y: 0.7781772873278213d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813381284495634d, y: 0.8945203888389829d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3846589963046223d, y: 0.6910559481915116d), new NpgsqlTypes.NpgsqlPoint(x: 0.058316824116293575d, y: 0.1978300757055872d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593213432190634d, y: 0.6609057350003773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8860647485172078d, y: 0.9603182703990109d), new NpgsqlTypes.NpgsqlPoint(x: 0.09155199204687525d, y: 0.9013774539368293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802458027995611d, y: 0.026901564120364152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39294588309112366d, y: 0.12354604486286014d), new NpgsqlTypes.NpgsqlPoint(x: 0.24171871260002842d, y: 0.130764802270683d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383404792392158d, y: 0.4082796883490246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3808562333190324d, y: 0.18279846912169195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906075113874936d, y: 0.7433452386608159d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018973522450203006d, y: 0.8424314269764989d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.595801995308686d, y: 0.40147057644873485d), new NpgsqlTypes.NpgsqlPoint(x: 0.45464559275054073d, y: 0.7656172331864588d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108161125897756d, y: 0.3273336913858793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029249689422511715d, y: 0.6810082701362068d), new NpgsqlTypes.NpgsqlPoint(x: 0.37380270354552425d, y: 0.07576401902327634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720203004161622d, y: 0.5389559631229842d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03417091842099296d, y: 0.14245491366603247d), new NpgsqlTypes.NpgsqlPoint(x: 0.1157354178312382d, y: 0.30087259670155553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546262996040217d, y: 0.7635238558799904d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6666727950348329d, y: 0.5104098551256161d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427915219309607d, y: 0.49437253928032876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441903817048291d, y: 0.5766250684707669d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49658152860276894d, y: 0.8502084378455729d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302395987985716d, y: 0.4044085559801458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457059570188752d, y: 0.2577285735991939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3642289573181796d, y: 0.39718369523277597d), new NpgsqlTypes.NpgsqlPoint(x: 0.0798919047234733d, y: 0.7981302949672828d), new NpgsqlTypes.NpgsqlPoint(x: 0.1519793012952637d, y: 0.5403237366495911d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13687707048896325d, y: 0.8037685823412902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703599932196173d, y: 0.004363284541157864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126512433806375d, y: 0.1556209356231354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6367005194964718d, y: 0.9889323472277467d), new NpgsqlTypes.NpgsqlPoint(x: 0.03876871788941316d, y: 0.15139440159686923d), new NpgsqlTypes.NpgsqlPoint(x: 0.30449258595211903d, y: 0.19773922847149195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6595315008750021d, y: 0.28421542332695127d), new NpgsqlTypes.NpgsqlPoint(x: 0.14567138261861212d, y: 0.4196739384633942d), new NpgsqlTypes.NpgsqlPoint(x: 0.639749862437851d, y: 0.01748913877224867d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6324954852810457d, y: 0.5405292039767409d), new NpgsqlTypes.NpgsqlPoint(x: 0.392308501051821d, y: 0.9574481768121048d), new NpgsqlTypes.NpgsqlPoint(x: 0.009573641408961442d, y: 0.11183045001544478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8523070012508057d, y: 0.20399030917177674d), new NpgsqlTypes.NpgsqlPoint(x: 0.21140322100013342d, y: 0.3772466881646759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988731922832289d, y: 0.4641275627554349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15683518384275041d, y: 0.49336132943349287d), new NpgsqlTypes.NpgsqlPoint(x: 0.12802380614364905d, y: 0.3486633328832758d), new NpgsqlTypes.NpgsqlPoint(x: 0.36433381267361575d, y: 0.7567494838225463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6106988661967407d, y: 0.24543499379085099d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679425933693486d, y: 0.3826778635994399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645735862289992d, y: 0.11725767801308884d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07709739984837416d, y: 0.10004478611308276d), new NpgsqlTypes.NpgsqlPoint(x: 0.18589256038815238d, y: 0.8006592343407489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386404981733572d, y: 0.4909383032739054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.672192989665606d, y: 0.9436118098041517d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345997312757313d, y: 0.7409527088905565d), new NpgsqlTypes.NpgsqlPoint(x: 0.36503449319166903d, y: 0.7251642353363639d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.412501044436428d, y: 0.16193979305349493d), new NpgsqlTypes.NpgsqlPoint(x: 0.06707262751900966d, y: 0.8897234580221542d), new NpgsqlTypes.NpgsqlPoint(x: 0.11826680170229809d, y: 0.9441519594164781d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6601149360022408d, y: 0.6500026350591241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113608718716108d, y: 0.8975405932565458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4489212662511477d, y: 0.1478780451700159d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3911494101558529d, y: 0.32491977851555376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591486777153072d, y: 0.3887966561646501d), new NpgsqlTypes.NpgsqlPoint(x: 0.47077517345240505d, y: 0.6474031919488962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3241543470592648d, y: 0.028309352514036767d), new NpgsqlTypes.NpgsqlPoint(x: 0.27921023282441715d, y: 0.6711942986526124d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023580193519118d, y: 0.20190347121829777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4493726765124437d, y: 0.6802723156816647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560671270894877d, y: 0.16260111153670176d), new NpgsqlTypes.NpgsqlPoint(x: 0.43604108829645605d, y: 0.16997909556006752d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1789149324296806d, y: 0.022491064747290013d), new NpgsqlTypes.NpgsqlPoint(x: 0.40439545895722506d, y: 0.6926204860500583d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371758268353073d, y: 0.4315339550906172d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2600397051505404d, y: 0.7713481698821807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641404703388477d, y: 0.7790692324666075d), new NpgsqlTypes.NpgsqlPoint(x: 0.337124232305392d, y: 0.7387933431937542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3510942340334873d, y: 0.03384806462259271d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786535830518013d, y: 0.15059267788827757d), new NpgsqlTypes.NpgsqlPoint(x: 0.9409858989072099d, y: 0.6308512456990196d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20937137992954502d, y: 0.6618820469337483d), new NpgsqlTypes.NpgsqlPoint(x: 0.05504293533644822d, y: 0.500464041633078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1776095166487992d, y: 0.67999683279335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47295521600019497d, y: 0.9917365866670173d), new NpgsqlTypes.NpgsqlPoint(x: 0.22890591295085383d, y: 0.8949222357112141d), new NpgsqlTypes.NpgsqlPoint(x: 0.05785433442400534d, y: 0.3767405443948112d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6211152584437732d, y: 0.5258960367733041d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902226190976573d, y: 0.11483975963788329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509632623372817d, y: 0.03933794400107804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8194401916918443d, y: 0.031878907122999345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544617049389625d, y: 0.7865225358038918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308237321903786d, y: 0.20703451890994595d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13192043989096736d, y: 0.8083792100262093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3126709151915795d, y: 0.363180085717021d), new NpgsqlTypes.NpgsqlPoint(x: 0.1819988252559035d, y: 0.9539500325078236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4911053975569363d, y: 0.1076034251042205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262270240329885d, y: 0.4626962715762506d), new NpgsqlTypes.NpgsqlPoint(x: 0.35545168284652506d, y: 0.5956082283375289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5663754717798936d, y: 0.3455256851794669d), new NpgsqlTypes.NpgsqlPoint(x: 0.3993872070672493d, y: 0.9797249307208908d), new NpgsqlTypes.NpgsqlPoint(x: 0.05012896105264519d, y: 0.7921005763443125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6020081935724886d, y: 0.15901727041066127d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192086686017597d, y: 0.6948546364931415d), new NpgsqlTypes.NpgsqlPoint(x: 0.3290478841979585d, y: 0.41392837482432576d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220282659566857d, y: 0.9440604608180148d), new NpgsqlTypes.NpgsqlPoint(x: 0.0725155728177248d, y: 0.42709014605145423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912812319625583d, y: 0.9925004679770106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7290732492168124d, y: 0.11380099908682495d), new NpgsqlTypes.NpgsqlPoint(x: 0.402465706368087d, y: 0.016047516210934143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744084489774618d, y: 0.4168478279951149d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7750434679282745d, y: 0.37808750994468765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231356263880008d, y: 0.785006118688627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595057294374101d, y: 0.5877149160715612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3368857331142794d, y: 0.935468048600345d), new NpgsqlTypes.NpgsqlPoint(x: 0.1867962387155322d, y: 0.29056380641989055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093510251261817d, y: 0.27104668808021193d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8870402476211923d, y: 0.034374004624255994d), new NpgsqlTypes.NpgsqlPoint(x: 0.46444136689093185d, y: 0.8273746108014186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944650838967852d, y: 0.8575599901814789d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42061527666579923d, y: 0.13035033889675818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747380434743922d, y: 0.8645426222401078d), new NpgsqlTypes.NpgsqlPoint(x: 0.012775537074893428d, y: 0.22596756909125115d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8068523605647304d, y: 0.8268666655566431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325013834137148d, y: 0.5411062435260282d), new NpgsqlTypes.NpgsqlPoint(x: 0.490027262534375d, y: 0.9767035765456301d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8771346938476662d, y: 0.9575484347046015d), new NpgsqlTypes.NpgsqlPoint(x: 0.774329636638586d, y: 0.08306369375403633d), new NpgsqlTypes.NpgsqlPoint(x: 0.23798613432383953d, y: 0.7446600180026341d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35438116324748536d, y: 0.805543715835287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163331758290569d, y: 0.7952148255574437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789816344497203d, y: 0.28771507277662134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9916488734048496d, y: 0.7894290349882747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476505395171203d, y: 0.5494497516643092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482415937673971d, y: 0.48600696654640785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23864533082836448d, y: 0.12025327344776815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568443048807916d, y: 0.4705766036237783d), new NpgsqlTypes.NpgsqlPoint(x: 0.046964772076220074d, y: 0.828575798748916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04157478373929324d, y: 0.7263600908895408d), new NpgsqlTypes.NpgsqlPoint(x: 0.04275049536140185d, y: 0.28854956362409034d), new NpgsqlTypes.NpgsqlPoint(x: 0.39109121839421623d, y: 0.22687239102321166d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0007624327782725926d, y: 0.4071202918112593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605937808143635d, y: 0.9854689062769755d), new NpgsqlTypes.NpgsqlPoint(x: 0.05271350830584487d, y: 0.7749829568360401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26080579154251493d, y: 0.185895933394588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196022533684486d, y: 0.8491001941890879d), new NpgsqlTypes.NpgsqlPoint(x: 0.22789037996760286d, y: 0.7421540189578019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9451522712009239d, y: 0.46230609584362703d), new NpgsqlTypes.NpgsqlPoint(x: 0.09142456230813312d, y: 0.07333146522008449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894878399892981d, y: 0.8154999502439971d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7596910048350819d, y: 0.44688212954646467d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194916377718133d, y: 0.5096723489545911d), new NpgsqlTypes.NpgsqlPoint(x: 0.14322442562827165d, y: 0.7752349815542932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5771044483682722d, y: 0.9281524286722793d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392715763226102d, y: 0.16885296317818665d), new NpgsqlTypes.NpgsqlPoint(x: 0.43914046085404046d, y: 0.06455569372039738d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9226338341343091d, y: 0.345530075095814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905056039282281d, y: 0.4371861269517152d), new NpgsqlTypes.NpgsqlPoint(x: 0.33124192775328243d, y: 0.24132060513781017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8697354460767291d, y: 0.11217309801406794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4112385396862219d, y: 0.48298050941550175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003096433382053d, y: 0.8595011136836355d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24044959817480027d, y: 0.01425543936550544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910232646389355d, y: 0.25897965466584305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810911669109915d, y: 0.16378444180521734d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.252855042261259d, y: 0.934311921960519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012773998607726d, y: 0.7556016119648387d), new NpgsqlTypes.NpgsqlPoint(x: 0.3098444487588764d, y: 0.7760482542507705d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15651635093157856d, y: 0.5306271238981218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140555612531072d, y: 0.570016322597791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016801231558578d, y: 0.4326607263258152d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7025273450352719d, y: 0.678178672320598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785135967630098d, y: 0.23373492769179072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450154948491774d, y: 0.1632761597870679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247515713450927d, y: 0.3131731731855817d), new NpgsqlTypes.NpgsqlPoint(x: 0.00591842670675391d, y: 0.5960658928577488d), new NpgsqlTypes.NpgsqlPoint(x: 0.05035810564057486d, y: 0.6154353844370449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013288889310789864d, y: 0.923368548803532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290500969014651d, y: 0.9007942489839175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064636826919155d, y: 0.47066515757307403d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6570767564728509d, y: 0.3768921399268821d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905858387672788d, y: 0.8070118737361862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4619942319272894d, y: 0.2842350760521576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9652620820508496d, y: 0.6620085432110553d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797016209718485d, y: 0.405779768056988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17701920850460473d, y: 0.374958857071494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4522489261293444d, y: 0.4925810158772792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384427675258126d, y: 0.7255099330537148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614322258189999d, y: 0.23870241366727873d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9831047638067001d, y: 0.04570341157844138d), new NpgsqlTypes.NpgsqlPoint(x: 0.06432690927670837d, y: 0.3117576403301744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853381871718802d, y: 0.9299093568433188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7082192349722805d, y: 0.5664039013574128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975976107976046d, y: 0.8211490394125184d), new NpgsqlTypes.NpgsqlPoint(x: 0.944695257219535d, y: 0.5956896007165315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.255325631674131d, y: 0.986719497412568d), new NpgsqlTypes.NpgsqlPoint(x: 0.3615365848883003d, y: 0.8645401521679592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306506632486708d, y: 0.37745376709188583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8379891446578467d, y: 0.9325506672496147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919030245575308d, y: 0.4987042051725603d), new NpgsqlTypes.NpgsqlPoint(x: 0.10441462642283295d, y: 0.460742680508344d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6787834225557549d, y: 0.7390924545884162d), new NpgsqlTypes.NpgsqlPoint(x: 0.896406481309704d, y: 0.39560413146394513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772796208692899d, y: 0.5079115717403047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06657066526105393d, y: 0.45105650940501063d), new NpgsqlTypes.NpgsqlPoint(x: 0.11733253228162566d, y: 0.2685352627394172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551604577906122d, y: 0.4409989104698555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16125310748934008d, y: 0.31033466113190733d), new NpgsqlTypes.NpgsqlPoint(x: 0.47802890716647706d, y: 0.785626175769284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6805937291053794d, y: 0.31568263233001415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23511203346884668d, y: 0.3352417521956884d), new NpgsqlTypes.NpgsqlPoint(x: 0.10811701610041746d, y: 0.8053153650814704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3181886770604959d, y: 0.29803685722532636d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523779244950862d, y: 0.016273755827803327d), new NpgsqlTypes.NpgsqlPoint(x: 0.22233966641039193d, y: 0.5997659200641944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042996575735515d, y: 0.6792431089557225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9784521265592959d, y: 0.9425903246988311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501239425470392d, y: 0.10119856086071788d), new NpgsqlTypes.NpgsqlPoint(x: 0.014029514481028516d, y: 0.007686972409373216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0665064786071935d, y: 0.776966797598073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3144877811410224d, y: 0.26939849333413546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620411224465879d, y: 0.9847080450403581d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7196780739702869d, y: 0.7298960902132257d), new NpgsqlTypes.NpgsqlPoint(x: 0.12545552112822334d, y: 0.1473691289002763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7441696132577653d, y: 0.1380308213418755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9620922242844286d, y: 0.3006331879235684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065632496624074d, y: 0.13320604053110308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384569833672936d, y: 0.8096909779526438d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36148029745984367d, y: 0.42463956714093365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118820979182958d, y: 0.2430883791883084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242480084973487d, y: 0.7897224904283295d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7114007454032515d, y: 0.6590030463028402d), new NpgsqlTypes.NpgsqlPoint(x: 0.07085374750006912d, y: 0.5828772025743276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3618649957835576d, y: 0.773870611442567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38918563505024595d, y: 0.5160625800127971d), new NpgsqlTypes.NpgsqlPoint(x: 0.36408162174291203d, y: 0.5190058734624415d), new NpgsqlTypes.NpgsqlPoint(x: 0.39889998159295803d, y: 0.16696810013850216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06551064524286732d, y: 0.33975004763508887d), new NpgsqlTypes.NpgsqlPoint(x: 0.13418530389330652d, y: 0.9700625338733119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601959007422832d, y: 0.6633077059067125d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9880817536469455d, y: 0.13210200263288818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677173008953554d, y: 0.7750789516627654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825401963780145d, y: 0.7561575001775592d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8166580037109633d, y: 0.8381838039515129d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536369484493024d, y: 0.030287524142799116d), new NpgsqlTypes.NpgsqlPoint(x: 0.0765581970479503d, y: 0.9302078736838655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.849730221975308d, y: 0.8226410755134421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585585504179111d, y: 0.3294395879062404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981298323005531d, y: 0.6311339110502472d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006666687437217d, y: 0.7412401045144926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39355175401343545d, y: 0.11664848982338782d), new NpgsqlTypes.NpgsqlPoint(x: 0.4262511698864009d, y: 0.8794898923298093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12917558645243032d, y: 0.3217275130265963d), new NpgsqlTypes.NpgsqlPoint(x: 0.540439919083415d, y: 0.9331518799541013d), new NpgsqlTypes.NpgsqlPoint(x: 0.008352924384808613d, y: 0.5420071317069834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5886300051266548d, y: 0.26040159114814465d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583092611706454d, y: 0.9707478096017704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256326375455701d, y: 0.9941128468097339d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8015274975491827d, y: 0.8157154999974975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2944855009080001d, y: 0.5288909863950626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965385244587494d, y: 0.5895981836871446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4564123934946416d, y: 0.9741871545926168d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743746141588011d, y: 0.5722246925219641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311568811094318d, y: 0.9960035106450427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7976793426923975d, y: 0.1420612537457786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600487880251837d, y: 0.8612201537279962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644890076004542d, y: 0.456973521449774d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10665670197325239d, y: 0.23628464762946721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807882454719512d, y: 0.5296815361492744d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738521596953829d, y: 0.6550571137532716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6691328596280117d, y: 0.8882309725878105d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806972513206527d, y: 0.6575554647866987d), new NpgsqlTypes.NpgsqlPoint(x: 0.18666906917473758d, y: 0.8594615657285093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7182947788828736d, y: 0.7498262414975675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092870878302398d, y: 0.9150559494494146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169915526820024d, y: 0.26261594392987786d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9487137743587761d, y: 0.5427822903978408d), new NpgsqlTypes.NpgsqlPoint(x: 0.02848586261144881d, y: 0.38971483797204454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372796315009895d, y: 0.29836614550962015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3075512287090323d, y: 0.80907613021357d), new NpgsqlTypes.NpgsqlPoint(x: 0.11789925200811224d, y: 0.12366076182494246d), new NpgsqlTypes.NpgsqlPoint(x: 0.014630884801646427d, y: 0.4589979808289637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6188133923748724d, y: 0.13872412927706568d), new NpgsqlTypes.NpgsqlPoint(x: 0.48188997709000714d, y: 0.5327915721051291d), new NpgsqlTypes.NpgsqlPoint(x: 0.03218271691112895d, y: 0.34510697159304937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6864284747656374d, y: 0.5517516730635439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927631164661296d, y: 0.4556463168234006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232589773229676d, y: 0.7350902217190742d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9668203688607815d, y: 0.15714993937805355d), new NpgsqlTypes.NpgsqlPoint(x: 0.1958411916534013d, y: 0.20401579259885416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271724698306442d, y: 0.7325549893417679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2577394409564516d, y: 0.061256681678699576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7384583589284599d, y: 0.10291050291174941d), new NpgsqlTypes.NpgsqlPoint(x: 0.888410765614407d, y: 0.6078949053747996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3041193561001111d, y: 0.01029459470143057d), new NpgsqlTypes.NpgsqlPoint(x: 0.30234104835740105d, y: 0.5072979258712627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804215987594108d, y: 0.5253861330849894d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2860736744928105d, y: 0.292988039224079d), new NpgsqlTypes.NpgsqlPoint(x: 0.3595850768138702d, y: 0.929467205874512d), new NpgsqlTypes.NpgsqlPoint(x: 0.05892734554374901d, y: 0.6616789596131982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17164526335368602d, y: 0.4944223324606283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3217085515988791d, y: 0.7738794032648293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716820702004448d, y: 0.8937041609585432d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7234469254006282d, y: 0.7960014517093309d), new NpgsqlTypes.NpgsqlPoint(x: 0.4585492983981576d, y: 0.5875542439028465d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788817503213842d, y: 0.22081873861951506d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44313574296551494d, y: 0.4244681855048853d), new NpgsqlTypes.NpgsqlPoint(x: 0.982254270995348d, y: 0.12735816609481532d), new NpgsqlTypes.NpgsqlPoint(x: 0.19088964091781235d, y: 0.6534594213174679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14440679543923673d, y: 0.672267245780527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917091969408245d, y: 0.9476092757036219d), new NpgsqlTypes.NpgsqlPoint(x: 0.013616303640519689d, y: 0.7121959898795774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25561114847850586d, y: 0.1305899965904932d), new NpgsqlTypes.NpgsqlPoint(x: 0.4945611572273204d, y: 0.6136508272960578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905175055788371d, y: 0.9665076702152237d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224647316015584d, y: 0.8649658212271931d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477350614240932d, y: 0.025543555996109357d), new NpgsqlTypes.NpgsqlPoint(x: 0.13433719388883758d, y: 0.6380559981248529d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.329453691562389d, y: 0.9888267469588341d), new NpgsqlTypes.NpgsqlPoint(x: 0.15883710197104306d, y: 0.11869569153842041d), new NpgsqlTypes.NpgsqlPoint(x: 0.14036181647497337d, y: 0.35055796654171534d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9174009650202652d, y: 0.11028571851215385d), new NpgsqlTypes.NpgsqlPoint(x: 0.35502941949578337d, y: 0.24649373334872393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454636027087226d, y: 0.0669797035317673d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9234774328027607d, y: 0.9741469297627154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580494274862966d, y: 0.6575836950417584d), new NpgsqlTypes.NpgsqlPoint(x: 0.08701133530869154d, y: 0.795680353336976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02993392225429692d, y: 0.3378058943321197d), new NpgsqlTypes.NpgsqlPoint(x: 0.16472805945807645d, y: 0.5568827558416961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397609254380652d, y: 0.8563079013482813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6352070362084689d, y: 0.11691545322980301d), new NpgsqlTypes.NpgsqlPoint(x: 0.4644322005980783d, y: 0.40597461079041275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253766159967643d, y: 0.3849839011030417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18291679953212236d, y: 0.8747190718272987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830471023529009d, y: 0.1820486308002035d), new NpgsqlTypes.NpgsqlPoint(x: 0.878650900004357d, y: 0.184442206128956d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494050422066441d, y: 0.16072481037662145d), new NpgsqlTypes.NpgsqlPoint(x: 0.317518340674089d, y: 0.9102200914231614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877402259589768d, y: 0.21231170017277867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.627379220354102d, y: 0.5671533901265685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161449049257535d, y: 0.5058538143312437d), new NpgsqlTypes.NpgsqlPoint(x: 0.23528856813567967d, y: 0.7051370883869474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545126087123497d, y: 0.28144561773978605d), new NpgsqlTypes.NpgsqlPoint(x: 0.45129961697908405d, y: 0.7038199045649667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093427720507871d, y: 0.9212314558897512d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7447518068853572d, y: 0.724293487500096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583052658035395d, y: 0.9827316080378481d), new NpgsqlTypes.NpgsqlPoint(x: 0.4212702072081408d, y: 0.09141651183669885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9471666590066088d, y: 0.9195628663774414d), new NpgsqlTypes.NpgsqlPoint(x: 0.30331036678875467d, y: 0.3096988328418455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952938530830959d, y: 0.8768916594743886d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22452242864477578d, y: 0.3505445756425378d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823956782038135d, y: 0.5807112451358216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484074699251239d, y: 0.09897194272774767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5342216355501493d, y: 0.6803842294820893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096837845539027d, y: 0.8272524591193454d), new NpgsqlTypes.NpgsqlPoint(x: 0.01952444545824883d, y: 0.7182076839006103d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43562527540692575d, y: 0.8299226395245579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084777001781658d, y: 0.4012599378780647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5527757226023366d, y: 0.48496588786426165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8936764564207075d, y: 0.055715616462866824d), new NpgsqlTypes.NpgsqlPoint(x: 0.44850881280114463d, y: 0.023513056674468236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940610478094393d, y: 0.012073281656455048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23330995268060817d, y: 0.2989060509989142d), new NpgsqlTypes.NpgsqlPoint(x: 0.25563604918390515d, y: 0.6600724728636674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8521413900525246d, y: 0.25485547155077737d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8231084778226434d, y: 0.7950841258316433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4450057224860027d, y: 0.037833135585773614d), new NpgsqlTypes.NpgsqlPoint(x: 0.40998164093477085d, y: 0.420149595272035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9358680689963739d, y: 0.03434290378835514d), new NpgsqlTypes.NpgsqlPoint(x: 0.0294005174677483d, y: 0.10071262582143747d), new NpgsqlTypes.NpgsqlPoint(x: 0.30400745095459036d, y: 0.5786686068852878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505914351393911d, y: 0.292567607528477d), new NpgsqlTypes.NpgsqlPoint(x: 0.3820645149333365d, y: 0.3768730968466174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501501958654337d, y: 0.8194119226456268d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8015493202701824d, y: 0.38772103114935563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4847695331161781d, y: 0.6299443480503777d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214816951709021d, y: 0.1397672107996818d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5938252249856268d, y: 0.6522412941891667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551350966115789d, y: 0.8489735432238579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775658685104448d, y: 0.8896247068167953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393950878584217d, y: 0.2895208799134221d), new NpgsqlTypes.NpgsqlPoint(x: 0.12688384796195706d, y: 0.5873268137225386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185433842223182d, y: 0.9432802514032929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9775947443825498d, y: 0.6419167084675466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566272956984432d, y: 0.9911150378760248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321932010167065d, y: 0.03141406289140347d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16455281804438493d, y: 0.8575611684162112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871168025801975d, y: 0.5610688654715268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369361057173557d, y: 0.6936444684564971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13140116858843331d, y: 0.309147906711595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624775599044499d, y: 0.9337056051374187d), new NpgsqlTypes.NpgsqlPoint(x: 0.021902422712171576d, y: 0.07400108314615439d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01928882760287831d, y: 0.7714314390793263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939035603811961d, y: 0.5074879944384104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642699243670508d, y: 0.9016974102161757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7333124237568297d, y: 0.18003253510274708d), new NpgsqlTypes.NpgsqlPoint(x: 0.0001436259637295212d, y: 0.7117416027136517d), new NpgsqlTypes.NpgsqlPoint(x: 0.48351759923083093d, y: 0.5668863494859555d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5123450984523157d, y: 0.05782047868920348d), new NpgsqlTypes.NpgsqlPoint(x: 0.02571384778972241d, y: 0.8225366534890701d), new NpgsqlTypes.NpgsqlPoint(x: 0.02343656082981782d, y: 0.5545947631453355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19587449047789263d, y: 0.2753911481869601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833841202928768d, y: 0.8626126861309318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910974322717568d, y: 0.008981999040636901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.518740960397372d, y: 0.10673905709714093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249992494676051d, y: 0.604633674698027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351873251569233d, y: 0.09745189185445535d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9713283058487122d, y: 0.7290318574262198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845771509692657d, y: 0.3525157663809293d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135224595991038d, y: 0.722896601978583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.97413377147749d, y: 0.47169674534219774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512729212184316d, y: 0.924015495222503d), new NpgsqlTypes.NpgsqlPoint(x: 0.11225532533280314d, y: 0.05543048970831477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3033307416386063d, y: 0.45696200251315033d), new NpgsqlTypes.NpgsqlPoint(x: 0.09074145737651829d, y: 0.6423047386973401d), new NpgsqlTypes.NpgsqlPoint(x: 0.23573190645142472d, y: 0.9065295554851456d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082655323241923d, y: 0.1951699093347049d), new NpgsqlTypes.NpgsqlPoint(x: 0.2701864347487186d, y: 0.8307419423917851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719258401682371d, y: 0.04650645349109661d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11674914227928412d, y: 0.17697927580556339d), new NpgsqlTypes.NpgsqlPoint(x: 0.2074197343401134d, y: 0.48684029944412555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7414719564821559d, y: 0.86755926241263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4696153291919666d, y: 0.12540496829436554d), new NpgsqlTypes.NpgsqlPoint(x: 0.40353955924580853d, y: 0.9488289080177507d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244251188268469d, y: 0.9135458590404428d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9652871284444382d, y: 0.5447546046615188d), new NpgsqlTypes.NpgsqlPoint(x: 0.31088120570038114d, y: 0.641586370001752d), new NpgsqlTypes.NpgsqlPoint(x: 0.24677001156238665d, y: 0.6033182185028312d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3335180040071093d, y: 0.058105737893059395d), new NpgsqlTypes.NpgsqlPoint(x: 0.24779555312511747d, y: 0.5607113803150526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888509435638161d, y: 0.7532304305115486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028737852865593272d, y: 0.43990088306841346d), new NpgsqlTypes.NpgsqlPoint(x: 0.030004156552913774d, y: 0.007214556545072637d), new NpgsqlTypes.NpgsqlPoint(x: 0.15913609555853625d, y: 0.10456060225579988d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17000182881717996d, y: 0.9812599475944243d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437182163742003d, y: 0.7028036188147471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033416883992218d, y: 0.38728888023464436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9699607217025854d, y: 0.011316648138906649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4788599992330791d, y: 0.6602096352030536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231611999913754d, y: 0.9644633391947668d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7724517448320408d, y: 0.9849946156060531d), new NpgsqlTypes.NpgsqlPoint(x: 0.83459009462265d, y: 0.5174794798412735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994518669868565d, y: 0.2942471197570793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23353684203166813d, y: 0.7789728751362205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5818339072817877d, y: 0.8605591081051461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898347389351074d, y: 0.4709655949999707d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17957440658750412d, y: 0.9063439564617002d), new NpgsqlTypes.NpgsqlPoint(x: 0.0943218569795019d, y: 0.03762192791478558d), new NpgsqlTypes.NpgsqlPoint(x: 0.005069900490017987d, y: 0.30136545130083037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021895468758600267d, y: 0.7874975132854113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984035560042721d, y: 0.5685082797625359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8927271878284204d, y: 0.7605108919760513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3001928127365715d, y: 0.24797938725295998d), new NpgsqlTypes.NpgsqlPoint(x: 0.26293605538750575d, y: 0.5283427422100715d), new NpgsqlTypes.NpgsqlPoint(x: 0.022227757253767466d, y: 0.9046041290610292d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7629796963817879d, y: 0.85002726053243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547961416205823d, y: 0.05827259596724266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925417032606643d, y: 0.3872145384682302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9836540823959862d, y: 0.42083888623603116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833701884982962d, y: 0.26490449205125755d), new NpgsqlTypes.NpgsqlPoint(x: 0.07214926340557026d, y: 0.5924276319878774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.955203804576853d, y: 0.3457088209103166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621816329982775d, y: 0.8231323096222137d), new NpgsqlTypes.NpgsqlPoint(x: 0.22613860401565633d, y: 0.3888826790452816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36158647286054413d, y: 0.7968902270330812d), new NpgsqlTypes.NpgsqlPoint(x: 0.013553500014874875d, y: 0.3312765524147754d), new NpgsqlTypes.NpgsqlPoint(x: 0.64619606026785d, y: 0.6913607917998396d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832483015243628d, y: 0.6924651963571612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172240613922813d, y: 0.24810090088184455d), new NpgsqlTypes.NpgsqlPoint(x: 0.314104629071309d, y: 0.7151503273544281d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6604902667983082d, y: 0.38468512279239664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853281900240104d, y: 0.662900438162592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7667456147989683d, y: 0.3092214418555457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2820385709992237d, y: 0.3469344699923459d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602315140222566d, y: 0.5567674126165243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694965794633244d, y: 0.9225583292191133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10987600387821228d, y: 0.2842612520550024d), new NpgsqlTypes.NpgsqlPoint(x: 0.38703769049905623d, y: 0.7735765856383593d), new NpgsqlTypes.NpgsqlPoint(x: 0.24434455896746887d, y: 0.16803110048137915d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903418593500311d, y: 0.8155937075001852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426064222090257d, y: 0.20738590498587917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620378851412783d, y: 0.6647523809517926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11786281455160919d, y: 0.061755423464098014d), new NpgsqlTypes.NpgsqlPoint(x: 0.3835956853743755d, y: 0.8888063465111077d), new NpgsqlTypes.NpgsqlPoint(x: 0.01566402148855739d, y: 0.9350765540599816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394183068365453d, y: 0.07521702343990633d), new NpgsqlTypes.NpgsqlPoint(x: 0.04251370740854843d, y: 0.7809916373566889d), new NpgsqlTypes.NpgsqlPoint(x: 0.5456386104115002d, y: 0.9086574444471832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088591980305521d, y: 0.4473326601965888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432652314840354d, y: 0.15787359641560605d), new NpgsqlTypes.NpgsqlPoint(x: 0.09759810622563148d, y: 0.5292634990258518d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8346042315403629d, y: 0.28781155348278065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065468822489622d, y: 0.693150788899295d), new NpgsqlTypes.NpgsqlPoint(x: 0.0021746640966328057d, y: 0.27395419470001303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8635093850602983d, y: 0.7228553726194017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658949150025058d, y: 0.8649431427786248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5579073684814636d, y: 0.9395749211237899d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.991452285147347d, y: 0.08841271951702945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275470862657427d, y: 0.18335515631231358d), new NpgsqlTypes.NpgsqlPoint(x: 0.47537733778319247d, y: 0.7080894924516842d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4669873671839946d, y: 0.7232396508083272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348771201739649d, y: 0.8048019993986528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366866074365504d, y: 0.6689284281726079d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35697049218440324d, y: 0.4586374029211351d), new NpgsqlTypes.NpgsqlPoint(x: 0.17702887484846574d, y: 0.2492740138631354d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003904903730036491d, y: 0.5838478431407856d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4120935938815984d, y: 0.8186054188698481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8791582142495528d, y: 0.6984240521083299d), new NpgsqlTypes.NpgsqlPoint(x: 0.20606967910031015d, y: 0.13095952218688267d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04335349973454916d, y: 0.8930816489216361d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813713720591609d, y: 0.30738499942204056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891172139341115d, y: 0.7725637257504138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45410728507861486d, y: 0.02898911305694507d), new NpgsqlTypes.NpgsqlPoint(x: 0.14963612974659912d, y: 0.7430083503816541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980645537145556d, y: 0.6520178112829481d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.301026827369272d, y: 0.7018307320972338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359579438484447d, y: 0.19469274510293166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345093177172163d, y: 0.3617012165943564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6314723366131904d, y: 0.6106846584925838d), new NpgsqlTypes.NpgsqlPoint(x: 0.14462782070330904d, y: 0.2937478862862374d), new NpgsqlTypes.NpgsqlPoint(x: 0.16676721963102348d, y: 0.36228078433768085d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8306565362355789d, y: 0.6783716108799234d), new NpgsqlTypes.NpgsqlPoint(x: 0.41481691125492715d, y: 0.4348012004245525d), new NpgsqlTypes.NpgsqlPoint(x: 0.12707042024394666d, y: 0.8921651295217687d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332022389863193d, y: 0.06209129748112929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217285016409261d, y: 0.17692338547393427d), new NpgsqlTypes.NpgsqlPoint(x: 0.4844943454312429d, y: 0.3823357058507546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27003459328445534d, y: 0.9780708378312916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532236386808304d, y: 0.28350418302862046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052219418344602d, y: 0.3732637985168382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8619022344640059d, y: 0.4346331422264127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732669363815755d, y: 0.3329712015832532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6762573054380646d, y: 0.6519559276957032d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22319673044313304d, y: 0.24359724334969834d), new NpgsqlTypes.NpgsqlPoint(x: 0.4212960858216567d, y: 0.9344450235748573d), new NpgsqlTypes.NpgsqlPoint(x: 0.008665011577098203d, y: 0.03998823232840509d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33962816865390244d, y: 0.9549751042828787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219370395082132d, y: 0.7598885499537907d), new NpgsqlTypes.NpgsqlPoint(x: 0.20759384516020052d, y: 0.28734607088281516d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.837292012911342d, y: 0.9760821198236117d), new NpgsqlTypes.NpgsqlPoint(x: 0.2048283509050397d, y: 0.3979406525649102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288670190561453d, y: 0.8117901066773577d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03445106899697736d, y: 0.07320406525231138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6548660563922416d, y: 0.5780758405666631d), new NpgsqlTypes.NpgsqlPoint(x: 0.11069212225335034d, y: 0.553610194192898d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26718567149429073d, y: 0.6703960770250516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800626351805015d, y: 0.8241380399740061d), new NpgsqlTypes.NpgsqlPoint(x: 0.06452300994317106d, y: 0.9418887199786177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.955258665065137d, y: 0.9577236137891115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132300571393063d, y: 0.5710146109124754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789786654881924d, y: 0.6759192788108725d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.765785919309772d, y: 0.8654255794577832d), new NpgsqlTypes.NpgsqlPoint(x: 0.3288685478868535d, y: 0.40410641587992724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314631504812073d, y: 0.8038158605600466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8538027550165528d, y: 0.14464067181567974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6786837760448396d, y: 0.6811110561502598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779513429948787d, y: 0.4833652870770596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.037559816483432984d, y: 0.6377263772122355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8849621139960878d, y: 0.7186658250632934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046547672043907d, y: 0.9880200195000117d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.476696147427375d, y: 0.580449740835336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4798468435942286d, y: 0.8597153612291156d), new NpgsqlTypes.NpgsqlPoint(x: 0.25537559273211796d, y: 0.4675919779098344d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8002857352980648d, y: 0.01084253677703273d), new NpgsqlTypes.NpgsqlPoint(x: 0.10287486548622715d, y: 0.8033937475470909d), new NpgsqlTypes.NpgsqlPoint(x: 0.01833939617951752d, y: 0.5061485500287065d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8771290057781916d, y: 0.7216731011788533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939083121699347d, y: 0.967769934867369d), new NpgsqlTypes.NpgsqlPoint(x: 0.45384690268727457d, y: 0.4841865561910216d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6171536619563269d, y: 0.8370477854401674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406609410970833d, y: 0.5906779548338719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963568405258608d, y: 0.981343164406165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9015675493333976d, y: 0.011861991918340364d), new NpgsqlTypes.NpgsqlPoint(x: 0.04672383928099233d, y: 0.9892309742991203d), new NpgsqlTypes.NpgsqlPoint(x: 0.42188214139556734d, y: 0.8494480595953625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8061869961933873d, y: 0.1806214965720504d), new NpgsqlTypes.NpgsqlPoint(x: 0.1336402102923595d, y: 0.7367126351133543d), new NpgsqlTypes.NpgsqlPoint(x: 0.32036226621443664d, y: 0.8398144725537946d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8042741915602886d, y: 0.6769974819768799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066862227595182d, y: 0.029523902564319693d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187455368675926d, y: 0.15257271112821102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9858838886060566d, y: 0.6294012804897477d), new NpgsqlTypes.NpgsqlPoint(x: 0.008961861003420224d, y: 0.28460865483931563d), new NpgsqlTypes.NpgsqlPoint(x: 0.606098407621061d, y: 0.49088247143769803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21073845459560803d, y: 0.9429618760121872d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058771804243906d, y: 0.9094290263224222d), new NpgsqlTypes.NpgsqlPoint(x: 0.1537924391396822d, y: 0.7872141758109495d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5459697954364702d, y: 0.02365409218387471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162035660725792d, y: 0.07816471305639894d), new NpgsqlTypes.NpgsqlPoint(x: 0.08691534949252144d, y: 0.406670115964736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19266860653841722d, y: 0.2215594376697263d), new NpgsqlTypes.NpgsqlPoint(x: 0.10655560423990829d, y: 0.8161713219588299d), new NpgsqlTypes.NpgsqlPoint(x: 0.46569061978827353d, y: 0.08817325597385062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36393189771629797d, y: 0.5528756991263022d), new NpgsqlTypes.NpgsqlPoint(x: 0.4658324530904383d, y: 0.040221331877086874d), new NpgsqlTypes.NpgsqlPoint(x: 0.18380150707440523d, y: 0.2911263244033039d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3027991998521915d, y: 0.7040439534729969d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988782295294989d, y: 0.47384347155660045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4067237067703071d, y: 0.915413074215256d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28231964475349647d, y: 0.4445268817921989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3275306319222612d, y: 0.6687308824307442d), new NpgsqlTypes.NpgsqlPoint(x: 0.18480254558537135d, y: 0.20139861056949426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12715170821775035d, y: 0.9133764575186659d), new NpgsqlTypes.NpgsqlPoint(x: 0.014723647824837705d, y: 0.7944608511463717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186578375031335d, y: 0.273957118642712d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780686386466448d, y: 0.18818898555107544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5519508930179751d, y: 0.19149427357349824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168114309018901d, y: 0.4595792840260695d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2704023843008754d, y: 0.8790564532461829d), new NpgsqlTypes.NpgsqlPoint(x: 0.14631431926479377d, y: 0.4080474488824183d), new NpgsqlTypes.NpgsqlPoint(x: 0.18621357317366205d, y: 0.4214092860622939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8981042166626265d, y: 0.16659965918957864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329893128837849d, y: 0.5560058698942151d), new NpgsqlTypes.NpgsqlPoint(x: 0.24499624574925627d, y: 0.8788127336238337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5482350300791923d, y: 0.5777244527780401d), new NpgsqlTypes.NpgsqlPoint(x: 0.0050739390225887915d, y: 0.6684846619340455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819658855904882d, y: 0.6346621072436185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8486140190890836d, y: 0.966698221716545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050396634838109d, y: 0.5374532768750123d), new NpgsqlTypes.NpgsqlPoint(x: 0.015569186462466855d, y: 0.08866701544495648d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029345741225017208d, y: 0.4941214925883678d), new NpgsqlTypes.NpgsqlPoint(x: 0.07971371009347261d, y: 0.8492711752653537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851680411432365d, y: 0.01934778727379194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3505846922891164d, y: 0.41818157091782404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4276084710018342d, y: 0.44487530872358627d), new NpgsqlTypes.NpgsqlPoint(x: 0.23928406213189413d, y: 0.4556632869871806d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7983117754981534d, y: 0.9134479912366109d), new NpgsqlTypes.NpgsqlPoint(x: 0.608967679844524d, y: 0.7860830903137271d), new NpgsqlTypes.NpgsqlPoint(x: 0.21028144164845297d, y: 0.9765350559350251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4479245430666563d, y: 0.13625240345134415d), new NpgsqlTypes.NpgsqlPoint(x: 0.628933573749486d, y: 0.3613291884136378d), new NpgsqlTypes.NpgsqlPoint(x: 0.1464112167131526d, y: 0.9415002302969682d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005885121301658192d, y: 0.3139348378394654d), new NpgsqlTypes.NpgsqlPoint(x: 0.21578583634258985d, y: 0.9888362846050696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965963206493889d, y: 0.8928858729864524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43053235253583055d, y: 0.6370542861340786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666516657562098d, y: 0.8455577945068116d), new NpgsqlTypes.NpgsqlPoint(x: 0.08978414945936641d, y: 0.07234950256312334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49438147261286225d, y: 0.18425830399271692d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024864687107900574d, y: 0.6007809283564979d), new NpgsqlTypes.NpgsqlPoint(x: 0.08269594537187597d, y: 0.6897680749367157d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6326134495396782d, y: 0.8798515291647689d), new NpgsqlTypes.NpgsqlPoint(x: 0.40879162817029036d, y: 0.1964113449236159d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417568862683158d, y: 0.2850982148042561d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.615770585861795d, y: 0.3350676011116249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995850000757636d, y: 0.6609277429428106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948262567243869d, y: 0.3236692368036008d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7754036903555427d, y: 0.617495304579751d), new NpgsqlTypes.NpgsqlPoint(x: 0.05138051681471978d, y: 0.2390851274867758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165001626207193d, y: 0.45038467207663613d)),
},
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220282659566857d, y: 0.9440604608180148d), new NpgsqlTypes.NpgsqlPoint(x: 0.0725155728177248d, y: 0.42709014605145423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912812319625583d, y: 0.9925004679770106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7290732492168124d, y: 0.11380099908682495d), new NpgsqlTypes.NpgsqlPoint(x: 0.402465706368087d, y: 0.016047516210934143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744084489774618d, y: 0.4168478279951149d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7750434679282745d, y: 0.37808750994468765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231356263880008d, y: 0.785006118688627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595057294374101d, y: 0.5877149160715612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3368857331142794d, y: 0.935468048600345d), new NpgsqlTypes.NpgsqlPoint(x: 0.1867962387155322d, y: 0.29056380641989055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093510251261817d, y: 0.27104668808021193d)),
}));
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35438116324748536d, y: 0.805543715835287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163331758290569d, y: 0.7952148255574437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789816344497203d, y: 0.28771507277662134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9916488734048496d, y: 0.7894290349882747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476505395171203d, y: 0.5494497516643092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482415937673971d, y: 0.48600696654640785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23864533082836448d, y: 0.12025327344776815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568443048807916d, y: 0.4705766036237783d), new NpgsqlTypes.NpgsqlPoint(x: 0.046964772076220074d, y: 0.828575798748916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04157478373929324d, y: 0.7263600908895408d), new NpgsqlTypes.NpgsqlPoint(x: 0.04275049536140185d, y: 0.28854956362409034d), new NpgsqlTypes.NpgsqlPoint(x: 0.39109121839421623d, y: 0.22687239102321166d)),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7025273450352719d, y: 0.678178672320598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785135967630098d, y: 0.23373492769179072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450154948491774d, y: 0.1632761597870679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247515713450927d, y: 0.3131731731855817d), new NpgsqlTypes.NpgsqlPoint(x: 0.00591842670675391d, y: 0.5960658928577488d), new NpgsqlTypes.NpgsqlPoint(x: 0.05035810564057486d, y: 0.6154353844370449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013288889310789864d, y: 0.923368548803532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290500969014651d, y: 0.9007942489839175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064636826919155d, y: 0.47066515757307403d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523779244950862d, y: 0.016273755827803327d), new NpgsqlTypes.NpgsqlPoint(x: 0.22233966641039193d, y: 0.5997659200641944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042996575735515d, y: 0.6792431089557225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9784521265592959d, y: 0.9425903246988311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501239425470392d, y: 0.10119856086071788d), new NpgsqlTypes.NpgsqlPoint(x: 0.014029514481028516d, y: 0.007686972409373216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0665064786071935d, y: 0.776966797598073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3144877811410224d, y: 0.26939849333413546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620411224465879d, y: 0.9847080450403581d)),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 42, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatchAsync(connection, 24, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatch(connection, 51, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

