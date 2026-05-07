

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
new NpgsqlTypes.NpgsqlBox(top: 0.655871951820463d,right: 0.8139129422871888d,bottom: 0.3025302972735612d,left: 0.4092317633374626d),
new NpgsqlTypes.NpgsqlBox(top: 0.987669953861638d,right: 0.9705717484088487d,bottom: 0.08421898067411338d,left: 0.9638021320880106d),
new NpgsqlTypes.NpgsqlBox(top: 0.8736518431896577d,right: 0.6039805908425357d,bottom: 0.7524130871610983d,left: 0.576025794331167d),
new NpgsqlTypes.NpgsqlBox(top: 0.9929362962830861d,right: 0.8261478783278958d,bottom: 0.7301605649779658d,left: 0.25250180391363297d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6920652346536499d,right: 0.9541428906048518d,bottom: 0.4626154930951786d,left: 0.2761086303432715d),
new NpgsqlTypes.NpgsqlBox(top: 0.739322788831576d,right: 0.311904103952819d,bottom: 0.5299148400684732d,left: 0.28238789619754967d),
new NpgsqlTypes.NpgsqlBox(top: 0.4927015563007232d,right: 0.6041430449987595d,bottom: 0.30861540539664667d,left: 0.367072301662172d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.919398552705637d,right: 0.3265623252345011d,bottom: 0.8432283346990556d,left: 0.2130604129236925d),
new NpgsqlTypes.NpgsqlBox(top: 0.6400421665983511d,right: 0.45512059232865565d,bottom: 0.27616908295379083d,left: 0.10043265947438218d),
new NpgsqlTypes.NpgsqlBox(top: 0.8575464440743042d,right: 0.7537378182557863d,bottom: 0.8481654208855378d,left: 0.1950969217223567d),
new NpgsqlTypes.NpgsqlBox(top: 0.4292816439216127d,right: 0.793478815309548d,bottom: 0.0438439334514078d,left: 0.5470718093608734d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5035238628548717d,right: 0.874740313620492d,bottom: 0.2591228529425136d,left: 0.6245039898721608d),
new NpgsqlTypes.NpgsqlBox(top: 0.896456500613682d,right: 0.5024134527828346d,bottom: 0.7772269391984044d,left: 0.41579706955506146d),
new NpgsqlTypes.NpgsqlBox(top: 0.9987933730573632d,right: 0.6066538187856811d,bottom: 0.3444264468911138d,left: 0.18745992109920417d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6538499666890766d,right: 0.8714940035979422d,bottom: 0.5127158843862866d,left: 0.7548527433027837d),
new NpgsqlTypes.NpgsqlBox(top: 0.525011449909989d,right: 0.7436548637995234d,bottom: 0.0731043658687438d,left: 0.504093309968911d),
new NpgsqlTypes.NpgsqlBox(top: 0.774662848576635d,right: 0.8505913709585439d,bottom: 0.7525774654896095d,left: 0.3025579623463909d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9016012390842042d,right: 0.3023696451467477d,bottom: 0.4855638561360204d,left: 0.22900193902170884d),
new NpgsqlTypes.NpgsqlBox(top: 0.9740990906605422d,right: 0.5191701862186608d,bottom: 0.25081210305145485d,left: 0.43928893123980894d),
new NpgsqlTypes.NpgsqlBox(top: 0.9355752980714688d,right: 0.9307883139143227d,bottom: 0.9023873036857932d,left: 0.7644295529934386d),
new NpgsqlTypes.NpgsqlBox(top: 0.7390151384148613d,right: 0.7089459665248765d,bottom: 0.35232103600782216d,left: 0.630453847133301d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.84548006725166d,right: 0.471563147243486d,bottom: 0.4273729735238213d,left: 0.07942090669967172d),
new NpgsqlTypes.NpgsqlBox(top: 0.7177853951372114d,right: 0.3713285948690709d,bottom: 0.597459900719584d,left: 0.12126153140991869d),
new NpgsqlTypes.NpgsqlBox(top: 0.2614296283159202d,right: 0.48768187491339965d,bottom: 0.1644805174480911d,left: 0.3118328681973819d),
new NpgsqlTypes.NpgsqlBox(top: 0.8167809261782906d,right: 0.5758098594039233d,bottom: 0.5741834212626439d,left: 0.3396358096750772d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8862349690707039d,right: 0.7388123793040859d,bottom: 0.7597308034386099d,left: 0.20700718381524263d),
new NpgsqlTypes.NpgsqlBox(top: 0.2515443648179081d,right: 0.8209997165028156d,bottom: 0.16236871178908263d,left: 0.2626090576530947d),
new NpgsqlTypes.NpgsqlBox(top: 0.641390574682159d,right: 0.9546881273972753d,bottom: 0.3045447916408588d,left: 0.03210402673194146d),
new NpgsqlTypes.NpgsqlBox(top: 0.701363565859834d,right: 0.30284409180634897d,bottom: 0.08138154212624626d,left: 0.23640711715855445d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44906107737330214d,right: 0.9848357883461492d,bottom: 0.011664430283356397d,left: 0.9286346946027287d),
new NpgsqlTypes.NpgsqlBox(top: 0.3882476302506056d,right: 0.39716509143277623d,bottom: 0.07850323799342607d,left: 0.2580692179754096d),
new NpgsqlTypes.NpgsqlBox(top: 0.14060447440593393d,right: 0.49560448796625534d,bottom: 0.01791423780597423d,left: 0.2765296227262586d),
new NpgsqlTypes.NpgsqlBox(top: 0.5296362567811376d,right: 0.9452523927628196d,bottom: 0.3923432222729034d,left: 0.32199917976850134d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2716221659185921d,right: 0.8336977872458831d,bottom: 0.24632476311255147d,left: 0.8084659210801713d),
new NpgsqlTypes.NpgsqlBox(top: 0.3419205249087055d,right: 0.8424599359354891d,bottom: 0.3083289353726807d,left: 0.6257369272751625d),
new NpgsqlTypes.NpgsqlBox(top: 0.7225170817303088d,right: 0.3483882488057515d,bottom: 0.0337602863946449d,left: 0.33320701427163457d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6919232950668822d,right: 0.6657847245808454d,bottom: 0.45027711081145705d,left: 0.21183429066537018d),
new NpgsqlTypes.NpgsqlBox(top: 0.3022815015303615d,right: 0.9937746262440432d,bottom: 0.18387621030420442d,left: 0.7256409852706063d),
new NpgsqlTypes.NpgsqlBox(top: 0.9245264835017726d,right: 0.6967640058588491d,bottom: 0.2852810647645909d,left: 0.48832538006993287d),
new NpgsqlTypes.NpgsqlBox(top: 0.8416472917955623d,right: 0.6936560651722875d,bottom: 0.7336811282617431d,left: 0.22898147969835148d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8794875469826205d,right: 0.7193256284882159d,bottom: 0.6824839161125134d,left: 0.6202609048567368d),
new NpgsqlTypes.NpgsqlBox(top: 0.8489232483414179d,right: 0.24033302638886367d,bottom: 0.26252752748507635d,left: 0.10093051751206805d),
new NpgsqlTypes.NpgsqlBox(top: 0.8751545265197933d,right: 0.3067572194675453d,bottom: 0.7414199199342059d,left: 0.0654115269208696d),
new NpgsqlTypes.NpgsqlBox(top: 0.2034841538158203d,right: 0.5093439676702649d,bottom: 0.028842588637074673d,left: 0.3152746715280267d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7791419201941199d,right: 0.6561558299036181d,bottom: 0.3945696349941794d,left: 0.1847678709470557d),
new NpgsqlTypes.NpgsqlBox(top: 0.6702466932737486d,right: 0.3219250324444535d,bottom: 0.5455016740330211d,left: 0.04257665171886926d),
new NpgsqlTypes.NpgsqlBox(top: 0.9188896321615764d,right: 0.8157362997745176d,bottom: 0.43997229066252364d,left: 0.21928464524603475d),
new NpgsqlTypes.NpgsqlBox(top: 0.9616824215174156d,right: 0.7221843164827308d,bottom: 0.6510540723922719d,left: 0.5122965976493742d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8463751607457196d,right: 0.38605571751868695d,bottom: 0.5974467603962984d,left: 0.08490190217527227d),
new NpgsqlTypes.NpgsqlBox(top: 0.5993848453823226d,right: 0.26052828005399276d,bottom: 0.48891282603577546d,left: 0.03119479507745271d),
new NpgsqlTypes.NpgsqlBox(top: 0.15319926752558288d,right: 0.8731411863744846d,bottom: 0.1027148528247136d,left: 0.855844335417836d),
new NpgsqlTypes.NpgsqlBox(top: 0.8485420083023967d,right: 0.47392226428214235d,bottom: 0.7682446450265759d,left: 0.3620129515431134d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9689035769357209d,right: 0.41725967735440306d,bottom: 0.736367192731382d,left: 0.16515494915601925d),
new NpgsqlTypes.NpgsqlBox(top: 0.7307214476671072d,right: 0.8073313204562841d,bottom: 0.4780681926466728d,left: 0.4181137343091803d),
new NpgsqlTypes.NpgsqlBox(top: 0.6275430982881429d,right: 0.23352978506227606d,bottom: 0.5505937087673844d,left: 0.17530543343446514d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2301482482081315d,right: 0.9856010356821117d,bottom: 0.2066797803351892d,left: 0.8035309055280505d),
new NpgsqlTypes.NpgsqlBox(top: 0.7445863403677045d,right: 0.952291661099985d,bottom: 0.039805270749268096d,left: 0.349995420763623d),
new NpgsqlTypes.NpgsqlBox(top: 0.41564174885451044d,right: 0.3145020810678396d,bottom: 0.3630397905488486d,left: 0.18369914903036322d),
new NpgsqlTypes.NpgsqlBox(top: 0.8409366441065361d,right: 0.46361445453224437d,bottom: 0.5783178806431041d,left: 0.38164764401610274d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7987351603754963d,right: 0.3998745657948153d,bottom: 0.6399122068243108d,left: 0.002801208371813635d),
new NpgsqlTypes.NpgsqlBox(top: 0.45643244967590424d,right: 0.965481382642618d,bottom: 0.11885301631780099d,left: 0.43463591862663253d),
new NpgsqlTypes.NpgsqlBox(top: 0.8719755005061053d,right: 0.459616657909523d,bottom: 0.1486696532926668d,left: 0.18090530604422927d),
new NpgsqlTypes.NpgsqlBox(top: 0.5243373518387748d,right: 0.6240039212896005d,bottom: 0.387158275047802d,left: 0.12883905656836359d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6272249389896476d,right: 0.7390091691332371d,bottom: 0.20504759121015936d,left: 0.4058615623978008d),
new NpgsqlTypes.NpgsqlBox(top: 0.7886785363539548d,right: 0.8143073242273439d,bottom: 0.5068046000681936d,left: 0.3878065248827366d),
new NpgsqlTypes.NpgsqlBox(top: 0.5555331913468673d,right: 0.7050552258021672d,bottom: 0.35794879025694415d,left: 0.44945088769609787d),
new NpgsqlTypes.NpgsqlBox(top: 0.9895122977805586d,right: 0.3484104281666387d,bottom: 0.638257116112957d,left: 0.1963797964675208d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6277757124385139d,right: 0.5721388581935396d,bottom: 0.2548070110329249d,left: 0.535267951398751d),
new NpgsqlTypes.NpgsqlBox(top: 0.4543370692386993d,right: 0.6155413403046845d,bottom: 0.27947915979130944d,left: 0.25614404742390573d),
new NpgsqlTypes.NpgsqlBox(top: 0.8742717778067479d,right: 0.6825572397070852d,bottom: 0.5711709238811684d,left: 0.5726422524206585d),
new NpgsqlTypes.NpgsqlBox(top: 0.33518351073979546d,right: 0.7689738831478818d,bottom: 0.14550103182156393d,left: 0.49941465646562266d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6570099451782454d,right: 0.5616499056524815d,bottom: 0.509602219800933d,left: 0.3231922684644102d),
new NpgsqlTypes.NpgsqlBox(top: 0.6996325103041082d,right: 0.7825621026009383d,bottom: 0.26350571217308905d,left: 0.28854210005418146d),
new NpgsqlTypes.NpgsqlBox(top: 0.14299840693657428d,right: 0.18730143027067503d,bottom: 0.044226780334634674d,left: 0.18707386331899345d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2601375269311117d,right: 0.999913947609385d,bottom: 0.06604505447013942d,left: 0.4745260085153238d),
new NpgsqlTypes.NpgsqlBox(top: 0.8975033080137059d,right: 0.935254712777639d,bottom: 0.49317463000157336d,left: 0.25628082002222674d),
new NpgsqlTypes.NpgsqlBox(top: 0.17476949111058038d,right: 0.3972332387113705d,bottom: 0.12519101434150304d,left: 0.05658876789479539d),
new NpgsqlTypes.NpgsqlBox(top: 0.22224085589358566d,right: 0.7191835832837877d,bottom: 0.03572615153079772d,left: 0.7162290823356684d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9210699017207594d,right: 0.9823434364220742d,bottom: 0.9034956863790846d,left: 0.6941887955084927d),
new NpgsqlTypes.NpgsqlBox(top: 0.9446334028719656d,right: 0.41470571504392817d,bottom: 0.25435134013267047d,left: 0.25341836238789184d),
new NpgsqlTypes.NpgsqlBox(top: 0.767872018468199d,right: 0.9166746896362993d,bottom: 0.28464568094468856d,left: 0.6257050188549756d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9694158083155857d,right: 0.42155425606754404d,bottom: 0.01247529990940921d,left: 0.15471463753643933d),
new NpgsqlTypes.NpgsqlBox(top: 0.9425237339349425d,right: 0.9504434428819561d,bottom: 0.5399578655718216d,left: 0.8359288104672747d),
new NpgsqlTypes.NpgsqlBox(top: 0.2532529070652225d,right: 0.9723413856341748d,bottom: 0.1271397523877721d,left: 0.4325028017091328d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.999526432510562d,right: 0.758624991100758d,bottom: 0.13601606547233747d,left: 0.4556215127103326d),
new NpgsqlTypes.NpgsqlBox(top: 0.9917515227449011d,right: 0.8770868902380768d,bottom: 0.07072852425830245d,left: 0.05616911849985062d),
new NpgsqlTypes.NpgsqlBox(top: 0.44091030485778027d,right: 0.8299774633543813d,bottom: 0.21859306187958794d,left: 0.25641730887841985d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6333052300278679d,right: 0.7944127183502682d,bottom: 0.11760103541527933d,left: 0.7592319919257369d),
new NpgsqlTypes.NpgsqlBox(top: 0.4192248297801243d,right: 0.5617463915608507d,bottom: 0.38389575069128445d,left: 0.0767007302262609d),
new NpgsqlTypes.NpgsqlBox(top: 0.5175049096145221d,right: 0.26789510311885767d,bottom: 0.1948497583553257d,left: 0.1621489971953337d),
new NpgsqlTypes.NpgsqlBox(top: 0.8758234989908092d,right: 0.43981784963105763d,bottom: 0.7394322073941916d,left: 0.3928310470717067d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7136924386209612d,right: 0.6258109522579449d,bottom: 0.3106567273617916d,left: 0.3614312513285268d),
new NpgsqlTypes.NpgsqlBox(top: 0.9752702121267998d,right: 0.11518046039735563d,bottom: 0.3487178327009989d,left: 0.08795008625411316d),
new NpgsqlTypes.NpgsqlBox(top: 0.6673689673362897d,right: 0.9859117019549738d,bottom: 0.41765432467766006d,left: 0.5836168474483576d),
new NpgsqlTypes.NpgsqlBox(top: 0.4957093957373142d,right: 0.36655535906287007d,bottom: 0.38010647419496324d,left: 0.35001164829580944d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8500041949605871d,right: 0.8354539214710625d,bottom: 0.8118018532609469d,left: 0.17814385014731726d),
new NpgsqlTypes.NpgsqlBox(top: 0.759594152459839d,right: 0.16516313389676163d,bottom: 0.23439205366858562d,left: 0.06533794205855437d),
new NpgsqlTypes.NpgsqlBox(top: 0.4984087534377696d,right: 0.406766669391162d,bottom: 0.056997998120097315d,left: 0.3073758180455638d),
new NpgsqlTypes.NpgsqlBox(top: 0.5584265072643553d,right: 0.5846152896479445d,bottom: 0.010983377162720243d,left: 0.3647950834937651d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9928550076335472d,right: 0.9952543209866472d,bottom: 0.10969731428718932d,left: 0.6236548925044418d),
new NpgsqlTypes.NpgsqlBox(top: 0.8810195805434855d,right: 0.705707402937513d,bottom: 0.6037638559985261d,left: 0.6089939170862737d),
new NpgsqlTypes.NpgsqlBox(top: 0.7423560996695683d,right: 0.6215787281885237d,bottom: 0.4948491382135197d,left: 0.10727795619808334d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7860953648040796d,right: 0.5762220015213141d,bottom: 0.1562019162674133d,left: 0.30742494473704507d),
new NpgsqlTypes.NpgsqlBox(top: 0.5635110406968321d,right: 0.9511754272102635d,bottom: 0.5010544330773972d,left: 0.6056233203150847d),
new NpgsqlTypes.NpgsqlBox(top: 0.5648420419449385d,right: 0.8290859405971447d,bottom: 0.09317782801651053d,left: 0.49054269597934885d),
new NpgsqlTypes.NpgsqlBox(top: 0.7682737293169857d,right: 0.4828257043593831d,bottom: 0.5994554748964335d,left: 0.44683571668244493d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5341443839510829d,right: 0.6648164846946019d,bottom: 0.06790945380989766d,left: 0.21220444807552374d),
new NpgsqlTypes.NpgsqlBox(top: 0.7175114064666606d,right: 0.6606921667456348d,bottom: 0.079126365359383d,left: 0.6124083357506221d),
new NpgsqlTypes.NpgsqlBox(top: 0.7328079512975773d,right: 0.5234826044385551d,bottom: 0.5619410913354017d,left: 0.13432153593417773d),
new NpgsqlTypes.NpgsqlBox(top: 0.9198261187613886d,right: 0.8356716958657546d,bottom: 0.09729007947987633d,left: 0.32746815511850846d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6578302605228765d,right: 0.6482540537444262d,bottom: 0.20779855823427462d,left: 0.5635505429281499d),
new NpgsqlTypes.NpgsqlBox(top: 0.763227142896461d,right: 0.29862707647560094d,bottom: 0.10180476118944848d,left: 0.13668483901849615d),
new NpgsqlTypes.NpgsqlBox(top: 0.8054364255240049d,right: 0.8251592018415148d,bottom: 0.40995602242928164d,left: 0.014832128375024234d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7737623335950667d,right: 0.6058293831770105d,bottom: 0.5858133458647412d,left: 0.5643591855662592d),
new NpgsqlTypes.NpgsqlBox(top: 0.4851498052266564d,right: 0.8767690320969765d,bottom: 0.3564203698896683d,left: 0.19340512434081703d),
new NpgsqlTypes.NpgsqlBox(top: 0.451871513057162d,right: 0.5484263328510773d,bottom: 0.31174970042976624d,left: 0.4733624373915587d),
new NpgsqlTypes.NpgsqlBox(top: 0.8238234112519568d,right: 0.77978381362492d,bottom: 0.36483912829876897d,left: 0.5177736870495263d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8881269446229533d,right: 0.8927648131810295d,bottom: 0.2781733449159164d,left: 0.1445676381541141d),
new NpgsqlTypes.NpgsqlBox(top: 0.7857456899128836d,right: 0.5235855868079753d,bottom: 0.7029169559438673d,left: 0.29482718048624146d),
new NpgsqlTypes.NpgsqlBox(top: 0.7305092622395241d,right: 0.8620724845879866d,bottom: 0.5220191928584151d,left: 0.00779744963397111d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5552068352824141d,right: 0.7457864407485706d,bottom: 0.405651999245096d,left: 0.12905136297963304d),
new NpgsqlTypes.NpgsqlBox(top: 0.2603451157742951d,right: 0.9399462490592786d,bottom: 0.12433686466585747d,left: 0.6349605657453691d),
new NpgsqlTypes.NpgsqlBox(top: 0.9951970404590532d,right: 0.44365763945440684d,bottom: 0.14369040747952033d,left: 0.27449365980361684d),
new NpgsqlTypes.NpgsqlBox(top: 0.7537443005171321d,right: 0.36703604487052766d,bottom: 0.6383195221371053d,left: 0.22087734966791983d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9763054722689088d,right: 0.857251265282388d,bottom: 0.1596048645885394d,left: 0.4675083342069688d),
new NpgsqlTypes.NpgsqlBox(top: 0.6523903297358188d,right: 0.8047411507791516d,bottom: 0.1413935789654075d,left: 0.06693471323364875d),
new NpgsqlTypes.NpgsqlBox(top: 0.43393129141807973d,right: 0.4197980480267324d,bottom: 0.1303066523306604d,left: 0.3437828345241416d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6516889776425645d,right: 0.8602899507870754d,bottom: 0.5281749934283744d,left: 0.5245923142259423d),
new NpgsqlTypes.NpgsqlBox(top: 0.9636512857387168d,right: 0.6932997309202084d,bottom: 0.36708087975557735d,left: 0.6818485943104303d),
new NpgsqlTypes.NpgsqlBox(top: 0.8053025912683254d,right: 0.6401520161543744d,bottom: 0.4877195226427816d,left: 0.0935601939571713d),
new NpgsqlTypes.NpgsqlBox(top: 0.9202750301806337d,right: 0.8545338490143687d,bottom: 0.6988977440774491d,left: 0.020644361756435914d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9910191157296554d,right: 0.6399385033600317d,bottom: 0.615067900521522d,left: 0.27372781116458134d),
new NpgsqlTypes.NpgsqlBox(top: 0.4555311320624722d,right: 0.08003153567399635d,bottom: 0.2901299693426497d,left: 0.06961836083599326d),
new NpgsqlTypes.NpgsqlBox(top: 0.7290946276109954d,right: 0.8670950862458466d,bottom: 0.7174573567265681d,left: 0.3179789869084022d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6335531477455418d,right: 0.4922321666527074d,bottom: 0.05272851952860946d,left: 0.0537776367847983d),
new NpgsqlTypes.NpgsqlBox(top: 0.46132479012348215d,right: 0.6735233177062352d,bottom: 0.13477717127336275d,left: 0.6327671327524436d),
new NpgsqlTypes.NpgsqlBox(top: 0.4464162511805946d,right: 0.21230497308142526d,bottom: 0.0974346540722335d,left: 0.03086017362616833d),
new NpgsqlTypes.NpgsqlBox(top: 0.8469923729572048d,right: 0.9494326370629573d,bottom: 0.44256236724600306d,left: 0.4668367338324124d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41714408784231327d,right: 0.8252363957341802d,bottom: 0.3869739958396279d,left: 0.016815763910876247d),
new NpgsqlTypes.NpgsqlBox(top: 0.7814447456443782d,right: 0.7315223520737927d,bottom: 0.3762279781830796d,left: 0.15473911757365022d),
new NpgsqlTypes.NpgsqlBox(top: 0.436473934542962d,right: 0.7711309723276498d,bottom: 0.41196987897518245d,left: 0.36554145372121116d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45328114304736833d,right: 0.801467329086742d,bottom: 0.26000144682956683d,left: 0.276861538773271d),
new NpgsqlTypes.NpgsqlBox(top: 0.8548640718406303d,right: 0.2611141369910325d,bottom: 0.7942190541683186d,left: 0.0056755744834732225d),
new NpgsqlTypes.NpgsqlBox(top: 0.749347351976925d,right: 0.5292564693083093d,bottom: 0.09108208242274551d,left: 0.3552069095659439d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.753484866605833d,right: 0.6277297667577255d,bottom: 0.6318047991236208d,left: 0.06196492037376233d),
new NpgsqlTypes.NpgsqlBox(top: 0.5821550109348863d,right: 0.9615140136497354d,bottom: 0.02860389347814818d,left: 0.3702980916023799d),
new NpgsqlTypes.NpgsqlBox(top: 0.8228766615712357d,right: 0.6463606932393041d,bottom: 0.3287806035226898d,left: 0.41838679227430386d),
new NpgsqlTypes.NpgsqlBox(top: 0.9271885576800105d,right: 0.9373000822063633d,bottom: 0.4128968660897582d,left: 0.6221281279805774d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8646811643636463d,right: 0.9329299765385884d,bottom: 0.4623974973173587d,left: 0.5241990134368283d),
new NpgsqlTypes.NpgsqlBox(top: 0.2305522104312293d,right: 0.536717013436863d,bottom: 0.21440859387135314d,left: 0.5124986491464889d),
new NpgsqlTypes.NpgsqlBox(top: 0.5616730581823582d,right: 0.7430969000825675d,bottom: 0.013059063160131501d,left: 0.41913951363666324d),
new NpgsqlTypes.NpgsqlBox(top: 0.42757421783279326d,right: 0.8248555729409882d,bottom: 0.33017282143309834d,left: 0.7538741366190775d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2424178803969348d,right: 0.8963422012051468d,bottom: 0.05258272312945189d,left: 0.15159003793909176d),
new NpgsqlTypes.NpgsqlBox(top: 0.7824690322079021d,right: 0.7205075367580253d,bottom: 0.586818915719062d,left: 0.11421497189954577d),
new NpgsqlTypes.NpgsqlBox(top: 0.9498483621810188d,right: 0.9525694072193881d,bottom: 0.5197541290954051d,left: 0.24116894105240427d),
new NpgsqlTypes.NpgsqlBox(top: 0.7714451920623386d,right: 0.6361840420956565d,bottom: 0.23212703503370846d,left: 0.6340681691708169d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8449550680100953d,right: 0.9022794206077952d,bottom: 0.12258256574325621d,left: 0.5960704598090553d),
new NpgsqlTypes.NpgsqlBox(top: 0.9314303501790694d,right: 0.8862175540205534d,bottom: 0.23049793572648136d,left: 0.6485274401923377d),
new NpgsqlTypes.NpgsqlBox(top: 0.29693989134285936d,right: 0.9434440241093748d,bottom: 0.28925357488447645d,left: 0.13601281520469177d),
new NpgsqlTypes.NpgsqlBox(top: 0.40683745064001353d,right: 0.3217727422620824d,bottom: 0.22858494190593237d,left: 0.0730343685939282d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9966960782474709d,right: 0.1490627010926553d,bottom: 0.9464423271383546d,left: 0.09797850159728771d),
new NpgsqlTypes.NpgsqlBox(top: 0.9745409862539901d,right: 0.9907998325763473d,bottom: 0.9371843259956274d,left: 0.8842254424641377d),
new NpgsqlTypes.NpgsqlBox(top: 0.7577429352146889d,right: 0.7354099375275441d,bottom: 0.45196300803015566d,left: 0.42936817695800045d),
new NpgsqlTypes.NpgsqlBox(top: 0.3003062055174922d,right: 0.8422727970855685d,bottom: 0.17846202633383124d,left: 0.21934201502146278d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5963238526013085d,right: 0.09258958798166983d,bottom: 0.011665131192743483d,left: 0.031503915644137015d),
new NpgsqlTypes.NpgsqlBox(top: 0.9712683392867308d,right: 0.9184376738973649d,bottom: 0.861955092766608d,left: 0.621658813357157d),
new NpgsqlTypes.NpgsqlBox(top: 0.7644974960176567d,right: 0.89115015902461d,bottom: 0.6750002978822809d,left: 0.04268200731537486d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7646227993922502d,right: 0.8728253148115245d,bottom: 0.41022622596406977d,left: 0.21033415289341473d),
new NpgsqlTypes.NpgsqlBox(top: 0.715038666431222d,right: 0.7425347869069019d,bottom: 0.4853442592322289d,left: 0.7423729114865035d),
new NpgsqlTypes.NpgsqlBox(top: 0.8800208269535877d,right: 0.48537431675569587d,bottom: 0.39179117445258616d,left: 0.3750841085384504d),
new NpgsqlTypes.NpgsqlBox(top: 0.6834429620741307d,right: 0.8756925954883554d,bottom: 0.6154533528652762d,left: 0.8537358699644112d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6058632228612346d,right: 0.18482869996528695d,bottom: 0.4778814655687196d,left: 0.041706508754409066d),
new NpgsqlTypes.NpgsqlBox(top: 0.8615667355282082d,right: 0.5882269709920331d,bottom: 0.7679185826027991d,left: 0.09599299969006858d),
new NpgsqlTypes.NpgsqlBox(top: 0.1298562535762695d,right: 0.2543764190955645d,bottom: 0.03183374264001293d,left: 0.18415111517646765d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464785882829098d,right: 0.8755628136192373d,bottom: 0.6736598036771899d,left: 0.3179775728859944d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7251476643973146d,right: 0.7882450662179494d,bottom: 0.2615816136265865d,left: 0.12367179374847104d),
new NpgsqlTypes.NpgsqlBox(top: 0.2773864115588307d,right: 0.7047197771482363d,bottom: 0.18931112465936395d,left: 0.6291982669106941d),
new NpgsqlTypes.NpgsqlBox(top: 0.9720584964951244d,right: 0.7115566491949091d,bottom: 0.6978730887762093d,left: 0.6110019971346369d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8369839811007218d,right: 0.9343473891157066d,bottom: 0.18233404112415508d,left: 0.8623744277070167d),
new NpgsqlTypes.NpgsqlBox(top: 0.7233170846382874d,right: 0.7279312515888146d,bottom: 0.13794870416629557d,left: 0.4787264719457889d),
new NpgsqlTypes.NpgsqlBox(top: 0.5124927254882689d,right: 0.49419108677887147d,bottom: 0.047827484424341926d,left: 0.3669830337206961d),
new NpgsqlTypes.NpgsqlBox(top: 0.8663414204548894d,right: 0.6877893523713272d,bottom: 0.11864892534915583d,left: 0.5093367963741509d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35076427697793655d,right: 0.859879036305827d,bottom: 0.2547800723997664d,left: 0.649199704088558d),
new NpgsqlTypes.NpgsqlBox(top: 0.7602183422348067d,right: 0.6477846513147908d,bottom: 0.004388540100814242d,left: 0.020148022591511938d),
new NpgsqlTypes.NpgsqlBox(top: 0.1315465608855899d,right: 0.8465793184579649d,bottom: 0.06980040112615038d,left: 0.8178774320209006d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5230200517310479d,right: 0.43473910015539385d,bottom: 0.36901633702462433d,left: 0.0755895318133889d),
new NpgsqlTypes.NpgsqlBox(top: 0.5022254904256396d,right: 0.8866593417085099d,bottom: 0.04002364898421629d,left: 0.8112047611175643d),
new NpgsqlTypes.NpgsqlBox(top: 0.5057330514300562d,right: 0.6822715361381957d,bottom: 0.3099807060708025d,left: 0.2624686846897698d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.66732829368955d,right: 0.6421609850105345d,bottom: 0.053374778116304866d,left: 0.02838729398485218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7548342892456505d,right: 0.5033196351148731d,bottom: 0.3101789335586079d,left: 0.2105406454336658d),
new NpgsqlTypes.NpgsqlBox(top: 0.6830672545289023d,right: 0.6141699182270499d,bottom: 0.5019184839264024d,left: 0.43679406417765376d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6286343660425739d,right: 0.80399213887159d,bottom: 0.6214004299235408d,left: 0.510586280142369d),
new NpgsqlTypes.NpgsqlBox(top: 0.7591597703489821d,right: 0.5245469516815752d,bottom: 0.5959918480809765d,left: 0.4312094650663352d),
new NpgsqlTypes.NpgsqlBox(top: 0.4914472863344683d,right: 0.8180475787097289d,bottom: 0.12456637167489515d,left: 0.08867468264828504d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7537208880681756d,right: 0.9993704576667444d,bottom: 0.27911335749263755d,left: 0.08372162736756861d),
new NpgsqlTypes.NpgsqlBox(top: 0.6275239952919476d,right: 0.29633403501994915d,bottom: 0.27838170500883697d,left: 0.11746565956763932d),
new NpgsqlTypes.NpgsqlBox(top: 0.37999168011914397d,right: 0.23351010264601058d,bottom: 0.194979278520924d,left: 0.028353742319188413d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.37985751326765727d,right: 0.4292368655914013d,bottom: 0.37448823223609096d,left: 0.24872249499593713d),
new NpgsqlTypes.NpgsqlBox(top: 0.5956157434782364d,right: 0.20692912514414863d,bottom: 0.2755442893654533d,left: 0.09049481029403672d),
new NpgsqlTypes.NpgsqlBox(top: 0.35564694461534707d,right: 0.44212131496025275d,bottom: 0.311179680689159d,left: 0.4363594935554018d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9206217489727678d,right: 0.43052368280193176d,bottom: 0.6476862486657239d,left: 0.21425522409248632d),
new NpgsqlTypes.NpgsqlBox(top: 0.5702607947213986d,right: 0.5537154163129188d,bottom: 0.03375858731977732d,left: 0.3120124676635705d),
new NpgsqlTypes.NpgsqlBox(top: 0.727562558376776d,right: 0.6656239724134838d,bottom: 0.1611493551836639d,left: 0.5411563079290795d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.809610716813206d,right: 0.8696485875951852d,bottom: 0.34266806176083264d,left: 0.6290430234935621d),
new NpgsqlTypes.NpgsqlBox(top: 0.8794895167189001d,right: 0.38558833622407107d,bottom: 0.44655227085624283d,left: 0.17882949156720074d),
new NpgsqlTypes.NpgsqlBox(top: 0.5734889893054441d,right: 0.6076244632070904d,bottom: 0.3893820468127439d,left: 0.08944454719328587d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7858367168798434d,right: 0.7735125509326738d,bottom: 0.34177136074743575d,left: 0.5705409682527799d),
new NpgsqlTypes.NpgsqlBox(top: 0.35635697671769473d,right: 0.8184645584791999d,bottom: 0.31229169158365777d,left: 0.06688491263216378d),
new NpgsqlTypes.NpgsqlBox(top: 0.9890931475073387d,right: 0.8127742115526209d,bottom: 0.691292451599883d,left: 0.7037824328037359d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6903210978197508d,right: 0.13241001182690293d,bottom: 0.3877272987506446d,left: 0.10908549787384025d),
new NpgsqlTypes.NpgsqlBox(top: 0.3473998546516598d,right: 0.8534807286209566d,bottom: 0.1797482334434336d,left: 0.6913405119278956d),
new NpgsqlTypes.NpgsqlBox(top: 0.6953366807943466d,right: 0.5991401928237956d,bottom: 0.15268075503004552d,left: 0.20084394342015466d),
new NpgsqlTypes.NpgsqlBox(top: 0.7824851809778333d,right: 0.4347693185716419d,bottom: 0.35340908344847755d,left: 0.11599195186311573d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7455635523203284d,right: 0.7589985712474859d,bottom: 0.5003718935823133d,left: 0.22279466009346738d),
new NpgsqlTypes.NpgsqlBox(top: 0.6264738428928722d,right: 0.9746221201867789d,bottom: 0.005494243219222206d,left: 0.5352188007604194d),
new NpgsqlTypes.NpgsqlBox(top: 0.4382932454307593d,right: 0.8123400061514396d,bottom: 0.29883117021875516d,left: 0.7002338031836666d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9505797843636505d,right: 0.6425955393812319d,bottom: 0.6591582024397529d,left: 0.47861183086678294d),
new NpgsqlTypes.NpgsqlBox(top: 0.768861516148658d,right: 0.563544290828506d,bottom: 0.2523535919137352d,left: 0.09608440496998105d),
new NpgsqlTypes.NpgsqlBox(top: 0.3576405178868072d,right: 0.8990010687081323d,bottom: 0.1660140363726298d,left: 0.8648762142582541d),
new NpgsqlTypes.NpgsqlBox(top: 0.9200790434020993d,right: 0.5184645319205695d,bottom: 0.22305869763287478d,left: 0.23967550764551515d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42313457489759243d,right: 0.3996496948328574d,bottom: 0.3797446156232538d,left: 0.02864131461166952d),
new NpgsqlTypes.NpgsqlBox(top: 0.5581938041193643d,right: 0.5222805176459508d,bottom: 0.5280506151524125d,left: 0.10248406450510517d),
new NpgsqlTypes.NpgsqlBox(top: 0.5450696175065554d,right: 0.5975696301160792d,bottom: 0.17200864951869876d,left: 0.010110019107731572d),
new NpgsqlTypes.NpgsqlBox(top: 0.8389428776533637d,right: 0.8531087055235449d,bottom: 0.2917957399382344d,left: 0.35725205288168205d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3043545451378755d,right: 0.7403081045751927d,bottom: 0.15423076231601962d,left: 0.10916942799633322d),
new NpgsqlTypes.NpgsqlBox(top: 0.5879898300961163d,right: 0.6018795904984092d,bottom: 0.19892282907012893d,left: 0.09888024283920971d),
new NpgsqlTypes.NpgsqlBox(top: 0.45736754538446756d,right: 0.5614545460825617d,bottom: 0.08518709062042917d,left: 0.005578479548422166d),
new NpgsqlTypes.NpgsqlBox(top: 0.995843523746064d,right: 0.8844177215551002d,bottom: 0.20643561793668397d,left: 0.20713823651305918d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38531860827028264d,right: 0.4690803636530615d,bottom: 0.10140042085758338d,left: 0.16124334040618704d),
new NpgsqlTypes.NpgsqlBox(top: 0.6456570518827907d,right: 0.4176478462357778d,bottom: 0.6428489330935789d,left: 0.3566358910536197d),
new NpgsqlTypes.NpgsqlBox(top: 0.8694262581836647d,right: 0.7371546764229867d,bottom: 0.25453689711104943d,left: 0.1073105855029769d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17497506609997082d,right: 0.7084990305049494d,bottom: 0.08260226510374258d,left: 0.329191981604272d),
new NpgsqlTypes.NpgsqlBox(top: 0.9679864599105112d,right: 0.453555755717326d,bottom: 0.07931224199135845d,left: 0.32239556122727964d),
new NpgsqlTypes.NpgsqlBox(top: 0.6792101446136426d,right: 0.8963655157701931d,bottom: 0.6019694000342178d,left: 0.4674253978538575d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34625445400164445d,right: 0.931922934165251d,bottom: 0.06101355513646889d,left: 0.8151072304150546d),
new NpgsqlTypes.NpgsqlBox(top: 0.3243720828902107d,right: 0.5724331395717707d,bottom: 0.1764592714308495d,left: 0.4288202094985788d),
new NpgsqlTypes.NpgsqlBox(top: 0.46893350108509013d,right: 0.3788176926371566d,bottom: 0.24827479804060548d,left: 0.21567720152559788d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7121781686912116d,right: 0.5534611997192509d,bottom: 0.42844549352898975d,left: 0.4997492029683941d),
new NpgsqlTypes.NpgsqlBox(top: 0.9726159778598313d,right: 0.49220168671195985d,bottom: 0.46870228992863605d,left: 0.36216854934489007d),
new NpgsqlTypes.NpgsqlBox(top: 0.6998869303122564d,right: 0.4717520593703707d,bottom: 0.3252545914897481d,left: 0.15505679513647863d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5029413702035215d,right: 0.9091558919167894d,bottom: 0.0158849056273479d,left: 0.654429290783028d),
new NpgsqlTypes.NpgsqlBox(top: 0.8733983020715892d,right: 0.4970345577515888d,bottom: 0.07369243011657323d,left: 0.33938148178405714d),
new NpgsqlTypes.NpgsqlBox(top: 0.8980791246174222d,right: 0.9425353057602625d,bottom: 0.35463967621263803d,left: 0.8013769635993255d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9970833221478684d,right: 0.8345428082208111d,bottom: 0.6564353873047937d,left: 0.5898167266034845d),
new NpgsqlTypes.NpgsqlBox(top: 0.261507789979608d,right: 0.8993656080108664d,bottom: 0.2364743105575844d,left: 0.6617456256341413d),
new NpgsqlTypes.NpgsqlBox(top: 0.93595773007861d,right: 0.7347731676644593d,bottom: 0.64271957535521d,left: 0.3092897097683185d),
new NpgsqlTypes.NpgsqlBox(top: 0.2895595727646181d,right: 0.8847157097308629d,bottom: 0.09844858460072015d,left: 0.5152873496020622d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16025782661526533d,right: 0.9844488132023553d,bottom: 0.09031856140734762d,left: 0.9121976892763978d),
new NpgsqlTypes.NpgsqlBox(top: 0.8834605078055227d,right: 0.7328886394162871d,bottom: 0.44921854982400433d,left: 0.07609113295048386d),
new NpgsqlTypes.NpgsqlBox(top: 0.6219381434229332d,right: 0.9572166153556649d,bottom: 0.08491040436309694d,left: 0.4883321714254897d),
new NpgsqlTypes.NpgsqlBox(top: 0.8111217576861488d,right: 0.6862737508625972d,bottom: 0.22541874928240258d,left: 0.49138868501747557d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6747995910398364d,right: 0.4447371052259582d,bottom: 0.027990440592745802d,left: 0.32603825608456094d),
new NpgsqlTypes.NpgsqlBox(top: 0.5915185263440522d,right: 0.17914504731663328d,bottom: 0.20986251759882713d,left: 0.013553221043882457d),
new NpgsqlTypes.NpgsqlBox(top: 0.4343799959329129d,right: 0.3649042988578485d,bottom: 0.3045508275425922d,left: 0.18371101058967698d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2126880631253637d,right: 0.8532238682315367d,bottom: 0.08883414278223556d,left: 0.27595558824246247d),
new NpgsqlTypes.NpgsqlBox(top: 0.5651329843774817d,right: 0.9060247968003076d,bottom: 0.5542879399804308d,left: 0.07996658915703592d),
new NpgsqlTypes.NpgsqlBox(top: 0.8025290767978566d,right: 0.8543845796033225d,bottom: 0.1449536236339093d,left: 0.8353812667398776d),
new NpgsqlTypes.NpgsqlBox(top: 0.7169667575596149d,right: 0.833723394520448d,bottom: 0.20404356762119713d,left: 0.6065189788488604d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5764134047935681d,right: 0.9218075816021788d,bottom: 0.07180584469813511d,left: 0.8801275995933373d),
new NpgsqlTypes.NpgsqlBox(top: 0.5455799558044417d,right: 0.8576578155561148d,bottom: 0.03705391205653652d,left: 0.7367311052864705d),
new NpgsqlTypes.NpgsqlBox(top: 0.9758469462993692d,right: 0.8475509849345834d,bottom: 0.30521219116793774d,left: 0.14372956013493665d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6165528383617507d,right: 0.6379007239185208d,bottom: 0.5699185223470076d,left: 0.18625701053054955d),
new NpgsqlTypes.NpgsqlBox(top: 0.2347172326379745d,right: 0.5642316918156723d,bottom: 0.19117117809376483d,left: 0.5494853125287161d),
new NpgsqlTypes.NpgsqlBox(top: 0.8558814540796684d,right: 0.7968860377388731d,bottom: 0.6754416852071423d,left: 0.09767193432283894d),
new NpgsqlTypes.NpgsqlBox(top: 0.7500041109610593d,right: 0.07333633239919002d,bottom: 0.29420398160418815d,left: 0.006043656455879676d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9067730187905848d,right: 0.766990849885562d,bottom: 0.26649494281029606d,left: 0.21836862616325792d),
new NpgsqlTypes.NpgsqlBox(top: 0.6201299342913706d,right: 0.5605226447978529d,bottom: 0.4371519772460404d,left: 0.5291924351146735d),
new NpgsqlTypes.NpgsqlBox(top: 0.39450388163099814d,right: 0.390862396155474d,bottom: 0.22065433707273474d,left: 0.13656211889333247d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8164818861242299d,right: 0.1104679507958044d,bottom: 0.4842980600028346d,left: 0.09536159114598919d),
new NpgsqlTypes.NpgsqlBox(top: 0.30458773601763156d,right: 0.9521720705611693d,bottom: 0.013115685257107712d,left: 0.32309396143058555d),
new NpgsqlTypes.NpgsqlBox(top: 0.9941023694834326d,right: 0.9872350414019264d,bottom: 0.5948926959670578d,left: 0.008306366378030505d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8463751607457196d,right: 0.38605571751868695d,bottom: 0.5974467603962984d,left: 0.08490190217527227d),
new NpgsqlTypes.NpgsqlBox(top: 0.5993848453823226d,right: 0.26052828005399276d,bottom: 0.48891282603577546d,left: 0.03119479507745271d),
new NpgsqlTypes.NpgsqlBox(top: 0.15319926752558288d,right: 0.8731411863744846d,bottom: 0.1027148528247136d,left: 0.855844335417836d),
new NpgsqlTypes.NpgsqlBox(top: 0.8485420083023967d,right: 0.47392226428214235d,bottom: 0.7682446450265759d,left: 0.3620129515431134d),
}));
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
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6277757124385139d,right: 0.5721388581935396d,bottom: 0.2548070110329249d,left: 0.535267951398751d),
new NpgsqlTypes.NpgsqlBox(top: 0.4543370692386993d,right: 0.6155413403046845d,bottom: 0.27947915979130944d,left: 0.25614404742390573d),
new NpgsqlTypes.NpgsqlBox(top: 0.8742717778067479d,right: 0.6825572397070852d,bottom: 0.5711709238811684d,left: 0.5726422524206585d),
new NpgsqlTypes.NpgsqlBox(top: 0.33518351073979546d,right: 0.7689738831478818d,bottom: 0.14550103182156393d,left: 0.49941465646562266d),
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
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.999526432510562d,right: 0.758624991100758d,bottom: 0.13601606547233747d,left: 0.4556215127103326d),
new NpgsqlTypes.NpgsqlBox(top: 0.9917515227449011d,right: 0.8770868902380768d,bottom: 0.07072852425830245d,left: 0.05616911849985062d),
new NpgsqlTypes.NpgsqlBox(top: 0.44091030485778027d,right: 0.8299774633543813d,bottom: 0.21859306187958794d,left: 0.25641730887841985d),
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 104, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 109, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
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

