

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
    internal partial interface INpgsqlBoxMArrayboxMArrayD1
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMArrayD1 : INpgsqlBoxMArrayboxMArrayD1
    {


#region TestData

        private readonly NpgsqlBoxboxMArrayD1E1M[] _testData = new NpgsqlBoxboxMArrayD1E1M[]
        {
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8832288025465722d,right: 0.22072782802824942d,bottom: 0.11150377720028781d,left: 0.18984195219395406d),
new NpgsqlTypes.NpgsqlBox(top: 0.8910982263453161d,right: 0.9700668537889955d,bottom: 0.7909284723813631d,left: 0.22695308113034351d),
new NpgsqlTypes.NpgsqlBox(top: 0.9523763418956928d,right: 0.9906074849902022d,bottom: 0.1995266596275984d,left: 0.32681082042381326d),
new NpgsqlTypes.NpgsqlBox(top: 0.49705913069781915d,right: 0.8799065437707935d,bottom: 0.14638542904270502d,left: 0.04090286867750481d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5218765441625024d,right: 0.836558958153416d,bottom: 0.4790628592441303d,left: 0.4856278907931789d),
new NpgsqlTypes.NpgsqlBox(top: 0.929451525965708d,right: 0.673586347866171d,bottom: 0.4430270426518438d,left: 0.6582189667082429d),
new NpgsqlTypes.NpgsqlBox(top: 0.21523340622879983d,right: 0.5535300637952774d,bottom: 0.17782743070439078d,left: 0.38700161828747515d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.955029785562204d,right: 0.929653724678007d,bottom: 0.6657525246092341d,left: 0.09285321294542226d),
new NpgsqlTypes.NpgsqlBox(top: 0.5918134287025736d,right: 0.2962832644758594d,bottom: 0.15281826198486637d,left: 0.24616646086887772d),
new NpgsqlTypes.NpgsqlBox(top: 0.5077155814536571d,right: 0.6257792065100742d,bottom: 0.4580715091486033d,left: 0.19678355320222451d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7657861901077878d,right: 0.4462120200115206d,bottom: 0.4781466380135292d,left: 0.08742466831912987d),
new NpgsqlTypes.NpgsqlBox(top: 0.7134994555684475d,right: 0.8062094001676184d,bottom: 0.5873076490348155d,left: 0.2760479399018064d),
new NpgsqlTypes.NpgsqlBox(top: 0.5004965887395988d,right: 0.8904071882452833d,bottom: 0.037759391591529634d,left: 0.10711952427891935d),
new NpgsqlTypes.NpgsqlBox(top: 0.4757106072131069d,right: 0.9229867593084247d,bottom: 0.19814867363857347d,left: 0.015746633604949656d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7349888973826182d,right: 0.9237966181208271d,bottom: 0.3903510173130099d,left: 0.31669735087515505d),
new NpgsqlTypes.NpgsqlBox(top: 0.5836345401281773d,right: 0.5892194999975066d,bottom: 0.11706675696596147d,left: 0.07025181408855674d),
new NpgsqlTypes.NpgsqlBox(top: 0.9803125684893883d,right: 0.7819372655108053d,bottom: 0.3585801909112212d,left: 0.5431693412882929d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7436934164263969d,right: 0.7968792748037862d,bottom: 0.09592369098008824d,left: 0.32479023761255454d),
new NpgsqlTypes.NpgsqlBox(top: 0.8579342330549076d,right: 0.8949871985207091d,bottom: 0.6420536864320565d,left: 0.2891784630745443d),
new NpgsqlTypes.NpgsqlBox(top: 0.23137762811169404d,right: 0.8383795891390956d,bottom: 0.11166057445819644d,left: 0.14615966305512362d),
new NpgsqlTypes.NpgsqlBox(top: 0.21364142319135304d,right: 0.9397354752721246d,bottom: 0.14064423565254558d,left: 0.023926619380116754d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9135916760175362d,right: 0.7370154690475386d,bottom: 0.7950802933969755d,left: 0.33902327297133994d),
new NpgsqlTypes.NpgsqlBox(top: 0.24534898987038167d,right: 0.5673379981119929d,bottom: 0.21322066124799932d,left: 0.3672865500059832d),
new NpgsqlTypes.NpgsqlBox(top: 0.7136858212278335d,right: 0.9349805229035199d,bottom: 0.13055077376533475d,left: 0.8118548795762589d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35603501942182203d,right: 0.812599761893897d,bottom: 0.24603668201534978d,left: 0.7351273400827693d),
new NpgsqlTypes.NpgsqlBox(top: 0.27417844740526387d,right: 0.7525000458583594d,bottom: 0.16229978631381847d,left: 0.15336697320412507d),
new NpgsqlTypes.NpgsqlBox(top: 0.9926662488937146d,right: 0.4977383195302051d,bottom: 0.6043473979550636d,left: 0.17584444605202676d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9338851809584656d,right: 0.8215292446188198d,bottom: 0.3142320714166984d,left: 0.15547299311113938d),
new NpgsqlTypes.NpgsqlBox(top: 0.6089881736622734d,right: 0.9691010084377436d,bottom: 0.5981690004781753d,left: 0.4741211938745463d),
new NpgsqlTypes.NpgsqlBox(top: 0.953444769655053d,right: 0.6207151025063739d,bottom: 0.5969438657888645d,left: 0.5773809982141568d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6239757235672413d,right: 0.9680705474837497d,bottom: 0.4525326501035064d,left: 0.7946392708907959d),
new NpgsqlTypes.NpgsqlBox(top: 0.6674937764207637d,right: 0.7013640378124528d,bottom: 0.3766446846650482d,left: 0.3292811090839842d),
new NpgsqlTypes.NpgsqlBox(top: 0.8067883580081381d,right: 0.9597157887157154d,bottom: 0.07185626071833406d,left: 0.5413188393301985d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8475157238206996d,right: 0.9691899267393459d,bottom: 0.3031758336536553d,left: 0.11390678353240591d),
new NpgsqlTypes.NpgsqlBox(top: 0.4327197148813309d,right: 0.2338002851177845d,bottom: 0.09405365316748582d,left: 0.22453016293566552d),
new NpgsqlTypes.NpgsqlBox(top: 0.6553416723035052d,right: 0.25538658783923296d,bottom: 0.1797835144109854d,left: 0.2399276999460329d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7618759646853666d,right: 0.27135982290487604d,bottom: 0.48318250212307146d,left: 0.19619851834699986d),
new NpgsqlTypes.NpgsqlBox(top: 0.972614245131535d,right: 0.5475154434576913d,bottom: 0.2138825485177971d,left: 0.4383613784270697d),
new NpgsqlTypes.NpgsqlBox(top: 0.7869158005514603d,right: 0.8012629058510363d,bottom: 0.16058847155889d,left: 0.06201011823533942d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6294147357924568d,right: 0.26476019151242036d,bottom: 0.5396436104796434d,left: 0.22619349514717924d),
new NpgsqlTypes.NpgsqlBox(top: 0.2290918510714589d,right: 0.4027856195391578d,bottom: 0.16708190187584215d,left: 0.21361649561850038d),
new NpgsqlTypes.NpgsqlBox(top: 0.6996552009667134d,right: 0.4772245037465166d,bottom: 0.1273574829124109d,left: 0.4664833015371539d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5101884713718395d,right: 0.6082464313358104d,bottom: 0.44589554659851927d,left: 0.5296093839678504d),
new NpgsqlTypes.NpgsqlBox(top: 0.5647951755388146d,right: 0.8247090852575002d,bottom: 0.37489851250665107d,left: 0.18386015824480006d),
new NpgsqlTypes.NpgsqlBox(top: 0.9609902766833669d,right: 0.9956933710816194d,bottom: 0.8873250832576253d,left: 0.4109373055862532d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6689496354480747d,right: 0.09409997114254587d,bottom: 0.606621116483732d,left: 0.09077332827874696d),
new NpgsqlTypes.NpgsqlBox(top: 0.7117591481792291d,right: 0.9273013776860264d,bottom: 0.5207871105722529d,left: 0.7715172127269678d),
new NpgsqlTypes.NpgsqlBox(top: 0.8121288538910851d,right: 0.2954573721862852d,bottom: 0.5058475718128014d,left: 0.12225625071579072d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5991289281347463d,right: 0.7967396979714176d,bottom: 0.10617396266662504d,left: 0.7453720943861397d),
new NpgsqlTypes.NpgsqlBox(top: 0.8124160988185126d,right: 0.8501792688827446d,bottom: 0.7918057856321801d,left: 0.8067217830907264d),
new NpgsqlTypes.NpgsqlBox(top: 0.8302238519580397d,right: 0.20682573521849457d,bottom: 0.7459610810054405d,left: 0.01913473497257001d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8578203201204371d,right: 0.9144183912232793d,bottom: 0.02351240488764672d,left: 0.35577418084400037d),
new NpgsqlTypes.NpgsqlBox(top: 0.8951963342494803d,right: 0.9327009249621198d,bottom: 0.006983930136715943d,left: 0.7751991340498445d),
new NpgsqlTypes.NpgsqlBox(top: 0.94606640205797d,right: 0.69441801551178d,bottom: 0.8591183080062575d,left: 0.22728892948189083d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.04259110419061418d,right: 0.9816420215359293d,bottom: 0.03208072311882848d,left: 0.046382268379955294d),
new NpgsqlTypes.NpgsqlBox(top: 0.9466421296483463d,right: 0.5433931526900917d,bottom: 0.08837043411076984d,left: 0.5431834038177451d),
new NpgsqlTypes.NpgsqlBox(top: 0.9944965659881089d,right: 0.6796765538419255d,bottom: 0.3507475312778139d,left: 0.5615353519541114d),
new NpgsqlTypes.NpgsqlBox(top: 0.9470948867272404d,right: 0.9868705234972649d,bottom: 0.2922333202304568d,left: 0.30660532917010075d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7969783192717218d,right: 0.596661283454578d,bottom: 0.6532569832344023d,left: 0.3744456613414884d),
new NpgsqlTypes.NpgsqlBox(top: 0.7571572640621073d,right: 0.5638384322622375d,bottom: 0.60899003592939d,left: 0.327236213869439d),
new NpgsqlTypes.NpgsqlBox(top: 0.5207906324804344d,right: 0.7043918429453142d,bottom: 0.1427517514535065d,left: 0.6189456813435805d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9368503840981555d,right: 0.36216944409216134d,bottom: 0.11833228349181213d,left: 0.3573358234641484d),
new NpgsqlTypes.NpgsqlBox(top: 0.8996501806747544d,right: 0.7468855109866896d,bottom: 0.2551752879596074d,left: 0.33435209418454825d),
new NpgsqlTypes.NpgsqlBox(top: 0.9821703465178138d,right: 0.8571841365010792d,bottom: 0.025847113563178814d,left: 0.1324914135206332d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8490845695914974d,right: 0.24525214975583354d,bottom: 0.7501783682798713d,left: 0.12394261619195257d),
new NpgsqlTypes.NpgsqlBox(top: 0.6195082524968977d,right: 0.4693382960371302d,bottom: 0.0494756350839165d,left: 0.37510799323264554d),
new NpgsqlTypes.NpgsqlBox(top: 0.8991198710824132d,right: 0.5273618273568017d,bottom: 0.4039734305210315d,left: 0.010456101662598472d),
new NpgsqlTypes.NpgsqlBox(top: 0.765646893049193d,right: 0.8876673178570527d,bottom: 0.39901956921784d,left: 0.15087081140828829d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9227670350954811d,right: 0.2967379563383036d,bottom: 0.1384840406050456d,left: 0.07938171867417398d),
new NpgsqlTypes.NpgsqlBox(top: 0.5714127709603289d,right: 0.8511247290187993d,bottom: 0.0034505378033481415d,left: 0.29376064381724953d),
new NpgsqlTypes.NpgsqlBox(top: 0.8152742130744556d,right: 0.5770711119841768d,bottom: 0.4998208381799354d,left: 0.5350650600685499d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5583420236101757d,right: 0.9651455080376999d,bottom: 0.06475263224055894d,left: 0.9204488926214027d),
new NpgsqlTypes.NpgsqlBox(top: 0.9984078354594373d,right: 0.6346652921429031d,bottom: 0.27241035304634476d,left: 0.16435750057661547d),
new NpgsqlTypes.NpgsqlBox(top: 0.9221949834297534d,right: 0.7757479299815139d,bottom: 0.15111921148256846d,left: 0.16586671613561643d),
new NpgsqlTypes.NpgsqlBox(top: 0.8874431460911733d,right: 0.7233448283335557d,bottom: 0.2578417072732502d,left: 0.3485457012935441d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7462308467045046d,right: 0.23581348377083478d,bottom: 0.21977722326694227d,left: 0.16910823291395638d),
new NpgsqlTypes.NpgsqlBox(top: 0.9842732040223825d,right: 0.3512855963496049d,bottom: 0.8171537148394054d,left: 0.11498220674924597d),
new NpgsqlTypes.NpgsqlBox(top: 0.5627479220814612d,right: 0.8392011282335903d,bottom: 0.11184803765510043d,left: 0.09581646400686317d),
new NpgsqlTypes.NpgsqlBox(top: 0.606167996569618d,right: 0.4892270048007906d,bottom: 0.25210316792445586d,left: 0.47699766526481846d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7555908715248175d,right: 0.5795029252344525d,bottom: 0.02489558158684224d,left: 0.11267194465202068d),
new NpgsqlTypes.NpgsqlBox(top: 0.9717875159286117d,right: 0.8093287071050077d,bottom: 0.7065595380889077d,left: 0.5058759073001236d),
new NpgsqlTypes.NpgsqlBox(top: 0.8788398333782824d,right: 0.4357747049460893d,bottom: 0.036185877156253765d,left: 0.1153259052804827d),
new NpgsqlTypes.NpgsqlBox(top: 0.915405561712595d,right: 0.9369513106349363d,bottom: 0.866234341493958d,left: 0.009998632716754496d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12183940668685755d,right: 0.6506423926298966d,bottom: 0.08618506147113536d,left: 0.4420935932747059d),
new NpgsqlTypes.NpgsqlBox(top: 0.5990063127377597d,right: 0.5658980059776182d,bottom: 0.4770195264879785d,left: 0.18451592042991616d),
new NpgsqlTypes.NpgsqlBox(top: 0.6030895931133938d,right: 0.8199347023812698d,bottom: 0.42357344946993736d,left: 0.7479914686033261d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32432934981797334d,right: 0.8678866358621142d,bottom: 0.04442667994986382d,left: 0.060595937604536965d),
new NpgsqlTypes.NpgsqlBox(top: 0.5205659128929419d,right: 0.9640562332484203d,bottom: 0.4318178585875201d,left: 0.3982177591620166d),
new NpgsqlTypes.NpgsqlBox(top: 0.7690591485136947d,right: 0.5409686434601998d,bottom: 0.2582878000929586d,left: 0.29372956952651674d),
new NpgsqlTypes.NpgsqlBox(top: 0.8763357416577924d,right: 0.5871552883407671d,bottom: 0.4181326931266818d,left: 0.35585771359645346d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9873370599734106d,right: 0.6922300049723131d,bottom: 0.8818653409668655d,left: 0.23127450952621997d),
new NpgsqlTypes.NpgsqlBox(top: 0.6431359708226658d,right: 0.7813992161875746d,bottom: 0.20531075213167194d,left: 0.019636037185115862d),
new NpgsqlTypes.NpgsqlBox(top: 0.7453659616183163d,right: 0.7194915057248569d,bottom: 0.3033410057314029d,left: 0.09502242924657611d),
new NpgsqlTypes.NpgsqlBox(top: 0.41802816327370784d,right: 0.46822245357012293d,bottom: 0.26743826631820533d,left: 0.4295478670210755d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8429966973300707d,right: 0.942726847432337d,bottom: 0.8180674468886145d,left: 0.39025699451055074d),
new NpgsqlTypes.NpgsqlBox(top: 0.32560268394720804d,right: 0.7764878463007987d,bottom: 0.2652459851930925d,left: 0.3863028615644485d),
new NpgsqlTypes.NpgsqlBox(top: 0.45317861453158703d,right: 0.8010481076976032d,bottom: 0.18448190929878194d,left: 0.11797937893367749d),
new NpgsqlTypes.NpgsqlBox(top: 0.9405130441682725d,right: 0.3829045769964835d,bottom: 0.3840525670564414d,left: 0.03221928194979262d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9353146494628253d,right: 0.4778049599412191d,bottom: 0.095465067796073d,left: 0.46769270653258466d),
new NpgsqlTypes.NpgsqlBox(top: 0.9097217001172991d,right: 0.4236582214147998d,bottom: 0.5430495523996166d,left: 0.2931862756841429d),
new NpgsqlTypes.NpgsqlBox(top: 0.9959603593903605d,right: 0.6352395336463482d,bottom: 0.7647556775492221d,left: 0.5174020260802831d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41967122555444825d,right: 0.665578359137348d,bottom: 0.34172500573873876d,left: 0.1436523073658652d),
new NpgsqlTypes.NpgsqlBox(top: 0.9656793050194065d,right: 0.7992921954024007d,bottom: 0.7195688406216942d,left: 0.15183198390271047d),
new NpgsqlTypes.NpgsqlBox(top: 0.9759005127864098d,right: 0.6248334508239508d,bottom: 0.9658076728376951d,left: 0.5976082370391802d),
new NpgsqlTypes.NpgsqlBox(top: 0.5343493642815472d,right: 0.619556044589071d,bottom: 0.46908099381752244d,left: 0.36462213936498455d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5402663755020968d,right: 0.19895429389191865d,bottom: 0.06938639561506277d,left: 0.1054275706995299d),
new NpgsqlTypes.NpgsqlBox(top: 0.8370919253162649d,right: 0.5984580734548299d,bottom: 0.20409686075325273d,left: 0.399802572408284d),
new NpgsqlTypes.NpgsqlBox(top: 0.20025974924589995d,right: 0.786844288143345d,bottom: 0.030888070650518462d,left: 0.12732525264609795d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9119648189460623d,right: 0.6933836506684893d,bottom: 0.5049587512182194d,left: 0.004650616748702929d),
new NpgsqlTypes.NpgsqlBox(top: 0.2976730387130677d,right: 0.8285321751898508d,bottom: 0.04213347954674829d,left: 0.1655792294473435d),
new NpgsqlTypes.NpgsqlBox(top: 0.2841561147480518d,right: 0.5416348155122687d,bottom: 0.21343009077150077d,left: 0.032155302455703194d),
new NpgsqlTypes.NpgsqlBox(top: 0.6212864127860521d,right: 0.4519455767731295d,bottom: 0.24342922186397065d,left: 0.1013979451735153d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2828918390278843d,right: 0.9989704590509025d,bottom: 0.06307933054949866d,left: 0.7205659367447247d),
new NpgsqlTypes.NpgsqlBox(top: 0.39168660925618026d,right: 0.8801352946765242d,bottom: 0.03503889920307346d,left: 0.3761333952014141d),
new NpgsqlTypes.NpgsqlBox(top: 0.29276462101631273d,right: 0.7834239215386428d,bottom: 0.16813616464978542d,left: 0.7687049308209618d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8787991337681139d,right: 0.6275138314581943d,bottom: 0.8612952144400929d,left: 0.1869453445628293d),
new NpgsqlTypes.NpgsqlBox(top: 0.5486249605676732d,right: 0.2800023889710619d,bottom: 0.14444868881653095d,left: 0.13970987409208802d),
new NpgsqlTypes.NpgsqlBox(top: 0.5467550948109008d,right: 0.9041139834342256d,bottom: 0.2769132951815314d,left: 0.18649798313089916d),
new NpgsqlTypes.NpgsqlBox(top: 0.6335545106078736d,right: 0.6660952400857019d,bottom: 0.28300522655729654d,left: 0.5712098982784253d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25502631951826193d,right: 0.6910781492849232d,bottom: 0.008845145508213137d,left: 0.2251351156265693d),
new NpgsqlTypes.NpgsqlBox(top: 0.1074294674737325d,right: 0.4378952820114218d,bottom: 0.01654142107606038d,left: 0.39179163483725d),
new NpgsqlTypes.NpgsqlBox(top: 0.2653233448709392d,right: 0.24463727204472552d,bottom: 0.16734070441173676d,left: 0.10419787414818482d),
new NpgsqlTypes.NpgsqlBox(top: 0.8250836520299891d,right: 0.6757586986864955d,bottom: 0.2298188158497212d,left: 0.1666734914901984d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5669059558936408d,right: 0.41145099089786774d,bottom: 0.279738256804582d,left: 0.012347309889679803d),
new NpgsqlTypes.NpgsqlBox(top: 0.5388568902870944d,right: 0.8495301955091878d,bottom: 0.285641544251232d,left: 0.6029866830952705d),
new NpgsqlTypes.NpgsqlBox(top: 0.8150835377826303d,right: 0.6215156363207894d,bottom: 0.0038857463414196936d,left: 0.3269143774534581d),
new NpgsqlTypes.NpgsqlBox(top: 0.6812597813127675d,right: 0.4771519058072814d,bottom: 0.6047431788672659d,left: 0.13225092552494067d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5867375120524623d,right: 0.5757650994401063d,bottom: 0.3365189625960434d,left: 0.2660400066821298d),
new NpgsqlTypes.NpgsqlBox(top: 0.4542263081767225d,right: 0.976481865700989d,bottom: 0.3109992358248802d,left: 0.7471467420261035d),
new NpgsqlTypes.NpgsqlBox(top: 0.36175009677918923d,right: 0.6218612293482316d,bottom: 0.03249372421786223d,left: 0.4113746706142959d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4811765325394426d,right: 0.37608975749942897d,bottom: 0.04440224598874942d,left: 0.022959724982491325d),
new NpgsqlTypes.NpgsqlBox(top: 0.735063078674006d,right: 0.2565129174835017d,bottom: 0.11828786169051986d,left: 0.03496351366194239d),
new NpgsqlTypes.NpgsqlBox(top: 0.8741997143256389d,right: 0.8595023336776199d,bottom: 0.14535738532646203d,left: 0.811817539878693d),
new NpgsqlTypes.NpgsqlBox(top: 0.5719869121836121d,right: 0.5201295717258824d,bottom: 0.486537041985569d,left: 0.3020177274713538d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5766726691799833d,right: 0.6939785107853319d,bottom: 0.5545692906589849d,left: 0.5063908111504788d),
new NpgsqlTypes.NpgsqlBox(top: 0.7097858920148851d,right: 0.2188912957501642d,bottom: 0.6087389021177998d,left: 0.17719720292905805d),
new NpgsqlTypes.NpgsqlBox(top: 0.987274162246723d,right: 0.5236918688569121d,bottom: 0.41236629226417d,left: 0.21871245591638655d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9738278446434537d,right: 0.8937419419240942d,bottom: 0.6445765741473134d,left: 0.47413858870067993d),
new NpgsqlTypes.NpgsqlBox(top: 0.8822225957095363d,right: 0.46886474476170714d,bottom: 0.5873535352796886d,left: 0.392332030042602d),
new NpgsqlTypes.NpgsqlBox(top: 0.6514385673510358d,right: 0.675789261191309d,bottom: 0.33596986282009667d,left: 0.10485613224531487d),
new NpgsqlTypes.NpgsqlBox(top: 0.7801864574913495d,right: 0.7965990213304043d,bottom: 0.017857375690142896d,left: 0.6094596721976147d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5934315349701478d,right: 0.47383776652083665d,bottom: 0.15700184364233993d,left: 0.4615685906480107d),
new NpgsqlTypes.NpgsqlBox(top: 0.34077799801659214d,right: 0.6467886158445636d,bottom: 0.095855629325455d,left: 0.33026659269790226d),
new NpgsqlTypes.NpgsqlBox(top: 0.8781288425403041d,right: 0.860513105656437d,bottom: 0.14158621702611207d,left: 0.7126234954717416d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7614279167733838d,right: 0.8709556161977444d,bottom: 0.3904866749754974d,left: 0.6264555342375056d),
new NpgsqlTypes.NpgsqlBox(top: 0.4049641886976716d,right: 0.8621998044840659d,bottom: 0.0596901526086282d,left: 0.22101527354024342d),
new NpgsqlTypes.NpgsqlBox(top: 0.8502622705213814d,right: 0.7914673128980816d,bottom: 0.6311684324660801d,left: 0.14724104682093386d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6230895478082038d,right: 0.6227807188094502d,bottom: 0.5532010584731847d,left: 0.005942624239092642d),
new NpgsqlTypes.NpgsqlBox(top: 0.7726072628096682d,right: 0.7776281591141184d,bottom: 0.21758098229764822d,left: 0.5604145364344043d),
new NpgsqlTypes.NpgsqlBox(top: 0.07808748915719754d,right: 0.2256956040167043d,bottom: 0.03878202566884448d,left: 0.006710740490994849d),
new NpgsqlTypes.NpgsqlBox(top: 0.9861561516342259d,right: 0.7577444800700418d,bottom: 0.8593572302845165d,left: 0.18160912107397476d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5737682566253133d,right: 0.9984171687629081d,bottom: 0.3367302072550077d,left: 0.5557408386130462d),
new NpgsqlTypes.NpgsqlBox(top: 0.33863837151886733d,right: 0.8319678911354698d,bottom: 0.19018722986594305d,left: 0.514369814012243d),
new NpgsqlTypes.NpgsqlBox(top: 0.9451490933396582d,right: 0.2368670731607253d,bottom: 0.32941226427944303d,left: 0.06075274264648356d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6498062236925063d,right: 0.5469079607066657d,bottom: 0.3703344828773397d,left: 0.33618065354098114d),
new NpgsqlTypes.NpgsqlBox(top: 0.9701044239762068d,right: 0.5138114201106001d,bottom: 0.2922692336843574d,left: 0.08037514367564935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8025193115326843d,right: 0.3311094306430873d,bottom: 0.5789149362580016d,left: 0.2768578402191888d),
new NpgsqlTypes.NpgsqlBox(top: 0.8443949462756457d,right: 0.09357089056549084d,bottom: 0.38977436711391866d,left: 0.010379583560021777d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4680596476747173d,right: 0.3790719509104531d,bottom: 0.10848197748372923d,left: 0.17524547653881262d),
new NpgsqlTypes.NpgsqlBox(top: 0.7600844045191562d,right: 0.4902092633521711d,bottom: 0.6968238807138055d,left: 0.09480070244811256d),
new NpgsqlTypes.NpgsqlBox(top: 0.8783662825267073d,right: 0.8799193834143592d,bottom: 0.36715297568273697d,left: 0.7243327827960461d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9760646104072657d,right: 0.865910170387773d,bottom: 0.5382001209172024d,left: 0.4125629324298401d),
new NpgsqlTypes.NpgsqlBox(top: 0.7159042285778916d,right: 0.7956721285411442d,bottom: 0.40586148825118795d,left: 0.13178917463378292d),
new NpgsqlTypes.NpgsqlBox(top: 0.9434932463745193d,right: 0.6330958374397253d,bottom: 0.7204843285167153d,left: 0.1647630723377118d),
new NpgsqlTypes.NpgsqlBox(top: 0.3784331095789527d,right: 0.7753825913543001d,bottom: 0.15536977885051195d,left: 0.4853742398975176d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7060357188219898d,right: 0.7409096229318338d,bottom: 0.17181935967074868d,left: 0.41340805646822265d),
new NpgsqlTypes.NpgsqlBox(top: 0.8738406909175093d,right: 0.559932368404654d,bottom: 0.46643047244832725d,left: 0.47543034565574904d),
new NpgsqlTypes.NpgsqlBox(top: 0.9153121139237327d,right: 0.2908546305847032d,bottom: 0.13517955156921713d,left: 0.2760607007200935d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25993206671155666d,right: 0.8561541540608912d,bottom: 0.25624247173754977d,left: 0.45114415284079035d),
new NpgsqlTypes.NpgsqlBox(top: 0.5442476945777871d,right: 0.2053639531940321d,bottom: 0.07103699802680241d,left: 0.10571519068120794d),
new NpgsqlTypes.NpgsqlBox(top: 0.8248408228441997d,right: 0.6722232031877877d,bottom: 0.15322739788510675d,left: 0.5838182061491601d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5236491149920639d,right: 0.46862038856689525d,bottom: 0.0852686951255257d,left: 0.16770051310383138d),
new NpgsqlTypes.NpgsqlBox(top: 0.5214393348562242d,right: 0.8746374295605274d,bottom: 0.057965493116656d,left: 0.1958750886225752d),
new NpgsqlTypes.NpgsqlBox(top: 0.593849299237909d,right: 0.66620889367662d,bottom: 0.02682342201315957d,left: 0.665440442785864d),
new NpgsqlTypes.NpgsqlBox(top: 0.4367233060772798d,right: 0.8831676566954626d,bottom: 0.29913819289158095d,left: 0.8581649162486555d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6099669660358654d,right: 0.49493827179461025d,bottom: 0.16983392993256174d,left: 0.15353981384965953d),
new NpgsqlTypes.NpgsqlBox(top: 0.6546156384245838d,right: 0.7072216163464519d,bottom: 0.5160200764259605d,left: 0.27558770201485006d),
new NpgsqlTypes.NpgsqlBox(top: 0.785900424710696d,right: 0.7153119818059044d,bottom: 0.18134419995320328d,left: 0.6004992578114734d),
new NpgsqlTypes.NpgsqlBox(top: 0.805387093610409d,right: 0.8182173704913835d,bottom: 0.5974146679456039d,left: 0.3366681706821604d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9973041923195095d,right: 0.42000267358969745d,bottom: 0.9837345677074014d,left: 0.1825980116547875d),
new NpgsqlTypes.NpgsqlBox(top: 0.7402555166265384d,right: 0.5694141505237315d,bottom: 0.26996231856809316d,left: 0.020212186320837433d),
new NpgsqlTypes.NpgsqlBox(top: 0.44238660379020356d,right: 0.5732872060985618d,bottom: 0.2593722605807375d,left: 0.04635736198192286d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.69702460056956d,right: 0.4583383906094268d,bottom: 0.22514713595020153d,left: 0.07430712447780963d),
new NpgsqlTypes.NpgsqlBox(top: 0.7233090460443758d,right: 0.7473453929822809d,bottom: 0.04014641423888954d,left: 0.5124628507162059d),
new NpgsqlTypes.NpgsqlBox(top: 0.3469113493294379d,right: 0.5476556166232588d,bottom: 0.2746010171626817d,left: 0.1481080411430331d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33008643200314336d,right: 0.7248236856418354d,bottom: 0.31004585184857936d,left: 0.33750810951657073d),
new NpgsqlTypes.NpgsqlBox(top: 0.8492236527697422d,right: 0.9825390584145336d,bottom: 0.6282658014518239d,left: 0.41807583128466075d),
new NpgsqlTypes.NpgsqlBox(top: 0.6770152993833546d,right: 0.6832715809713056d,bottom: 0.445350209787568d,left: 0.005520138798513652d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7282534624815572d,right: 0.353375069820395d,bottom: 0.6459712800050176d,left: 0.18351333846678197d),
new NpgsqlTypes.NpgsqlBox(top: 0.9711165481544239d,right: 0.7246061970516667d,bottom: 0.7725889782961272d,left: 0.30026809986214775d),
new NpgsqlTypes.NpgsqlBox(top: 0.9499347933303784d,right: 0.8579068212470164d,bottom: 0.38617695087702997d,left: 0.038487634854855735d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.772758793083313d,right: 0.18079462930434909d,bottom: 0.5505054227315005d,left: 0.12062469662983633d),
new NpgsqlTypes.NpgsqlBox(top: 0.8815239694935134d,right: 0.41763096491113816d,bottom: 0.5744500863718339d,left: 0.18310121068903007d),
new NpgsqlTypes.NpgsqlBox(top: 0.43072337137792616d,right: 0.9651609539148007d,bottom: 0.08861364334380495d,left: 0.569785446809456d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7868944084715125d,right: 0.40964419049943157d,bottom: 0.4374650186568442d,left: 0.08470939554608958d),
new NpgsqlTypes.NpgsqlBox(top: 0.45996263297442064d,right: 0.9478002711352819d,bottom: 0.29744984721759216d,left: 0.38726509759951555d),
new NpgsqlTypes.NpgsqlBox(top: 0.9784331159626775d,right: 0.9494682377270736d,bottom: 0.8689020876819994d,left: 0.14006015310714937d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7351693054938127d,right: 0.5614004864249077d,bottom: 0.4606738163280989d,left: 0.4581076772381736d),
new NpgsqlTypes.NpgsqlBox(top: 0.6056285322188375d,right: 0.4730264540288458d,bottom: 0.3971700174234568d,left: 0.3716264692130935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8625255691608364d,right: 0.6480098571241498d,bottom: 0.3068539940549022d,left: 0.5913830751238605d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.24756729253452547d,right: 0.543767785256601d,bottom: 0.06828356646110989d,left: 0.10574542055050795d),
new NpgsqlTypes.NpgsqlBox(top: 0.9012703826311194d,right: 0.9957846543763087d,bottom: 0.40981153284150706d,left: 0.32132871573620714d),
new NpgsqlTypes.NpgsqlBox(top: 0.7298236677195248d,right: 0.8501680690770362d,bottom: 0.44130132815982803d,left: 0.15311732156616797d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9869065867824769d,right: 0.7262017641883729d,bottom: 0.22845860520985173d,left: 0.707676988076502d),
new NpgsqlTypes.NpgsqlBox(top: 0.8788821330049645d,right: 0.9446284927531902d,bottom: 0.029957503272135977d,left: 0.38754972661134435d),
new NpgsqlTypes.NpgsqlBox(top: 0.8848873720496235d,right: 0.7072236641282992d,bottom: 0.8666641420075142d,left: 0.10061652670811949d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8997431406777924d,right: 0.18888030461884664d,bottom: 0.6859375193550221d,left: 0.04277212185373458d),
new NpgsqlTypes.NpgsqlBox(top: 0.8605509089895305d,right: 0.3093115902942627d,bottom: 0.606781490897764d,left: 0.210215216764991d),
new NpgsqlTypes.NpgsqlBox(top: 0.3402859521556131d,right: 0.11663039600445102d,bottom: 0.3207523242272001d,left: 0.09566811642925044d),
new NpgsqlTypes.NpgsqlBox(top: 0.6615473966233637d,right: 0.7286266357186277d,bottom: 0.4180896448302428d,left: 0.5532858593025707d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.404858201961802d,right: 0.4552143352929393d,bottom: 0.03566507799690788d,left: 0.009123811526043135d),
new NpgsqlTypes.NpgsqlBox(top: 0.8469994374471981d,right: 0.2866584881101294d,bottom: 0.7071811652001121d,left: 0.10745897463164333d),
new NpgsqlTypes.NpgsqlBox(top: 0.8152328520544949d,right: 0.9154397081678034d,bottom: 0.1751779636862172d,left: 0.8550364713993482d),
new NpgsqlTypes.NpgsqlBox(top: 0.5291722911791793d,right: 0.12357672586505042d,bottom: 0.033922053541860286d,left: 0.05435041270859886d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8058871385693157d,right: 0.26113440482197214d,bottom: 0.4380495041356417d,left: 0.03715975538539984d),
new NpgsqlTypes.NpgsqlBox(top: 0.8574668507429161d,right: 0.9280086452602891d,bottom: 0.8418610770970016d,left: 0.8482804232503921d),
new NpgsqlTypes.NpgsqlBox(top: 0.856022393567575d,right: 0.4070320927358201d,bottom: 0.043246240757446874d,left: 0.035035601220195445d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10368469841248362d,right: 0.9519392116336413d,bottom: 0.025259817542360175d,left: 0.0006799608446264038d),
new NpgsqlTypes.NpgsqlBox(top: 0.866931306880944d,right: 0.8288898430606837d,bottom: 0.26072073609642843d,left: 0.6157717532017186d),
new NpgsqlTypes.NpgsqlBox(top: 0.5927322390862637d,right: 0.8518217589491607d,bottom: 0.4373449791698423d,left: 0.2571602850578836d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7053987840628441d,right: 0.2848057097081005d,bottom: 0.030153725878884652d,left: 0.27993980650353023d),
new NpgsqlTypes.NpgsqlBox(top: 0.20456224226716935d,right: 0.6080713120448606d,bottom: 0.10470222558406572d,left: 0.5685316412814163d),
new NpgsqlTypes.NpgsqlBox(top: 0.3198031431709808d,right: 0.3396983081177064d,bottom: 0.2052278767835507d,left: 0.05238474934232962d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5430680698082939d,right: 0.32440805184486177d,bottom: 0.42307526201707113d,left: 0.1032715976338493d),
new NpgsqlTypes.NpgsqlBox(top: 0.8476506823202562d,right: 0.7949695121755574d,bottom: 0.6520235371993864d,left: 0.17936143974442276d),
new NpgsqlTypes.NpgsqlBox(top: 0.47741879373454454d,right: 0.788850181775724d,bottom: 0.40808684507196324d,left: 0.5831327228852792d),
new NpgsqlTypes.NpgsqlBox(top: 0.3138734467141273d,right: 0.47300325036655855d,bottom: 0.30431933939105227d,left: 0.02357296612501214d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8308464015426519d,right: 0.7511260467754995d,bottom: 0.03886485250446481d,left: 0.5030780862254783d),
new NpgsqlTypes.NpgsqlBox(top: 0.992516356016267d,right: 0.8121681062727434d,bottom: 0.1676650392955481d,left: 0.1343498883824531d),
new NpgsqlTypes.NpgsqlBox(top: 0.6440260077256793d,right: 0.6866337939702777d,bottom: 0.3344531634132477d,left: 0.6358574720186323d),
new NpgsqlTypes.NpgsqlBox(top: 0.49784230442035393d,right: 0.20637918336807692d,bottom: 0.421977733851825d,left: 0.14151485892105475d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8054720674571504d,right: 0.7500351357613478d,bottom: 0.7742348007832296d,left: 0.42003615513194303d),
new NpgsqlTypes.NpgsqlBox(top: 0.6926548713897874d,right: 0.9726005266342043d,bottom: 0.5758763388801547d,left: 0.6018905267989703d),
new NpgsqlTypes.NpgsqlBox(top: 0.3214061405769313d,right: 0.40201237515198296d,bottom: 0.09945804555794546d,left: 0.2741047083105118d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33387954740778547d,right: 0.8597347091975713d,bottom: 0.28479848729667145d,left: 0.6089087137333772d),
new NpgsqlTypes.NpgsqlBox(top: 0.21301469714256427d,right: 0.3408890960249341d,bottom: 0.0914163015950098d,left: 0.2210797026555713d),
new NpgsqlTypes.NpgsqlBox(top: 0.6620752796542572d,right: 0.5787902349878167d,bottom: 0.27885321010863584d,left: 0.5668918289295773d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.712076806109108d,right: 0.4147948854204492d,bottom: 0.127194243206467d,left: 0.2143438208113677d),
new NpgsqlTypes.NpgsqlBox(top: 0.7106035563753449d,right: 0.2703941246949323d,bottom: 0.36900758614785867d,left: 0.18897772532312318d),
new NpgsqlTypes.NpgsqlBox(top: 0.9328346996257378d,right: 0.8116148104298753d,bottom: 0.7755641764071979d,left: 0.6911582763658533d),
new NpgsqlTypes.NpgsqlBox(top: 0.8731329498122717d,right: 0.4091753473889026d,bottom: 0.48174199145423047d,left: 0.04725138836265319d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7519058056077835d,right: 0.9800490653388834d,bottom: 0.05107319930691656d,left: 0.7594408409987005d),
new NpgsqlTypes.NpgsqlBox(top: 0.37156574327672676d,right: 0.8745080697920393d,bottom: 0.13762615911601872d,left: 0.3775245432300244d),
new NpgsqlTypes.NpgsqlBox(top: 0.6360099549179664d,right: 0.8648195741326559d,bottom: 0.01794825296485869d,left: 0.16733724187641263d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.60583018029589d,right: 0.8096971211302039d,bottom: 0.21951679665398116d,left: 0.7554444849605316d),
new NpgsqlTypes.NpgsqlBox(top: 0.6804284593833966d,right: 0.7368484592475805d,bottom: 0.0080169918128018d,left: 0.586235259039557d),
new NpgsqlTypes.NpgsqlBox(top: 0.8998720889935201d,right: 0.8186430050302894d,bottom: 0.01017233221228575d,left: 0.05632042759825995d),
new NpgsqlTypes.NpgsqlBox(top: 0.6904087749836153d,right: 0.9457536425059461d,bottom: 0.6354946555567393d,left: 0.33432460287426646d),
},
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8478304878379618d,right: 0.9032241632864086d,bottom: 0.45304239270901714d,left: 0.06169463215030746d),
new NpgsqlTypes.NpgsqlBox(top: 0.6799813926264955d,right: 0.9685824263188982d,bottom: 0.6382493440437742d,left: 0.7631538739449135d),
new NpgsqlTypes.NpgsqlBox(top: 0.6612712258852897d,right: 0.781222813215615d,bottom: 0.21052804221011479d,left: 0.76787292202273d),
new NpgsqlTypes.NpgsqlBox(top: 0.7184848469641116d,right: 0.5408596704563572d,bottom: 0.37046055845887116d,left: 0.044552135652832225d),
},
    ModelInner = new NpgsqlBoxboxMArrayD11MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9359286064133479d,right: 0.6711060190983551d,bottom: 0.47619528100219144d,left: 0.034838740676603974d),
