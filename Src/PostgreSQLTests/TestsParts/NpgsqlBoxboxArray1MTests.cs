

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
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9448831695532556d,right: 0.8877986448186983d,bottom: 0.7316294767406014d,left: 0.7862152114521427d),
new NpgsqlTypes.NpgsqlBox(top: 0.6842085371315988d,right: 0.8011302192121379d,bottom: 0.06249496113731401d,left: 0.7895736143244186d),
new NpgsqlTypes.NpgsqlBox(top: 0.19653289243917837d,right: 0.8431205995927381d,bottom: 0.08345668570554798d,left: 0.6695895461727772d),
new NpgsqlTypes.NpgsqlBox(top: 0.13039296885008633d,right: 0.6088233925676138d,bottom: 0.05431452628591671d,left: 0.5640100090614978d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23292348051919265d,right: 0.7868621868501289d,bottom: 0.08486251297664005d,left: 0.7646318339151065d),
new NpgsqlTypes.NpgsqlBox(top: 0.47442773660003335d,right: 0.7976515429503566d,bottom: 0.3064694523938811d,left: 0.22802082830283288d),
new NpgsqlTypes.NpgsqlBox(top: 0.47817021862535236d,right: 0.8413585612187972d,bottom: 0.12757026685443207d,left: 0.03251694851921638d),
new NpgsqlTypes.NpgsqlBox(top: 0.5940452881689421d,right: 0.7703552466394875d,bottom: 0.5152228471845209d,left: 0.6474794245513863d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7623491437331222d,right: 0.7854953645318891d,bottom: 0.7254072166704468d,left: 0.5856162457372146d),
new NpgsqlTypes.NpgsqlBox(top: 0.6753433283026185d,right: 0.8386924148258345d,bottom: 0.6255049337252633d,left: 0.7382478959226437d),
new NpgsqlTypes.NpgsqlBox(top: 0.41626944509562525d,right: 0.5619899055831136d,bottom: 0.37032521839013266d,left: 0.021807854299763285d),
new NpgsqlTypes.NpgsqlBox(top: 0.9172726558499836d,right: 0.8046504895128739d,bottom: 0.7979616944400385d,left: 0.007654242387918675d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9112385574150805d,right: 0.9350804014715248d,bottom: 0.7873310314326901d,left: 0.6650862468473637d),
new NpgsqlTypes.NpgsqlBox(top: 0.8883977991926912d,right: 0.8248609281538419d,bottom: 0.6747388570349518d,left: 0.673932379854042d),
new NpgsqlTypes.NpgsqlBox(top: 0.7962370395596876d,right: 0.524846559949455d,bottom: 0.497421915158752d,left: 0.494081113484218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7122395882259012d,right: 0.14323153455061777d,bottom: 0.23431657565543462d,left: 0.04521548732076763d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8598752989161795d,right: 0.4844262701675266d,bottom: 0.7814232746914876d,left: 0.44024695754677157d),
new NpgsqlTypes.NpgsqlBox(top: 0.37863978231806195d,right: 0.42170634772520343d,bottom: 0.3286603464634523d,left: 0.16131463158619574d),
new NpgsqlTypes.NpgsqlBox(top: 0.8546361062459779d,right: 0.9476158012937884d,bottom: 0.23572434759190475d,left: 0.9371219714783916d),
new NpgsqlTypes.NpgsqlBox(top: 0.8433694634313407d,right: 0.9984121704104524d,bottom: 0.017300007975589615d,left: 0.39673631381584673d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8363044435069741d,right: 0.920949596979856d,bottom: 0.2590782638177367d,left: 0.08245555539519234d),
new NpgsqlTypes.NpgsqlBox(top: 0.9155666913180414d,right: 0.4070126496640506d,bottom: 0.07990907732834818d,left: 0.3144298979354493d),
new NpgsqlTypes.NpgsqlBox(top: 0.9129299738664736d,right: 0.8253062261582634d,bottom: 0.0902816840396089d,left: 0.41514616204784816d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16110001456242573d,right: 0.9026177837167958d,bottom: 0.010017241738635163d,left: 0.8168719164202097d),
new NpgsqlTypes.NpgsqlBox(top: 0.40684954558295583d,right: 0.5823067332214261d,bottom: 0.05920882716255316d,left: 0.20566109806424082d),
new NpgsqlTypes.NpgsqlBox(top: 0.8084607890473188d,right: 0.4003720778999672d,bottom: 0.7492430475494225d,left: 0.2437149752710407d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19941189161838802d,right: 0.579887380620419d,bottom: 0.15976606549602101d,left: 0.4983044622745163d),
new NpgsqlTypes.NpgsqlBox(top: 0.7728779547038466d,right: 0.2053799808240615d,bottom: 0.05080200242252497d,left: 0.10656442852458037d),
new NpgsqlTypes.NpgsqlBox(top: 0.27669955559600035d,right: 0.6546317698103643d,bottom: 0.25006317993671323d,left: 0.3038116360898474d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7482799630093372d,right: 0.6110861416695216d,bottom: 0.15540767519431742d,left: 0.3653741720340701d),
new NpgsqlTypes.NpgsqlBox(top: 0.9061850673281849d,right: 0.10760044171447958d,bottom: 0.41659504782463674d,left: 0.06451043449368099d),
new NpgsqlTypes.NpgsqlBox(top: 0.8973888345678027d,right: 0.8707041684987566d,bottom: 0.6071527121067783d,left: 0.11111059503684217d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7710459527554105d,right: 0.6462808480818077d,bottom: 0.49965429177120757d,left: 0.45712320247796767d),
new NpgsqlTypes.NpgsqlBox(top: 0.6708974137886228d,right: 0.7005261620032113d,bottom: 0.5494306863988166d,left: 0.24210570819132193d),
new NpgsqlTypes.NpgsqlBox(top: 0.8268738372269503d,right: 0.48622084562381607d,bottom: 0.6969678043967369d,left: 0.05129151569955093d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5597041454202484d,right: 0.6410297219963438d,bottom: 0.22934536143366702d,left: 0.24684309812006644d),
new NpgsqlTypes.NpgsqlBox(top: 0.4390874904247075d,right: 0.8092457755548768d,bottom: 0.3615072180508867d,left: 0.5539269423203137d),
new NpgsqlTypes.NpgsqlBox(top: 0.7089049243356458d,right: 0.2971338412458334d,bottom: 0.35371346401154935d,left: 0.1588151121864908d),
new NpgsqlTypes.NpgsqlBox(top: 0.6268750103154817d,right: 0.4389447502489773d,bottom: 0.09757704158331526d,left: 0.4373039880203047d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9217670294837423d,right: 0.9876520028649367d,bottom: 0.5137138958664912d,left: 0.5682298081495405d),
new NpgsqlTypes.NpgsqlBox(top: 0.6635071738162748d,right: 0.7111228929113338d,bottom: 0.5053772248800092d,left: 0.35658859325832426d),
new NpgsqlTypes.NpgsqlBox(top: 0.9521898138315756d,right: 0.8207203785890511d,bottom: 0.1848504382320565d,left: 0.3857470889392848d),
new NpgsqlTypes.NpgsqlBox(top: 0.7557749281085232d,right: 0.9128318091812486d,bottom: 0.6991284226056622d,left: 0.19340561950412194d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.87537677191163d,right: 0.9337203016550176d,bottom: 0.8631892378150166d,left: 0.2515346949140125d),
new NpgsqlTypes.NpgsqlBox(top: 0.4567378809350091d,right: 0.9758085569297575d,bottom: 0.2929858404518588d,left: 0.4048098718467421d),
new NpgsqlTypes.NpgsqlBox(top: 0.9485103127528974d,right: 0.8710779181234476d,bottom: 0.49956202588709264d,left: 0.8437854368689849d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6072134825661087d,right: 0.8516447669846814d,bottom: 0.20710236720146924d,left: 0.6165234855607243d),
new NpgsqlTypes.NpgsqlBox(top: 0.7977551067533568d,right: 0.7432401685451101d,bottom: 0.5760926613196047d,left: 0.4063968897829403d),
new NpgsqlTypes.NpgsqlBox(top: 0.36463526586261663d,right: 0.8238475559884288d,bottom: 0.2879375199874388d,left: 0.2893029313528457d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3089485634100253d,right: 0.9176530893785663d,bottom: 0.08555806211600903d,left: 0.6593594401070751d),
new NpgsqlTypes.NpgsqlBox(top: 0.27991691881865355d,right: 0.6579076463867278d,bottom: 0.17764643037664873d,left: 0.5334854728119647d),
new NpgsqlTypes.NpgsqlBox(top: 0.4584878904427421d,right: 0.05444814234084605d,bottom: 0.11323341322303082d,left: 0.003948772238904441d),
new NpgsqlTypes.NpgsqlBox(top: 0.37904433542734495d,right: 0.8706878260057753d,bottom: 0.259656133785956d,left: 0.1420036047072738d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9621753230749349d,right: 0.25400700697643386d,bottom: 0.9274685088504434d,left: 0.06939534767031941d),
new NpgsqlTypes.NpgsqlBox(top: 0.14193110508299367d,right: 0.7615639949631102d,bottom: 0.12430629953124606d,left: 0.6442905772447223d),
new NpgsqlTypes.NpgsqlBox(top: 0.7132726284729037d,right: 0.46422227039467245d,bottom: 0.28794912339717305d,left: 0.059849224141456325d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.882831707169675d,right: 0.7219275712600292d,bottom: 0.5893076533032678d,left: 0.18600900715851443d),
new NpgsqlTypes.NpgsqlBox(top: 0.7896349475613651d,right: 0.8327372351506619d,bottom: 0.7702817990583783d,left: 0.6869159622138935d),
new NpgsqlTypes.NpgsqlBox(top: 0.781622420678645d,right: 0.416672479570773d,bottom: 0.16469658547426136d,left: 0.2227920348188881d),
new NpgsqlTypes.NpgsqlBox(top: 0.9252662551061168d,right: 0.8581562733577992d,bottom: 0.527037247029269d,left: 0.6415977511112934d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5534781730517425d,right: 0.3591691523789189d,bottom: 0.16702864184186206d,left: 0.31013766980132085d),
new NpgsqlTypes.NpgsqlBox(top: 0.813614912335123d,right: 0.9134219825207561d,bottom: 0.007527018487172521d,left: 0.7822492999023303d),
new NpgsqlTypes.NpgsqlBox(top: 0.8816592525751635d,right: 0.5856348565670737d,bottom: 0.5351619440843305d,left: 0.0030008636608737094d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.831836242506255d,right: 0.704161315191951d,bottom: 0.7826410544189168d,left: 0.5774024555163461d),
new NpgsqlTypes.NpgsqlBox(top: 0.7545232346656453d,right: 0.8514666011540867d,bottom: 0.5439858940827577d,left: 0.10910156826071749d),
new NpgsqlTypes.NpgsqlBox(top: 0.5955726782868346d,right: 0.7337926761311384d,bottom: 0.1726005935887832d,left: 0.13583259831745276d),
new NpgsqlTypes.NpgsqlBox(top: 0.4275710933585454d,right: 0.5991470289808312d,bottom: 0.268266812505205d,left: 0.04782902059467764d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8128181398954014d,right: 0.8347751724443306d,bottom: 0.6226572772358108d,left: 0.6465421468985003d),
new NpgsqlTypes.NpgsqlBox(top: 0.37905846968740997d,right: 0.8570436680764555d,bottom: 0.30596598916967443d,left: 0.10486315951261405d),
new NpgsqlTypes.NpgsqlBox(top: 0.6558067079660528d,right: 0.05905055405434534d,bottom: 0.3840327371636072d,left: 0.039497857606043074d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9759192687845561d,right: 0.9423715455934132d,bottom: 0.10491032454896543d,left: 0.9355149508995333d),
new NpgsqlTypes.NpgsqlBox(top: 0.47321353144956435d,right: 0.972697187707251d,bottom: 0.19052535963447936d,left: 0.8569370824263435d),
new NpgsqlTypes.NpgsqlBox(top: 0.9291992685400601d,right: 0.7845650696658298d,bottom: 0.5215975562910655d,left: 0.2940149249172548d),
new NpgsqlTypes.NpgsqlBox(top: 0.8904973224009612d,right: 0.6742108902315078d,bottom: 0.3998577318108876d,left: 0.54471015892765d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10861179540354149d,right: 0.8387145169249292d,bottom: 0.09578678696629606d,left: 0.7285837353061864d),
new NpgsqlTypes.NpgsqlBox(top: 0.362130343136716d,right: 0.2997529044808469d,bottom: 0.3049308643641053d,left: 0.23054506760087656d),
new NpgsqlTypes.NpgsqlBox(top: 0.9884164099753802d,right: 0.5065080085797016d,bottom: 0.07125382942203651d,left: 0.46859570280294693d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7140841025991826d,right: 0.9429737275759983d,bottom: 0.51449671476808d,left: 0.5240928173944184d),
new NpgsqlTypes.NpgsqlBox(top: 0.7145861090333673d,right: 0.7962402559461275d,bottom: 0.19585728812765713d,left: 0.3842993973248624d),
new NpgsqlTypes.NpgsqlBox(top: 0.996009683435604d,right: 0.8669753302529511d,bottom: 0.23277053572921214d,left: 0.007182882788425826d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8974993670407377d,right: 0.7444784971723455d,bottom: 0.19865547819196272d,left: 0.6443867074477384d),
new NpgsqlTypes.NpgsqlBox(top: 0.9074516980422005d,right: 0.7784002977429246d,bottom: 0.5442194833740736d,left: 0.48583660900454084d),
new NpgsqlTypes.NpgsqlBox(top: 0.5371561535147602d,right: 0.7128702541846748d,bottom: 0.37328465314331283d,left: 0.25552696054721413d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32575303405682743d,right: 0.8638072326469005d,bottom: 0.20833284427419319d,left: 0.8534008497095604d),
new NpgsqlTypes.NpgsqlBox(top: 0.5923738350075429d,right: 0.8929452004563092d,bottom: 0.35240376872607515d,left: 0.876660732307475d),
new NpgsqlTypes.NpgsqlBox(top: 0.6464698736747173d,right: 0.8602225277026689d,bottom: 0.6082509411061137d,left: 0.1269044505459287d),
new NpgsqlTypes.NpgsqlBox(top: 0.7259875725996074d,right: 0.8792439307882083d,bottom: 0.3436403991565724d,left: 0.4724243186338438d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8919032590176362d,right: 0.8699785764301685d,bottom: 0.42309057401096517d,left: 0.7257993234932891d),
new NpgsqlTypes.NpgsqlBox(top: 0.9258819416872223d,right: 0.5425984250128965d,bottom: 0.42610147487499606d,left: 0.12778693745299874d),
new NpgsqlTypes.NpgsqlBox(top: 0.7059601788563556d,right: 0.4570479630865859d,bottom: 0.08661103469050269d,left: 0.33628934748411754d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7514742802773172d,right: 0.8745013139616535d,bottom: 0.49963388250459795d,left: 0.575941083329404d),
new NpgsqlTypes.NpgsqlBox(top: 0.9927630501294933d,right: 0.7156708785974146d,bottom: 0.7195698015817082d,left: 0.27793901996444603d),
new NpgsqlTypes.NpgsqlBox(top: 0.8825191541553287d,right: 0.28082401039809324d,bottom: 0.2656134477717399d,left: 0.09797020247270061d),
new NpgsqlTypes.NpgsqlBox(top: 0.5897739026213054d,right: 0.4909320596918566d,bottom: 0.28972440461727933d,left: 0.4671007532104833d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19716158785178117d,right: 0.6522020257830019d,bottom: 0.05680686182577199d,left: 0.392450402614936d),
new NpgsqlTypes.NpgsqlBox(top: 0.338181690812999d,right: 0.14649101907678963d,bottom: 0.1563845291915792d,left: 0.041327522990535104d),
new NpgsqlTypes.NpgsqlBox(top: 0.3269247208222066d,right: 0.5407734152622555d,bottom: 0.24413069889881855d,left: 0.33847441656978317d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9088960309753631d,right: 0.5372709633215256d,bottom: 0.26991420610169925d,left: 0.16677175631232777d),
new NpgsqlTypes.NpgsqlBox(top: 0.16830553676628646d,right: 0.5718867364042093d,bottom: 0.01624293077837058d,left: 0.05069276427982894d),
new NpgsqlTypes.NpgsqlBox(top: 0.8337404049238757d,right: 0.8909510992628156d,bottom: 0.7546086423153195d,left: 0.6837433189993023d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25000452325096467d,right: 0.780654818349597d,bottom: 0.24079373907939028d,left: 0.510671473504932d),
new NpgsqlTypes.NpgsqlBox(top: 0.6553525301302436d,right: 0.8189636143577771d,bottom: 0.6041952274450855d,left: 0.7341560250673371d),
new NpgsqlTypes.NpgsqlBox(top: 0.11472108932714786d,right: 0.5336783031784104d,bottom: 0.06199580340978261d,left: 0.35659136015296855d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6520834320653002d,right: 0.49677157730818877d,bottom: 0.36008734542037235d,left: 0.2936510090576965d),
new NpgsqlTypes.NpgsqlBox(top: 0.7631900687091608d,right: 0.532312709757271d,bottom: 0.6383518083177661d,left: 0.37746343257363524d),
new NpgsqlTypes.NpgsqlBox(top: 0.8187514490730506d,right: 0.7190866144668177d,bottom: 0.41326165760245737d,left: 0.5835831597648388d),
new NpgsqlTypes.NpgsqlBox(top: 0.7184592788063999d,right: 0.4888588928587545d,bottom: 0.3615616678533352d,left: 0.06639193558820944d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3354839396669026d,right: 0.9811656578555575d,bottom: 0.16178782041363782d,left: 0.5807958375589726d),
new NpgsqlTypes.NpgsqlBox(top: 0.47238241685854776d,right: 0.8860094902121116d,bottom: 0.2496479633604458d,left: 0.8648022901416763d),
new NpgsqlTypes.NpgsqlBox(top: 0.4366821007663566d,right: 0.6598615667170292d,bottom: 0.28842519910957043d,left: 0.5555448503507939d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8572844216920145d,right: 0.15949727840378336d,bottom: 0.4647431864004836d,left: 0.00797464652752522d),
new NpgsqlTypes.NpgsqlBox(top: 0.9168986330831748d,right: 0.6151665329150461d,bottom: 0.49215361991956785d,left: 0.17158613923742816d),
new NpgsqlTypes.NpgsqlBox(top: 0.22885813221020834d,right: 0.7532192561679241d,bottom: 0.04688294497048806d,left: 0.36036211883070646d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5853631043837206d,right: 0.8498278358813316d,bottom: 0.15552236170296407d,left: 0.3796535270346756d),
new NpgsqlTypes.NpgsqlBox(top: 0.8953137535293015d,right: 0.9467235397647655d,bottom: 0.7908641317421915d,left: 0.3153004003559977d),
new NpgsqlTypes.NpgsqlBox(top: 0.9028303870514178d,right: 0.35728656910502177d,bottom: 0.09986354391778618d,left: 0.07618432606083791d),
new NpgsqlTypes.NpgsqlBox(top: 0.6049576331389961d,right: 0.3398096978092682d,bottom: 0.37768721788716664d,left: 0.2048892870497937d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9686873609266229d,right: 0.9604754028665482d,bottom: 0.10261392248578394d,left: 0.5779406464853543d),
new NpgsqlTypes.NpgsqlBox(top: 0.06362985218315187d,right: 0.5188603690824625d,bottom: 0.011393166850907743d,left: 0.33315968533571294d),
new NpgsqlTypes.NpgsqlBox(top: 0.989306238102579d,right: 0.6144095770561179d,bottom: 0.738927429533491d,left: 0.48074552151201655d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9504196854651641d,right: 0.43913444863924045d,bottom: 0.41321371108648786d,left: 0.15064348965961638d),
new NpgsqlTypes.NpgsqlBox(top: 0.6642642221123358d,right: 0.3883752918353439d,bottom: 0.1800693292202573d,left: 0.19961721228040086d),
new NpgsqlTypes.NpgsqlBox(top: 0.9135367907413008d,right: 0.9154661455323965d,bottom: 0.2285530358993233d,left: 0.8482622998621164d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9762280463047025d,right: 0.718373844235591d,bottom: 0.309188696229049d,left: 0.20359336210846912d),
new NpgsqlTypes.NpgsqlBox(top: 0.8211641356580863d,right: 0.6288731228332342d,bottom: 0.3062695681819253d,left: 0.48138620219202d),
new NpgsqlTypes.NpgsqlBox(top: 0.9956136677246937d,right: 0.7917947803108377d,bottom: 0.9433190342747968d,left: 0.6234731372677895d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47642668384223497d,right: 0.9111126250555338d,bottom: 0.047838576836664815d,left: 0.18790854363202625d),
new NpgsqlTypes.NpgsqlBox(top: 0.08611777822485467d,right: 0.19095032043840443d,bottom: 0.03549325093892641d,left: 0.10419596583426627d),
new NpgsqlTypes.NpgsqlBox(top: 0.6531167329168527d,right: 0.9588668533723511d,bottom: 0.4885594155233074d,left: 0.36443302387740073d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7817111079005543d,right: 0.8388560489969792d,bottom: 0.725771093338887d,left: 0.30281228236227276d),
new NpgsqlTypes.NpgsqlBox(top: 0.8800867870260538d,right: 0.6851442158203027d,bottom: 0.6285327659878635d,left: 0.5929033064265317d),
new NpgsqlTypes.NpgsqlBox(top: 0.29337451061750575d,right: 0.10548582960402542d,bottom: 0.24351642728324507d,left: 0.06199474847029485d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6385967585592576d,right: 0.7414356051636775d,bottom: 0.5008044918968396d,left: 0.5152973071296928d),
new NpgsqlTypes.NpgsqlBox(top: 0.8595608494445d,right: 0.6698031431290197d,bottom: 0.7644947704820565d,left: 0.27641560840376256d),
new NpgsqlTypes.NpgsqlBox(top: 0.8773469104106282d,right: 0.7862811634735315d,bottom: 0.2593848335155724d,left: 0.6643176666501119d),
new NpgsqlTypes.NpgsqlBox(top: 0.6353959720896175d,right: 0.24557724938539682d,bottom: 0.458627091924263d,left: 0.12858694917699398d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5273523829474484d,right: 0.454457576667445d,bottom: 0.33496295321506386d,left: 0.018792477004608288d),
new NpgsqlTypes.NpgsqlBox(top: 0.737682171038618d,right: 0.6892548388256788d,bottom: 0.40536781971094715d,left: 0.5693646005953458d),
new NpgsqlTypes.NpgsqlBox(top: 0.21019354501245924d,right: 0.7559695639888074d,bottom: 0.09155161048538518d,left: 0.21428789621026312d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.635062048209811d,right: 0.5994326738509284d,bottom: 0.13771284825343322d,left: 0.32841599081357054d),
new NpgsqlTypes.NpgsqlBox(top: 0.45389799950316856d,right: 0.477731020990688d,bottom: 0.429872937009496d,left: 0.3483508136774772d),
new NpgsqlTypes.NpgsqlBox(top: 0.49626921825258974d,right: 0.5749881283665044d,bottom: 0.3263951471696461d,left: 0.5212677820988996d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8660772644654727d,right: 0.987430912849172d,bottom: 0.11161857753300664d,left: 0.8701233464949909d),
new NpgsqlTypes.NpgsqlBox(top: 0.49619773846054016d,right: 0.7625915001287901d,bottom: 0.42240649196825575d,left: 0.34393608423621536d),
new NpgsqlTypes.NpgsqlBox(top: 0.4228775490033837d,right: 0.979681907540696d,bottom: 0.3788421998071524d,left: 0.5219464781083145d),
new NpgsqlTypes.NpgsqlBox(top: 0.8473008908034593d,right: 0.5258530995028058d,bottom: 0.7781143027232658d,left: 0.1409878181976767d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6720659772785837d,right: 0.3874010839862453d,bottom: 0.15818237958650883d,left: 0.1159414216276311d),
new NpgsqlTypes.NpgsqlBox(top: 0.6029597929507344d,right: 0.9667989313239375d,bottom: 0.3173551414871414d,left: 0.027465729265571337d),
new NpgsqlTypes.NpgsqlBox(top: 0.7911304157205508d,right: 0.4350240512578395d,bottom: 0.4300517575262862d,left: 0.34748918693795894d),
new NpgsqlTypes.NpgsqlBox(top: 0.32429674965928323d,right: 0.6362725911589323d,bottom: 0.14068080641061398d,left: 0.5066058549629606d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7276144400834198d,right: 0.9016118064857348d,bottom: 0.39236693707860737d,left: 0.5282569472422289d),
new NpgsqlTypes.NpgsqlBox(top: 0.529194018269494d,right: 0.7879873166717629d,bottom: 0.1665923241936288d,left: 0.5004189630639335d),
new NpgsqlTypes.NpgsqlBox(top: 0.4683900551788601d,right: 0.552461225711351d,bottom: 0.4200997636594762d,left: 0.30004136898276146d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9740571459462075d,right: 0.8603549826828902d,bottom: 0.03682722206875966d,left: 0.08755964911421854d),
new NpgsqlTypes.NpgsqlBox(top: 0.18344865596731452d,right: 0.8965933134701272d,bottom: 0.16610521428803582d,left: 0.8899364260239733d),
new NpgsqlTypes.NpgsqlBox(top: 0.7960550486941066d,right: 0.32380178413179195d,bottom: 0.011730050793297031d,left: 0.008184778070242538d),
new NpgsqlTypes.NpgsqlBox(top: 0.6581238559609871d,right: 0.8422276932281186d,bottom: 0.28449842699118055d,left: 0.005849009255579851d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.39140285212249015d,right: 0.7525150756793156d,bottom: 0.07681364050389239d,left: 0.636941719397663d),
new NpgsqlTypes.NpgsqlBox(top: 0.7337542161907021d,right: 0.9037019525089038d,bottom: 0.6529853685115679d,left: 0.4844260532327721d),
new NpgsqlTypes.NpgsqlBox(top: 0.33108179486271283d,right: 0.8673974892126977d,bottom: 0.13281103663524785d,left: 0.6817311515671955d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9356490606882744d,right: 0.7212930064416823d,bottom: 0.18899786499977533d,left: 0.03206565643257642d),
new NpgsqlTypes.NpgsqlBox(top: 0.5405930457466384d,right: 0.9279972229569389d,bottom: 0.42443106678281206d,left: 0.9269657399101775d),
new NpgsqlTypes.NpgsqlBox(top: 0.5673062636310107d,right: 0.8930595899156445d,bottom: 0.15442170023066826d,left: 0.04066076207187852d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5947867572762164d,right: 0.3399212019354052d,bottom: 0.042556475514981096d,left: 0.23821896099831663d),
new NpgsqlTypes.NpgsqlBox(top: 0.609451219099708d,right: 0.3539806807494298d,bottom: 0.09416166165361195d,left: 0.10059928007828034d),
new NpgsqlTypes.NpgsqlBox(top: 0.5150256770508289d,right: 0.8948644788589921d,bottom: 0.2936195303639847d,left: 0.084009206171487d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6984133828983426d,right: 0.6940549289088144d,bottom: 0.2903056474805743d,left: 0.4121134026348059d),
new NpgsqlTypes.NpgsqlBox(top: 0.37907509065697476d,right: 0.37639728955149554d,bottom: 0.006992533034561044d,left: 0.0730010141980284d),
new NpgsqlTypes.NpgsqlBox(top: 0.6960479813815683d,right: 0.8387573605210309d,bottom: 0.1631604405075966d,left: 0.310572503375134d),
new NpgsqlTypes.NpgsqlBox(top: 0.273778858495883d,right: 0.2715958341524767d,bottom: 0.26645259882681105d,left: 0.17539392228994422d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7064038351282139d,right: 0.6119132956284576d,bottom: 0.5288088038774793d,left: 0.03768613642992702d),
new NpgsqlTypes.NpgsqlBox(top: 0.5767407773561011d,right: 0.4369112237999435d,bottom: 0.37893129340597986d,left: 0.04878145109623244d),
new NpgsqlTypes.NpgsqlBox(top: 0.6393835614801854d,right: 0.7978012039158876d,bottom: 0.250036033565987d,left: 0.33030700539098445d),
new NpgsqlTypes.NpgsqlBox(top: 0.35163663991203686d,right: 0.9606271986591911d,bottom: 0.34743459091976614d,left: 0.2665495395221549d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48442718393778383d,right: 0.5230186987443567d,bottom: 0.3158058210117608d,left: 0.16284300515991457d),
new NpgsqlTypes.NpgsqlBox(top: 0.801497719078613d,right: 0.7199068999842886d,bottom: 0.7057791349543274d,left: 0.07685142943238343d),
new NpgsqlTypes.NpgsqlBox(top: 0.7970377249669416d,right: 0.5743244350339927d,bottom: 0.18026890682112673d,left: 0.007689532727998882d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.28020518437818254d,right: 0.9564882108747065d,bottom: 0.03791318690435441d,left: 0.5560676219398132d),
new NpgsqlTypes.NpgsqlBox(top: 0.7651183176626724d,right: 0.9069403318685676d,bottom: 0.6143249811410066d,left: 0.7008600579067478d),
new NpgsqlTypes.NpgsqlBox(top: 0.6047678778610454d,right: 0.9745135701308741d,bottom: 0.1382737730250736d,left: 0.27670574698796957d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5558177577562134d,right: 0.6616514778426809d,bottom: 0.4619331946995464d,left: 0.10408118114682408d),
new NpgsqlTypes.NpgsqlBox(top: 0.6477957293658694d,right: 0.5898117348493885d,bottom: 0.463979056298119d,left: 0.09998388623526744d),
new NpgsqlTypes.NpgsqlBox(top: 0.5389486087566908d,right: 0.2148215679033345d,bottom: 0.33683416095795105d,left: 0.01143429998022838d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8594218019476437d,right: 0.6832878796662479d,bottom: 0.7967198291430949d,left: 0.14708613469422627d),
new NpgsqlTypes.NpgsqlBox(top: 0.40192271295367843d,right: 0.6603352805609132d,bottom: 0.37043684925284215d,left: 0.45493620337918983d),
new NpgsqlTypes.NpgsqlBox(top: 0.8200470147414284d,right: 0.9803797987444496d,bottom: 0.48006107092133776d,left: 0.31859334550859664d),
new NpgsqlTypes.NpgsqlBox(top: 0.9878583378676619d,right: 0.7733634534268653d,bottom: 0.4502052377467224d,left: 0.15366026034046876d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6789975706587694d,right: 0.4985727212563501d,bottom: 0.26924199506771296d,left: 0.33968084982674085d),
new NpgsqlTypes.NpgsqlBox(top: 0.9402761663307974d,right: 0.2439658750463951d,bottom: 0.0834836263853952d,left: 0.178314543583438d),
new NpgsqlTypes.NpgsqlBox(top: 0.5056866853186728d,right: 0.7058678897167947d,bottom: 0.45970146604411743d,left: 0.10395778309354853d),
new NpgsqlTypes.NpgsqlBox(top: 0.3227524617039783d,right: 0.6709457427000435d,bottom: 0.13694086904683223d,left: 0.17034334375125149d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2500746836043225d,right: 0.3734264626007726d,bottom: 0.04734193821136268d,left: 0.307864963371292d),
new NpgsqlTypes.NpgsqlBox(top: 0.9787951042372374d,right: 0.8222554621385654d,bottom: 0.47446613785426783d,left: 0.3710958964738448d),
new NpgsqlTypes.NpgsqlBox(top: 0.6518853762952487d,right: 0.8776504392472109d,bottom: 0.47460168805699676d,left: 0.12178467308702767d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.11145998840411986d,right: 0.8363364267741312d,bottom: 0.05789716595728234d,left: 0.4503450368861157d),
new NpgsqlTypes.NpgsqlBox(top: 0.6957153754894742d,right: 0.6818818871878645d,bottom: 0.36395962187436814d,left: 0.20421305723448224d),
new NpgsqlTypes.NpgsqlBox(top: 0.39374308555992377d,right: 0.9740055459944627d,bottom: 0.028744684375707097d,left: 0.5482970102104131d),
new NpgsqlTypes.NpgsqlBox(top: 0.796270149923775d,right: 0.5437662673637784d,bottom: 0.20307965549890883d,left: 0.5257693127454145d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8020606212048738d,right: 0.9742111108542211d,bottom: 0.18550668238691082d,left: 0.3840840739208863d),
new NpgsqlTypes.NpgsqlBox(top: 0.6519767587199943d,right: 0.4855102781005539d,bottom: 0.22787745512284918d,left: 0.4005236189554262d),
new NpgsqlTypes.NpgsqlBox(top: 0.5291857919137318d,right: 0.6361710600418881d,bottom: 0.48471838849346016d,left: 0.09230443933868504d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9386979963900518d,right: 0.9383771936141341d,bottom: 0.15701974351209036d,left: 0.33715542855969216d),
new NpgsqlTypes.NpgsqlBox(top: 0.2423848211473516d,right: 0.9585094539195956d,bottom: 0.13431531901036164d,left: 0.3830691842481241d),
new NpgsqlTypes.NpgsqlBox(top: 0.8070586271638513d,right: 0.12646657516255444d,bottom: 0.5240880007001444d,left: 0.12604160920418161d),
new NpgsqlTypes.NpgsqlBox(top: 0.6552058994852695d,right: 0.8897678995370236d,bottom: 0.0183544491775518d,left: 0.6332645808360574d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1806907760414035d,right: 0.6926752340237039d,bottom: 0.015361547903992911d,left: 0.21824299163105543d),
new NpgsqlTypes.NpgsqlBox(top: 0.6353522856920824d,right: 0.7068115894341552d,bottom: 0.35510968622502426d,left: 0.19757958082161475d),
new NpgsqlTypes.NpgsqlBox(top: 0.44870309121454555d,right: 0.929773863499324d,bottom: 0.008170301583293238d,left: 0.44438845919722647d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9465192950411835d,right: 0.22341554792539875d,bottom: 0.3063223652023028d,left: 0.11832027393284927d),
new NpgsqlTypes.NpgsqlBox(top: 0.9381646137817108d,right: 0.7719471908256149d,bottom: 0.37715969290543916d,left: 0.3612718031698051d),
new NpgsqlTypes.NpgsqlBox(top: 0.8190240974492483d,right: 0.6416843960696658d,bottom: 0.5279749087285517d,left: 0.38845877181845057d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.838827077828376d,right: 0.1598138258176962d,bottom: 0.5682079472414042d,left: 0.0489783870743723d),
new NpgsqlTypes.NpgsqlBox(top: 0.8234749219879779d,right: 0.5868048076329511d,bottom: 0.20213099658665734d,left: 0.5539328249410117d),
new NpgsqlTypes.NpgsqlBox(top: 0.4751086043877092d,right: 0.6949836223784809d,bottom: 0.18539871863873392d,left: 0.6677096615227515d),
new NpgsqlTypes.NpgsqlBox(top: 0.8947147539362071d,right: 0.1313185790664093d,bottom: 0.10932167486611166d,left: 0.026773819904400642d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9571440404120138d,right: 0.20036282108614678d,bottom: 0.5379081275836082d,left: 0.09256949630523748d),
new NpgsqlTypes.NpgsqlBox(top: 0.8281401264657678d,right: 0.8898808832651306d,bottom: 0.02743718510249893d,left: 0.1593350929232379d),
new NpgsqlTypes.NpgsqlBox(top: 0.889815874658355d,right: 0.6094485193433588d,bottom: 0.11271877358069848d,left: 0.05856013128558346d),
new NpgsqlTypes.NpgsqlBox(top: 0.9308878477275115d,right: 0.756677142741927d,bottom: 0.19309882926255761d,left: 0.46105189604065555d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9605932054883335d,right: 0.9638233892207174d,bottom: 0.4981121844516173d,left: 0.6148060829091969d),
new NpgsqlTypes.NpgsqlBox(top: 0.9254042371008312d,right: 0.6008059962664114d,bottom: 0.09922972225981375d,left: 0.3033566421888836d),
new NpgsqlTypes.NpgsqlBox(top: 0.6443765613203418d,right: 0.8960399703257299d,bottom: 0.34808728466236405d,left: 0.3751402367488057d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9017278794667417d,right: 0.5078258020880215d,bottom: 0.12682075184412622d,left: 0.11662358791281358d),
new NpgsqlTypes.NpgsqlBox(top: 0.6829314540141023d,right: 0.43671073374417524d,bottom: 0.5283700764712556d,left: 0.378294605394656d),
new NpgsqlTypes.NpgsqlBox(top: 0.9204347553928343d,right: 0.43946630159309763d,bottom: 0.7787069856057102d,left: 0.31330315026104794d),
new NpgsqlTypes.NpgsqlBox(top: 0.8970322270571278d,right: 0.8895733273007062d,bottom: 0.7951889245984392d,left: 0.8455024385630935d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3887320185138158d,right: 0.4816789427189413d,bottom: 0.015053495813387663d,left: 0.05153708491999409d),
new NpgsqlTypes.NpgsqlBox(top: 0.21814351559142076d,right: 0.9903303461180443d,bottom: 0.02010914765474947d,left: 0.4531897217322455d),
new NpgsqlTypes.NpgsqlBox(top: 0.7330321708321398d,right: 0.6403988256526995d,bottom: 0.19302774218419738d,left: 0.5929793151338759d),
new NpgsqlTypes.NpgsqlBox(top: 0.9871810910466672d,right: 0.8355635744511609d,bottom: 0.8843210294732962d,left: 0.338291720995866d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7571923212266747d,right: 0.14878785641269465d,bottom: 0.24563513132600212d,left: 0.012874067105643427d),
new NpgsqlTypes.NpgsqlBox(top: 0.3365439008794413d,right: 0.9706816539268152d,bottom: 0.3222410903740103d,left: 0.8138853410433656d),
new NpgsqlTypes.NpgsqlBox(top: 0.11231380104373523d,right: 0.8043873404718593d,bottom: 0.07991204422342257d,left: 0.09755955186534537d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.73029462801891d,right: 0.33142224992769753d,bottom: 0.3486252813313402d,left: 0.06305788108894173d),
new NpgsqlTypes.NpgsqlBox(top: 0.7749053973513065d,right: 0.7653134609439353d,bottom: 0.04318255499891521d,left: 0.37858627962611857d),
new NpgsqlTypes.NpgsqlBox(top: 0.4718999128949414d,right: 0.8939503165640641d,bottom: 0.03462458035540705d,left: 0.22556217032435888d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 189,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9575956013130261d,right: 0.9699034502626235d,bottom: 0.5894856793536266d,left: 0.9213116225204702d),
new NpgsqlTypes.NpgsqlBox(top: 0.2696165833056283d,right: 0.9264637675299575d,bottom: 0.07585014840423121d,left: 0.8319144834508544d),
new NpgsqlTypes.NpgsqlBox(top: 0.974855312545589d,right: 0.8017333537073505d,bottom: 0.44750240450721845d,left: 0.3651025188157847d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.603621489006725d,right: 0.08085982051194607d,bottom: 0.5196837899133929d,left: 0.0255562978389402d),
new NpgsqlTypes.NpgsqlBox(top: 0.7981167517215778d,right: 0.1638128889105045d,bottom: 0.07050210343425944d,left: 0.09611495050981045d),
new NpgsqlTypes.NpgsqlBox(top: 0.6315328115596176d,right: 0.8355094642854191d,bottom: 0.03950010233205348d,left: 0.7455026762622435d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6047483544648103d,right: 0.9765620517567567d,bottom: 0.07322365608901382d,left: 0.43455302571236487d),
new NpgsqlTypes.NpgsqlBox(top: 0.8875369601808726d,right: 0.7302065131771676d,bottom: 0.32873468113252213d,left: 0.08532817103059442d),
new NpgsqlTypes.NpgsqlBox(top: 0.9975931950426075d,right: 0.38952478837987026d,bottom: 0.8137018079044217d,left: 0.28702638969708305d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8371980382969912d,right: 0.988083702748276d,bottom: 0.7522941296487083d,left: 0.5610084182264418d),
new NpgsqlTypes.NpgsqlBox(top: 0.9389449050409034d,right: 0.38411929302241155d,bottom: 0.7608017781336706d,left: 0.21003589331012174d),
new NpgsqlTypes.NpgsqlBox(top: 0.8642168892525557d,right: 0.8746908364738695d,bottom: 0.3845928971194943d,left: 0.433563733271217d),
new NpgsqlTypes.NpgsqlBox(top: 0.503997590856107d,right: 0.9801153798372683d,bottom: 0.4662524098317188d,left: 0.12530910490660196d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 199,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9220794808501586d,right: 0.8533484677436495d,bottom: 0.8937022474025805d,left: 0.23706694670018236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9021084057861342d,right: 0.7822121494119953d,bottom: 0.6497271977498836d,left: 0.5514316415649078d),
new NpgsqlTypes.NpgsqlBox(top: 0.569217416574465d,right: 0.4596510134370406d,bottom: 0.23078324526292682d,left: 0.2885269955503096d),
new NpgsqlTypes.NpgsqlBox(top: 0.2315992039914454d,right: 0.8802671913647402d,bottom: 0.05602033629344372d,left: 0.5242667295921055d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5722339681573605d,right: 0.25955944432105615d,bottom: 0.1490067745741387d,left: 0.1537759460825413d),
new NpgsqlTypes.NpgsqlBox(top: 0.4447566766776344d,right: 0.5743647284817301d,bottom: 0.35862373648366574d,left: 0.0673035656396902d),
new NpgsqlTypes.NpgsqlBox(top: 0.8938043403504534d,right: 0.22529608275243684d,bottom: 0.17644864939038907d,left: 0.022242215042555524d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 206,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3233299297830219d,right: 0.5289488801770631d,bottom: 0.016649300233053888d,left: 0.08446514738525535d),
new NpgsqlTypes.NpgsqlBox(top: 0.33951929935498115d,right: 0.8001376200997613d,bottom: 0.13591182292014292d,left: 0.044396257688312235d),
new NpgsqlTypes.NpgsqlBox(top: 0.13015361478134724d,right: 0.11089699795846819d,bottom: 0.042948902034909864d,left: 0.005794390530317717d),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5534781730517425d,right: 0.3591691523789189d,bottom: 0.16702864184186206d,left: 0.31013766980132085d),
new NpgsqlTypes.NpgsqlBox(top: 0.813614912335123d,right: 0.9134219825207561d,bottom: 0.007527018487172521d,left: 0.7822492999023303d),
new NpgsqlTypes.NpgsqlBox(top: 0.8816592525751635d,right: 0.5856348565670737d,bottom: 0.5351619440843305d,left: 0.0030008636608737094d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8128181398954014d,right: 0.8347751724443306d,bottom: 0.6226572772358108d,left: 0.6465421468985003d),
new NpgsqlTypes.NpgsqlBox(top: 0.37905846968740997d,right: 0.8570436680764555d,bottom: 0.30596598916967443d,left: 0.10486315951261405d),
new NpgsqlTypes.NpgsqlBox(top: 0.6558067079660528d,right: 0.05905055405434534d,bottom: 0.3840327371636072d,left: 0.039497857606043074d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7140841025991826d,right: 0.9429737275759983d,bottom: 0.51449671476808d,left: 0.5240928173944184d),
new NpgsqlTypes.NpgsqlBox(top: 0.7145861090333673d,right: 0.7962402559461275d,bottom: 0.19585728812765713d,left: 0.3842993973248624d),
new NpgsqlTypes.NpgsqlBox(top: 0.996009683435604d,right: 0.8669753302529511d,bottom: 0.23277053572921214d,left: 0.007182882788425826d),
}));
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
new NpgsqlTypes.NpgsqlBox(top: 0.32575303405682743d,right: 0.8638072326469005d,bottom: 0.20833284427419319d,left: 0.8534008497095604d),
new NpgsqlTypes.NpgsqlBox(top: 0.5923738350075429d,right: 0.8929452004563092d,bottom: 0.35240376872607515d,left: 0.876660732307475d),
new NpgsqlTypes.NpgsqlBox(top: 0.6464698736747173d,right: 0.8602225277026689d,bottom: 0.6082509411061137d,left: 0.1269044505459287d),
new NpgsqlTypes.NpgsqlBox(top: 0.7259875725996074d,right: 0.8792439307882083d,bottom: 0.3436403991565724d,left: 0.4724243186338438d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19716158785178117d,right: 0.6522020257830019d,bottom: 0.05680686182577199d,left: 0.392450402614936d),
new NpgsqlTypes.NpgsqlBox(top: 0.338181690812999d,right: 0.14649101907678963d,bottom: 0.1563845291915792d,left: 0.041327522990535104d),
new NpgsqlTypes.NpgsqlBox(top: 0.3269247208222066d,right: 0.5407734152622555d,bottom: 0.24413069889881855d,left: 0.33847441656978317d),
}));
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
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
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
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 180;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 164;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 189;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[34], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 164, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 193, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 172, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 193, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 164, query1, 189, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 193, 180))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 100, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