new NpgsqlTypes.NpgsqlBox(top: 0.7970150157807192d,right: 0.16841959410197538d,bottom: 0.14153742206271436d,left: 0.13993093212690866d),
new NpgsqlTypes.NpgsqlBox(top: 0.8120076228785554d,right: 0.8445582838482328d,bottom: 0.7785278648123697d,left: 0.11963230545634351d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6931134046444188d,right: 0.8033009487755153d,bottom: 0.6821359783878338d,left: 0.46696545609286266d),
new NpgsqlTypes.NpgsqlBox(top: 0.6467218998589082d,right: 0.545007354039449d,bottom: 0.17895165780306221d,left: 0.0019282008796877026d),
new NpgsqlTypes.NpgsqlBox(top: 0.8447598084243058d,right: 0.6650376693749848d,bottom: 0.10645669393217883d,left: 0.5032850105629214d),
new NpgsqlTypes.NpgsqlBox(top: 0.8668360890967188d,right: 0.3607970922146013d,bottom: 0.7506903686040377d,left: 0.08432255013350387d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD1E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8990355919557341d,right: 0.9575271160102906d,bottom: 0.25300057689263733d,left: 0.7030794687625069d),
new NpgsqlTypes.NpgsqlBox(top: 0.10960700973078141d,right: 0.14232660369638594d,bottom: 0.054581205407823186d,left: 0.0618689404203121d),
new NpgsqlTypes.NpgsqlBox(top: 0.9648757576190053d,right: 0.6858232470648011d,bottom: 0.15622718010216263d,left: 0.1155424189486931d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4822997629964544d,right: 0.5633319718892451d,bottom: 0.3513522345724821d,left: 0.5370864477196688d),
new NpgsqlTypes.NpgsqlBox(top: 0.9142626838927237d,right: 0.5390459994969947d,bottom: 0.46437342557655514d,left: 0.03819441313529215d),
new NpgsqlTypes.NpgsqlBox(top: 0.6317770704544929d,right: 0.6821595749201428d,bottom: 0.331368153813026d,left: 0.12025284000200542d),
new NpgsqlTypes.NpgsqlBox(top: 0.6262226722311389d,right: 0.8148566403114296d,bottom: 0.477472154805503d,left: 0.04652832456203304d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd11mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
INSERT INTO public.npgsqlboxboxmarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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

                changedRows =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)), 
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
                methodParametrName: "npgsqlboxboxmarrayd11mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd11mi_id
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
    npgsqlboxboxmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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

                    nullable =  ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8475157238206996d,right: 0.9691899267393459d,bottom: 0.3031758336536553d,left: 0.11390678353240591d),
new NpgsqlTypes.NpgsqlBox(top: 0.4327197148813309d,right: 0.2338002851177845d,bottom: 0.09405365316748582d,left: 0.22453016293566552d),
new NpgsqlTypes.NpgsqlBox(top: 0.6553416723035052d,right: 0.25538658783923296d,bottom: 0.1797835144109854d,left: 0.2399276999460329d),
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

                    nullable =  ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8578203201204371d,right: 0.9144183912232793d,bottom: 0.02351240488764672d,left: 0.35577418084400037d),
new NpgsqlTypes.NpgsqlBox(top: 0.8951963342494803d,right: 0.9327009249621198d,bottom: 0.006983930136715943d,left: 0.7751991340498445d),
new NpgsqlTypes.NpgsqlBox(top: 0.94606640205797d,right: 0.69441801551178d,bottom: 0.8591183080062575d,left: 0.22728892948189083d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd11mi_id
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
    npgsqlboxboxmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                methodParametrName: "npgsqlboxboxmarrayd11mi_id", 
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
                nullable =  ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8490845695914974d,right: 0.24525214975583354d,bottom: 0.7501783682798713d,left: 0.12394261619195257d),
new NpgsqlTypes.NpgsqlBox(top: 0.6195082524968977d,right: 0.4693382960371302d,bottom: 0.0494756350839165d,left: 0.37510799323264554d),
new NpgsqlTypes.NpgsqlBox(top: 0.8991198710824132d,right: 0.5273618273568017d,bottom: 0.4039734305210315d,left: 0.010456101662598472d),
new NpgsqlTypes.NpgsqlBox(top: 0.765646893049193d,right: 0.8876673178570527d,bottom: 0.39901956921784d,left: 0.15087081140828829d),
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
                nullable = await ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5583420236101757d,right: 0.9651455080376999d,bottom: 0.06475263224055894d,left: 0.9204488926214027d),
new NpgsqlTypes.NpgsqlBox(top: 0.9984078354594373d,right: 0.6346652921429031d,bottom: 0.27241035304634476d,left: 0.16435750057661547d),
new NpgsqlTypes.NpgsqlBox(top: 0.9221949834297534d,right: 0.7757479299815139d,bottom: 0.15111921148256846d,left: 0.16586671613561643d),
new NpgsqlTypes.NpgsqlBox(top: 0.8874431460911733d,right: 0.7233448283335557d,bottom: 0.2578417072732502d,left: 0.3485457012935441d),
}));
                nullable = await ((INpgsqlBoxMArrayboxMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32432934981797334d,right: 0.8678866358621142d,bottom: 0.04442667994986382d,left: 0.060595937604536965d),
new NpgsqlTypes.NpgsqlBox(top: 0.5205659128929419d,right: 0.9640562332484203d,bottom: 0.4318178585875201d,left: 0.3982177591620166d),
new NpgsqlTypes.NpgsqlBox(top: 0.7690591485136947d,right: 0.5409686434601998d,bottom: 0.2582878000929586d,left: 0.29372956952651674d),
new NpgsqlTypes.NpgsqlBox(top: 0.8763357416577924d,right: 0.5871552883407671d,bottom: 0.4181326931266818d,left: 0.35585771359645346d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMArrayD1E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMArrayD1E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M), typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmarrayd11mi mi ON mi.id = m.npgsqlboxboxmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M), typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmarrayd11mi mi ON mi.id = m.npgsqlboxboxmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M), typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmarrayd11mi mi ON mi.id = m.npgsqlboxboxmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M), typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 168, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
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
FROM public.npgsqlboxboxmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmarrayd11mi mi ON mi.id = m.npgsqlboxboxmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 53, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 115, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 168);
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((INpgsqlBoxMArrayboxMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                NpgsqlBoxboxMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
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
FROM public.binary_npgsqlboxboxmarrayd1e1m m
LEFT JOIN public.binary_npgsqlboxboxmarrayd11mi mi ON mi.id = m.npgsqlboxboxmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models =  ((INpgsqlBoxMArrayboxMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA), typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
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
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
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
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA), typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
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
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmarrayd11mi
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
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MI), typeof(NpgsqlBoxboxMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MI>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MI>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MI>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MI>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA), typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD11MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

